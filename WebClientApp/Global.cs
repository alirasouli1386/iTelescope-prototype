using System;
namespace WebClientApp
{
    public static class Global
    {
        public static bool Authenticated { get; set; }
        public static string Username { get; set; }

        static Global()
        {
            Authenticated = false;
            Username = "";
        }
    }
}
