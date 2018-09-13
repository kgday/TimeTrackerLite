using LinqToDB;
using LinqToDB.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace TimeTrackerLite.Data
{
    public class ConnectionStringSettings : IConnectionStringSettings
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public bool IsGlobal => false;
    }

    public class DbConnectionSettings : ILinqToDBSettings
    {
        DBSettings _dbSettings;
        public DbConnectionSettings(DBSettings dbSettings)
        {
            _dbSettings = dbSettings;
        }

        public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => ProviderName.PostgreSQL;
        public string DefaultDataProvider => ProviderName.PostgreSQL;

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                yield return
                    new ConnectionStringSettings
                    {
                        Name = "AppData",
                        ProviderName = ProviderName.PostgreSQL,
                        ConnectionString = _dbSettings.ToPgsqlConnectionString()
                    };
            }
        }
    }
}
