6namespace EmlakOfisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Property", "State", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Property", "State");
        }
    }
}
