namespace _23210201041___Ali_Berk_Ertemür.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TableDistricts",
                c => new
                    {
                        DistrictId = c.Int(nullable: false, identity: true),
                        DisctrictName = c.String(),
                    })
                .PrimaryKey(t => t.DistrictId);
            
            CreateTable(
                "dbo.TableFamousPlaces",
                c => new
                    {
                        PlaceId = c.Int(nullable: false, identity: true),
                        PlaceName = c.String(),
                    })
                .PrimaryKey(t => t.PlaceId);
            
            CreateTable(
                "dbo.TablePopulations",
                c => new
                    {
                        PopulationId = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        WomenPopulation = c.Int(nullable: false),
                        ManPopulation = c.Int(nullable: false),
                        OverallPopulation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PopulationId);
            
            CreateTable(
                "dbo.TableRoles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.TableUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        RoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TableRoles", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.TableSliders",
                c => new
                    {
                        SliderId = c.Int(nullable: false, identity: true),
                        SliderLink = c.String(),
                    })
                .PrimaryKey(t => t.SliderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TableUsers", "RoleID", "dbo.TableRoles");
            DropIndex("dbo.TableUsers", new[] { "RoleID" });
            DropTable("dbo.TableSliders");
            DropTable("dbo.TableUsers");
            DropTable("dbo.TableRoles");
            DropTable("dbo.TablePopulations");
            DropTable("dbo.TableFamousPlaces");
            DropTable("dbo.TableDistricts");
        }
    }
}
