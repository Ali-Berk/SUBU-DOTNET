namespace _23210201041___Ali_Berk_Ertemür.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_23210201041___Ali_Berk_Ertemür.Context.OdevContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "_23210201041___Ali_Berk_Ertemür.Context.OdevContext";
        }

        protected override void Seed(_23210201041___Ali_Berk_Ertemür.Context.OdevContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
