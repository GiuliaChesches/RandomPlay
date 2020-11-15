namespace RandomPlay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMatchTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ExpireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            Sql(string.Format("INSERT INTO Matches (Name, ExpireDate) VALUES ('Match 1', '{0}')", DateTime.UtcNow.AddMinutes(5)));
            Sql(string.Format("INSERT INTO Matches (Name, ExpireDate) VALUES ('Match 11', '{0}')", DateTime.UtcNow.AddMinutes(6)));
            Sql(string.Format("INSERT INTO Matches (Name, ExpireDate) VALUES ('Match 12', '{0}')", DateTime.UtcNow.AddMinutes(7)));
            Sql(string.Format("INSERT INTO Matches (Name, ExpireDate) VALUES ('Match 13', '{0}')", DateTime.UtcNow.AddMinutes(8)));
            Sql(string.Format("INSERT INTO Matches (Name, ExpireDate) VALUES ('Match 14', '{0}')", DateTime.UtcNow.AddMinutes(9)));
            Sql(string.Format("INSERT INTO Matches (Name, ExpireDate) VALUES ('Match 2', '{0}')", DateTime.UtcNow.AddMinutes(10)));
            Sql(string.Format("INSERT INTO Matches (Name, ExpireDate) VALUES ('Match 3', '{0}')", DateTime.UtcNow.AddMinutes(15)));
            Sql(string.Format("INSERT INTO Matches (Name, ExpireDate) VALUES ('Match 4', '{0}')", DateTime.UtcNow.AddMinutes(25)));
            Sql(string.Format("INSERT INTO Matches (Name, ExpireDate) VALUES ('Match 5', '{0}')", DateTime.UtcNow.AddMinutes(35)));
            Sql(string.Format("INSERT INTO Matches (Name, ExpireDate) VALUES ('Match 6', '{0}')", DateTime.UtcNow.AddMinutes(45)));
            Sql(string.Format("INSERT INTO Matches (Name, ExpireDate) VALUES ('Match 7', '{0}')", DateTime.UtcNow.AddMinutes(55)));
            Sql(string.Format("INSERT INTO Matches (Name, ExpireDate) VALUES ('Match 8', '{0}')", DateTime.UtcNow.AddMinutes(65)));
            Sql(string.Format("INSERT INTO Matches (Name, ExpireDate) VALUES ('Match 9', '{0}')", DateTime.UtcNow.AddMinutes(70)));
            Sql(string.Format("INSERT INTO Matches (Name, ExpireDate) VALUES ('Match 10', '{0}')", DateTime.UtcNow.AddMinutes(75)));
        }
        
        public override void Down()
        {
            DropTable("dbo.Matches");
        }
    }
}
