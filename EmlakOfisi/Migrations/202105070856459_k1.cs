namespace EmlakOfisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "CompanyName", c => c.String(nullable: false, maxLength: 75));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "CompanyName", c => c.String(maxLength: 75));
        }
    }
}
