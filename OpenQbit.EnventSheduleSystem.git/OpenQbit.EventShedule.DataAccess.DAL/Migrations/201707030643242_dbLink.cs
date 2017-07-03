namespace OpenQbit.EventShedule.DataAccess.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbLink : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        TelephoneNumber = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Systems",
                c => new
                    {
                        SystemsId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SystemsId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        ScheduleId = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        PrimaryReasourceId = c.Int(nullable: false),
                        ParentScheduleId = c.Int(nullable: false),
                        SystemsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ScheduleId)
                .ForeignKey("dbo.Systems", t => t.SystemsId, cascadeDelete: true)
                .Index(t => t.SystemsId);
            
            CreateTable(
                "dbo.ScheduleProductAllocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ScheduleId = c.Int(nullable: false),
                        ArrivalTime = c.DateTime(nullable: false),
                        DepatureTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schedules", t => t.ScheduleId, cascadeDelete: true)
                .Index(t => t.ScheduleId);
            
            CreateTable(
                "dbo.ScheduleReasourceAllocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ScheduleId = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schedules", t => t.ScheduleId, cascadeDelete: true)
                .Index(t => t.ScheduleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "SystemsId", "dbo.Systems");
            DropForeignKey("dbo.ScheduleReasourceAllocations", "ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.ScheduleProductAllocations", "ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.Systems", "CustomerId", "dbo.Customers");
            DropIndex("dbo.ScheduleReasourceAllocations", new[] { "ScheduleId" });
            DropIndex("dbo.ScheduleProductAllocations", new[] { "ScheduleId" });
            DropIndex("dbo.Schedules", new[] { "SystemsId" });
            DropIndex("dbo.Systems", new[] { "CustomerId" });
            DropTable("dbo.ScheduleReasourceAllocations");
            DropTable("dbo.ScheduleProductAllocations");
            DropTable("dbo.Schedules");
            DropTable("dbo.Systems");
            DropTable("dbo.Customers");
        }
    }
}
