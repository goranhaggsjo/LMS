namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Teacher");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Teacher", c => c.Boolean(nullable: false));
        }
    }
}
