using System;
namespace RezoraData
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public class ConnectionStrings
        {
            public string Rezora { get; set; }
        }
    }
}
