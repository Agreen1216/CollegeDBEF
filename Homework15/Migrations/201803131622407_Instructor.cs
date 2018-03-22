namespace Homework15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Instructor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Instructor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Instructor");
        }
    }
}
