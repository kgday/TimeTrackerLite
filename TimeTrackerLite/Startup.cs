using FluentMigrator.Runner;
using LinqToDB.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TimeTrackerLite.Data;

namespace TimeTrackerLite
{
    public class Startup
    {
        public Startup(IHostingEnvironment env, IConfiguration configuration)
        {
            Configuration = configuration;
            DBSettings = new DBSettings();
            if (env.IsDevelopment())
                Configuration.GetSection("DBSettingsDev").Bind(DBSettings);
            else
                Configuration.GetSection("DBSettings").Bind(DBSettings);
        }

        public IConfiguration Configuration { get; }
        public DBSettings DBSettings { get; private set; }

        /// <summary>
        /// This is a framework methodthat gets called by the runtime. Use this method to add services to the container.
        /// 
        /// Additional to the project wizard added stuff, we are setting up the fluent migrator services which check the database version and migrate if necessary.  
        /// The services get called in the configure method
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            //Set up the fluent migrator for the dependency injector
            services.AddFluentMigratorCore()
            .ConfigureRunner(rb => rb
            .AddPostgres()
            // Set the connection string
            .WithGlobalConnectionString(DBSettings.ToPgsqlConnectionString())
            // Define the assembly containing the migrations
            .ScanIn(typeof(Startup).Assembly).For.Migrations());


            //<project wizard added>
            services.AddMvc();
            //<\project wizard added>
        }

        /// <summary>
        /// This is a framework method that gets called by the runtime. Use this method to configure the HTTP request pipeline.  
        /// 
        /// Additional to the project wizard added stuff, we configure the database and call fluentMigrator to check and perform any database migrations
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <param name="dbmigrator"></param>
        // This method 
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IMigrationRunner dbmigrator)
        {
            ConfigureDB(env);
            dbmigrator.MigrateUp();

            //<project wizard added>
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseMvc();
            //<\project wizard added>
        }

        private void ConfigureDB(IHostingEnvironment env)
        {
            DataConnection.DefaultSettings = new DbConnectionSettings(DBSettings);
        }
    }
}

