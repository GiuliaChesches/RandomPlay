namespace RandomPlay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUserMatchesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserMatches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        MatchId = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Matches", t => t.MatchId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.MatchId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserMatches", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserMatches", "MatchId", "dbo.Matches");
            DropIndex("dbo.UserMatches", new[] { "MatchId" });
            DropIndex("dbo.UserMatches", new[] { "UserId" });
            DropTable("dbo.UserMatches");
        }
    }
}
