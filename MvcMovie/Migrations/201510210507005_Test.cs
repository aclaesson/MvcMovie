namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Test", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Test");
        }
    }
}
