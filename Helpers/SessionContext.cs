
namespace CivicConnectSA.Helpers
{
    public static class SessionContext
    {
        public static string Username { get; set; }

        public static string UserRole { get; set; }

        public static bool IsAuthenticated
        {
            get
            {
                return !string.IsNullOrEmpty(Username)
                    && !string.IsNullOrEmpty(UserRole);
            }
        }

        public static void Logout()
        {
            Username = null;
            UserRole = null;
        }
    }
}
