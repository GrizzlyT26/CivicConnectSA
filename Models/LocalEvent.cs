
using System;

namespace CivicConnectSA.Models
{
    public class LocalEvent
    {
        public int EventId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Location { get; set; }

        public DateTime EventDate { get; set; }

        public string ContactInformation { get; set; }

        public LocalEvent()
        {
        }

        public override string ToString()
        {
            return Title + " - " + EventDate.ToString("dd/MM/yyyy");
        }
    }
}
