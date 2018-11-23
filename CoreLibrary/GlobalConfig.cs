using System.Configuration;

namespace CoreLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection DataConnection { get; private set; }

        public static void InitializeConnection()
        {
            DataConnection = new SqlConnector();
        }

        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
