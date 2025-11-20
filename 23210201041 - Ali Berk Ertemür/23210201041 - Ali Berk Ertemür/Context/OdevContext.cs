using _23210201041___Ali_Berk_Ertemür.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.ClientServices;


namespace _23210201041___Ali_Berk_Ertemür.Context
{
    
        public class OdevContext : DbContext
        {
            public DbSet<TableUser> Users { get; set; }

            public DbSet<TableRoles> Roles { get; set; }

            public DbSet<TableDistrict> Districts { get; set; }

            public DbSet<TablePopulation> Populations { get; set; }

            public DbSet<TableSlider> Sliders { get; set; }

            public DbSet<TableFamousPlace> FamousPlaces { get; set; }

            //public OdevContext() : base("name=OdevContext3")
            //{
            //    Debug.WriteLine("OdevContext constructor çalıştı.");

            //    Database.SetInitializer<OdevContext>(new OdevInitializer());

            //    if (!Database.Exists())
            //    {
            //        Database.Initialize(true);
            //    }
            //}

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

                modelBuilder.Entity<TableUser>().HasRequired(x => x.Role).WithMany(r => r.Users)
                    .HasForeignKey(x => x.RoleID).WillCascadeOnDelete(true);
            }




        }
    }
