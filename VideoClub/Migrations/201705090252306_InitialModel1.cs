namespace VideoClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genders (Id, Name) values(1, 'Accion')");
            Sql("INSERT INTO Genders (Id, Name) VALUES (2, 'Thriller')");
            Sql("INSERT INTO Genders (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genders (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genders (Id, Name) VALUES (5, 'Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
