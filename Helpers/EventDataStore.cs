
using System;
using System.Collections;
using System.Collections.Generic;
using CivicConnectSA.Models;

namespace CivicConnectSA.Helpers
{
    public static class EventDataStore
    {
        // Dictionary: stores events by their unique IDs.
        public static Dictionary<int, LocalEvent> EventsById
            = new Dictionary<int, LocalEvent>();

        // Hashtable: provides lookup by event title.
        public static Hashtable EventsByTitle
            = new Hashtable(StringComparer.OrdinalIgnoreCase);

        // SortedDictionary: organises events by date.
        // Queue: stores events occurring on the same date.
        public static SortedDictionary<DateTime, Queue<LocalEvent>>
            EventsByDate
            = new SortedDictionary<DateTime, Queue<LocalEvent>>();

        // HashSet: stores unique event categories.
        public static HashSet<string> Categories
            = new HashSet<string>(
                StringComparer.OrdinalIgnoreCase);

        // Stack: stores recent search terms.
        public static Stack<string> SearchHistory
            = new Stack<string>();

        private static bool isInitialised = false;

        public static void Initialise()
        {
            if (isInitialised)
                return;

            AddEvent(
                1,
                "Community Clean-Up",
                "Help clean public spaces and improve the local environment.",
                "Environment",
                "Tembisa Community Hall",
                new DateTime(2026, 11, 7),
                "Contact your local ward office");

            AddEvent(
                2,
                "Youth Career Workshop",
                "A workshop offering career guidance and job-readiness advice.",
                "Education",
                "Midrand Community Centre",
                new DateTime(2026, 11, 14),
                "Contact your local ward office");

            AddEvent(
                3,
                "Community Health Awareness Day",
                "Learn about healthy living and available community services.",
                "Health",
                "Ivory Park Community Hall",
                new DateTime(2026, 11, 21),
                "Contact your local ward office");

            AddEvent(
                4,
                "Small Business Information Session",
                "Information for residents interested in starting a small business.",
                "Business",
                "Tembisa Civic Centre",
                new DateTime(2026, 12, 5),
                "Contact your local ward office");

            isInitialised = true;
        }

        private static void AddEvent(
            int id,
            string title,
            string description,
            string category,
            string location,
            DateTime eventDate,
            string contactInformation)
        {
            LocalEvent localEvent = new LocalEvent
            {
                EventId = id,
                Title = title,
                Description = description,
                Category = category,
                Location = location,
                EventDate = eventDate,
                ContactInformation = contactInformation
            };

            // Store by ID.
            EventsById.Add(id, localEvent);

            // Store by title for fast title lookup.
            EventsByTitle[title] = localEvent;

            // Store unique categories.
            Categories.Add(category);

            // Group events by date and enqueue each event.
            DateTime dateKey = eventDate.Date;

            if (!EventsByDate.ContainsKey(dateKey))
            {
                EventsByDate.Add(
                    dateKey,
                    new Queue<LocalEvent>());
            }

            EventsByDate[dateKey].Enqueue(localEvent);
        }

        // Find an event by its title using the Hashtable.
        public static LocalEvent FindByTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                return null;

            return EventsByTitle[title.Trim()] as LocalEvent;
        }

        // Record searches without consecutive duplicates.
        public static void RecordSearch(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return;

            searchText = searchText.Trim();

            if (SearchHistory.Count == 0 ||
                !SearchHistory.Peek().Equals(
                    searchText,
                    StringComparison.OrdinalIgnoreCase))
            {
                SearchHistory.Push(searchText);
            }
        }
    }
}
