namespace RandomPlay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreatedDateColumnInUserMatch : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserMatches", "CreatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserMatches", "CreatedDate");
        }
    }
}
