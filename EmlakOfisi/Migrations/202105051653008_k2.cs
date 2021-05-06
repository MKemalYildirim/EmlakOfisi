namespace EmlakOfisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adress",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Country = c.String(maxLength: 50),
                        City = c.String(maxLength: 50),
                        County = c.String(maxLength: 50),
                        FullArdress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Agent",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                        CompanyName = c.String(maxLength: 75),
                        UserName = c.String(maxLength: 25),
                        Password = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adress", t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.Id)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Property",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        AgentId = c.String(maxLength: 128),
                        Type = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        RoomRage = c.Int(nullable: false),
                        BedroomRange = c.Int(nullable: false),
                        BathroomRange = c.Int(nullable: false),
                        HomeAge = c.Int(nullable: false),
                        HomeSize = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adress", t => t.Id)
                .ForeignKey("dbo.Agent", t => t.AgentId)
                .Index(t => t.Id)
                .Index(t => t.AgentId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 25),
                        Password = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Agent", "UserId", "dbo.User");
            DropForeignKey("dbo.Property", "AgentId", "dbo.Agent");
            DropForeignKey("dbo.Property", "Id", "dbo.Adress");
            DropForeignKey("dbo.Agent", "Id", "dbo.Adress");
            DropIndex("dbo.Property", new[] { "AgentId" });
            DropIndex("dbo.Property", new[] { "Id" });
            DropIndex("dbo.Agent", new[] { "UserId" });
            DropIndex("dbo.Agent", new[] { "Id" });
            DropTable("dbo.User");
            DropTable("dbo.Property");
            DropTable("dbo.Agent");
            DropTable("dbo.Adress");
        }
    }
}
