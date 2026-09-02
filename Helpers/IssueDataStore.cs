using System.Collections.Generic;
using CivicConnectSA.Models;

namespace CivicConnectSA.Helpers
{
    public static class IssueDataStore
    {
        public static List<Issue> ReportedIssues { get; } =
            new List<Issue>();
    }
}