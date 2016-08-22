﻿using System.Data.Entity.Migrations;
using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;
using Owin;

namespace Chapter3
{
    public partial class Startup
    {
        public static void ConfigureMobileApp(IAppBuilder app)
        {
            var httpConfig = new HttpConfiguration();
            var mobileConfig = new MobileAppConfiguration();

            mobileConfig
                .AddTablesWithEntityFramework()
                .ApplyTo(httpConfig);

            // Map Routes via attribute
            httpConfig.MapHttpAttributeRoutes();

            // Automatic Code First Migrations
            //var migrator = new DbMigrator(new Migrations.Configuration());
            //migrator.Update();

            app.UseWebApi(httpConfig);
        }
    }
}
