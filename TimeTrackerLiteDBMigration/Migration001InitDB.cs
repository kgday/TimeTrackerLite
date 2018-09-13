using System;
using FluentMigrator;
using TimeTrackerLite.Models;
using TimeTrackerLite.Utils;

namespace TimeTrackerLite.DBMigration
{
    public class Migration001IinitDB : AutoReversingMigration
    {
        public override void Up()
        {
            CreateClientTable();
        }

        private void CreateClientTable()
        {
            Create
                .Table("Client")
                .WithColumn(nameof(Client.Id).ToDB()).AsInt64().PrimaryKey().NotNullable().Identity()
                .WithColumn(nameof(Client.Name).ToDB()).AsString(50).NotNullable()
                .WithColumn(nameof(Client.PhoneNo).ToDB()).AsString(25).NotNullable()
                .WithColumn(nameof(Client.IsActive).ToDB()).AsBoolean();
        }
    }
}
