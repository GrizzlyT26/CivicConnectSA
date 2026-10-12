
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CivicConnectSA.Helpers;
using CivicConnectSA.Models;

namespace CivicConnectSA.Forms
{
    public partial class LocalEventsForm : Form
    {
        private bool isInitialising = true;

        public LocalEventsForm()
        {
            InitializeComponent();

            EventDataStore.Initialise();

            ConfigureForm();
            LoadCategories();

            // Connect the form controls to their event handlers.
            btnSearch.Click += btnSearch_Click;
            btnClearFilters.Click += btnClearFilters_Click;
            btnBack.Click += btnBack_Click;

            lstEvents.SelectedIndexChanged +=
                lstEvents_SelectedIndexChanged;

            lstRecommendations.SelectedIndexChanged +=
                lstRecommendations_SelectedIndexChanged;

            txtSearch.TextChanged += txtSearch_TextChanged;

            cmbCategory.SelectedIndexChanged +=
                cmbCategory_SelectedIndexChanged;

            dtpFromDate.ValueChanged += DateFilter_ValueChanged;
            dtpToDate.ValueChanged += DateFilter_ValueChanged;

            isInitialising = false;

            DisplayEvents();
        }

        private void ConfigureForm()
        {
            Text = "Local Events & Announcements";
            StartPosition = FormStartPosition.CenterScreen;

            // Set the default date range.
            dtpFromDate.Value = DateTime.Today;
            dtpToDate.Value = DateTime.Today.AddMonths(3);

            // Improve the readability of event lists.
            lstEvents.HorizontalScrollbar = true;
            lstRecommendations.HorizontalScrollbar = true;

            lstEvents.IntegralHeight = false;
            lstRecommendations.IntegralHeight = false;

            // Configure the event details label.
            lblEventDetails.AutoSize = false;
            lblEventDetails.TextAlign = ContentAlignment.TopLeft;
            lblEventDetails.Text =
                "Select an event to view its details.";

            // Remove any placeholder entries from the Designer.
            lstEvents.Items.Clear();
            lstRecommendations.Items.Clear();
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All Categories");

            foreach (string category in
                EventDataStore.Categories.OrderBy(c => c))
            {
                cmbCategory.Items.Add(category);
            }

            cmbCategory.SelectedIndex = 0;
        }

        private bool ContainsText(string source, string searchText)
        {
            return !string.IsNullOrEmpty(source) &&
                   !string.IsNullOrWhiteSpace(searchText) &&
                   source.IndexOf(
                       searchText,
                       StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void DisplayEvents()
        {
            if (isInitialising)
                return;

            string searchText = txtSearch.Text.Trim();

            string selectedCategory =
                cmbCategory.SelectedItem == null
                    ? "All Categories"
                    : cmbCategory.SelectedItem.ToString();

            DateTime fromDate = dtpFromDate.Value.Date;
            DateTime toDate = dtpToDate.Value.Date;

            lstEvents.Items.Clear();
            lstRecommendations.Items.Clear();

            if (fromDate > toDate)
            {
                lblEventDetails.Text =
                    "The start date cannot be after the end date.\n\n" +
                    "Please correct the date range.";

                return;
            }

            // Find events matching the search, category and date filters.
            List<LocalEvent> matchingEvents =
                EventDataStore.EventsById.Values
                    .Where(e =>
                        e.EventDate.Date >= fromDate &&
                        e.EventDate.Date <= toDate)
                    .Where(e =>
                        selectedCategory == "All Categories" ||
                        string.Equals(
                            e.Category,
                            selectedCategory,
                            StringComparison.OrdinalIgnoreCase))
                    .Where(e =>
                        string.IsNullOrWhiteSpace(searchText) ||
                        ContainsText(e.Title, searchText) ||
                        ContainsText(e.Description, searchText) ||
                        ContainsText(e.Location, searchText) ||
                        ContainsText(e.Category, searchText))
                    .OrderBy(e => e.EventDate)
                    .ThenBy(e => e.Title)
                    .ToList();

            foreach (LocalEvent localEvent in matchingEvents)
            {
                lstEvents.Items.Add(localEvent);
            }

            if (matchingEvents.Count == 0)
            {
                lblEventDetails.Text =
                    "No events match your search.\n\n" +
                    "Try a different keyword, category or date range.";
            }
            else
            {
                // Automatically display the first matching event.
                lstEvents.SelectedIndex = 0;
            }

            UpdateRecommendations(searchText, selectedCategory);
        }

        private void UpdateRecommendations(
            string searchText,
            string selectedCategory)
        {
            lstRecommendations.Items.Clear();

            // Only recommend events that have not yet taken place.
            List<LocalEvent> upcomingEvents =
                EventDataStore.EventsById.Values
                    .Where(e => e.EventDate.Date >= DateTime.Today)
                    .OrderBy(e => e.EventDate)
                    .ThenBy(e => e.Title)
                    .ToList();

            // Store IDs already displayed in the main event list.
            HashSet<int> displayedEventIds =
                new HashSet<int>(
                    lstEvents.Items
                        .Cast<object>()
                        .OfType<LocalEvent>()
                        .Select(e => e.EventId));

            string previousSearch =
                EventDataStore.SearchHistory.Count > 0
                    ? EventDataStore.SearchHistory.Peek()
                    : string.Empty;

            // Use the custom priority queue to rank recommendations.
            EventPriorityQueue priorityQueue =
                new EventPriorityQueue();

            foreach (LocalEvent localEvent in upcomingEvents)
            {
                int score = 0;

                // Strongest match: event title.
                if (ContainsText(localEvent.Title, searchText))
                    score += 100;

                // Category matches.
                if (ContainsText(localEvent.Category, searchText))
                    score += 80;

                // Description matches.
                if (ContainsText(localEvent.Description, searchText))
                    score += 60;

                // Location matches.
                if (ContainsText(localEvent.Location, searchText))
                    score += 50;

                // Boost events matching the selected category.
                if (selectedCategory != "All Categories" &&
                    string.Equals(
                        localEvent.Category,
                        selectedCategory,
                        StringComparison.OrdinalIgnoreCase))
                {
                    score += 40;
                }

                // Use the most recent search as an additional signal.
                if (!string.IsNullOrWhiteSpace(previousSearch))
                {
                    if (ContainsText(
                        localEvent.Title, previousSearch))
                    {
                        score += 30;
                    }

                    if (ContainsText(
                        localEvent.Category, previousSearch))
                    {
                        score += 20;
                    }

                    if (ContainsText(
                        localEvent.Description, previousSearch))
                    {
                        score += 10;
                    }

                    if (ContainsText(
                        localEvent.Location, previousSearch))
                    {
                        score += 10;
                    }
                }

                // Give unrelated upcoming events a fallback score.
                if (score == 0)
                    score = 5;

                // The priority queue processes smaller numbers first.
                // Invert the score so higher relevance comes first.
                int priority = 1000 - score;

                priorityQueue.Enqueue(localEvent, priority);
            }

            List<LocalEvent> rankedEvents =
                new List<LocalEvent>();

            while (priorityQueue.Count > 0)
            {
                LocalEvent nextEvent = priorityQueue.Dequeue();

                if (nextEvent != null)
                    rankedEvents.Add(nextEvent);
            }

            // Prefer recommendations that are not in the main list.
            List<LocalEvent> recommendations =
                rankedEvents
                    .Where(e =>
                        !displayedEventIds.Contains(e.EventId))
                    .Take(5)
                    .ToList();

            // If there are no alternatives, show the highest-ranked
            // upcoming events rather than leaving the list empty.
            if (recommendations.Count == 0)
            {
                recommendations = rankedEvents
                    .Take(5)
                    .ToList();
            }

            foreach (LocalEvent localEvent in recommendations)
            {
                lstRecommendations.Items.Add(localEvent);
            }
        }

        private void ShowEventDetails(LocalEvent selectedEvent)
        {
            if (selectedEvent == null)
                return;

            lblEventDetails.Text =
                selectedEvent.Title + "\n\n" +
                "Category: " + selectedEvent.Category + "\n\n" +
                "Date: " +
                selectedEvent.EventDate.ToString("dd MMMM yyyy") +
                "\n\n" +
                "Location: " + selectedEvent.Location + "\n\n" +
                "Description:\n" +
                selectedEvent.Description + "\n\n" +
                "Contact Information:\n" +
                selectedEvent.ContactInformation;
        }

        private void lstEvents_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            LocalEvent selectedEvent =
                lstEvents.SelectedItem as LocalEvent;

            ShowEventDetails(selectedEvent);
        }

        private void lstRecommendations_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            LocalEvent selectedEvent =
                lstRecommendations.SelectedItem as LocalEvent;

            if (selectedEvent != null)
            {
                ShowEventDetails(selectedEvent);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Store the search using the EventDataStore method.
            EventDataStore.RecordSearch(txtSearch.Text);

            DisplayEvents();
        }

        private void btnClearFilters_Click(
            object sender,
            EventArgs e)
        {
            isInitialising = true;

            txtSearch.Clear();

            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;

            dtpFromDate.Value = DateTime.Today;
            dtpToDate.Value = DateTime.Today.AddMonths(3);

            isInitialising = false;

            DisplayEvents();
        }

        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            // Update recommendations while the user types.
            if (!isInitialising)
            {
                UpdateRecommendations(
                    txtSearch.Text.Trim(),
                    cmbCategory.SelectedItem == null
                        ? "All Categories"
                        : cmbCategory.SelectedItem.ToString());
            }
        }

        private void cmbCategory_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (!isInitialising &&
                cmbCategory.SelectedIndex >= 0)
            {
                DisplayEvents();
            }
        }

        private void DateFilter_ValueChanged(
            object sender,
            EventArgs e)
        {
            if (!isInitialising)
            {
                DisplayEvents();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
