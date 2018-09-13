using Npgsql;

namespace TimeTrackerLite.Data
{
    public class DBSettings
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public int? Port { get; set; }
        public string DBUserName { get; set; }
        public string DBPassword { get; set; }

        public static DBSettings FromConnectionsString(string connString)
        {
            var builder = new NpgsqlConnectionStringBuilder();
            return new DBSettings()
            {
                Server = builder.Host,
                Database = builder.Database,
                Port = builder.Port,
                DBUserName = builder.Username,
                DBPassword = builder.Password
            };
        }

        public string ToDBConnectionString()
        {
            var builder = new NpgsqlConnectionStringBuilder
            {
                Username = DBUserName,
                Host = Server,
                Password = DBPassword,
                Database = Database,
                CommandTimeout = 200,
                ConnectionIdleLifetime = 30,
                Pooling = true,
                KeepAlive = 30,
                TcpKeepAlive = true
            };
            if (Port != null)
                builder.Port = Port.Value;

            return builder.ToString();
        }
    }


}
