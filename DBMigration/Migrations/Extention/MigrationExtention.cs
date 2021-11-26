using FluentMigrator.Runner;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBMigration.Migration.Extention
{
    public static class MigrationExtention
    {
        public static IApplicationBuilder Migrate(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            var runner = scope.ServiceProvider.GetService<IMigrationRunner>();
            runner.ListMigrations();
            //runner.MigrateUp(202110090925);
            //runner.MigrateUp(202109070239);
            //runner.MigrateUp(202110090857);
            //runner.MigrateUp(202110090914);
            //runner.MigrateUp(202111261821);
            return app;
        }
    }
}
