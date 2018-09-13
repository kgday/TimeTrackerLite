using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace TimeTrackerLite.Data
{
    public static class DBSettingsConnectionStringPgsql
    {
        public static DBSettings ToPgsqlDBSettings(this string connString)
        {
            var builder = new NpgsqlConnectionStringBuilder(connString);
            return new DBSettings()
            {
                Server = builder.Host,
                Database = builder.Database,
                Port = builder.Port,
                DBUserName = builder.Username,
                DBPassword = builder.Password
            };
        }

        public static string ToPgsqlConnectionString(this DBSettings dbSettings)
        {
            var builder = new NpgsqlConnectionStringBuilder
            {
                Username = dbSettings.DBUserName,
                Host = dbSettings.Server,
                Password = dbSettings.DBPassword,
                Database = dbSettings.Database,
                CommandTimeout = 200,
                ConnectionIdleLifetime = 30,
                Pooling = true,
                KeepAlive = 30,
                TcpKeepAlive = true
            };
            if (dbSettings.Port != null)
                builder.Port = dbSettings.Port.Value;

            return builder.ToString();
        }
    }
}
