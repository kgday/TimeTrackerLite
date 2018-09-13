using LinqToDB.Mapping;
using TimeTrackerLite.Models;
using TimeTrackerLite.Utils;

namespace TimeTrackerLite.Data
{
    public static class MappingLinq2Db
    {
        static MappingSchema _schema = null;

        public static MappingSchema Do()
        {
            if(_schema == null)
            {
                _schema = MappingSchema.Default;
                var mapper = _schema.GetFluentMappingBuilder();

                mapper
                    .Entity<Client>()
                    .HasTableName(nameof(Client).ToDB())
                    .Property(x => x.Id).HasColumnName(nameof(Client.Id).ToDB()).IsIdentity().IsPrimaryKey()
                    .Property(x => x.Name).HasColumnName(nameof(Client.Name).ToDB())
                    .Property(x => x.PhoneNo).HasColumnName(nameof(Client.PhoneNo).ToDB())
                    .Property(x => x.IsActive).HasColumnName(nameof(Client.IsActive).ToDB());

            }
            return _schema;
        }
        
    }
}
