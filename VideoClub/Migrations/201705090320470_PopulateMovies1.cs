namespace VideoClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies1 : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Movies(Name,GenderId, DateAdded, ReleaseDate,NumberInStock)values( 'Rapido y Furioso', 1, 12-12-2016, 29-03-2017, 13)");
            Sql("insert into Movies(Name,GenderId, DateAdded, ReleaseDate,NumberInStock)values( 'Masacre en Texas', 2, 9-12-2017, 29-03-2018, 1)");
            Sql("insert into Movies(Name,GenderId, DateAdded, ReleaseDate,NumberInStock)values( 'Sherk', 3, 25-12-2014, 29-03-2019, 99)");
            Sql("insert into Movies(Name,GenderId, DateAdded, ReleaseDate,NumberInStock)values( 'Sombras de Grace', 4, 01-12-2013, 29-03-2015, 7)");
            Sql("insert into Movies(Name,GenderId, DateAdded, ReleaseDate,NumberInStock)values( 'American Pie', 5, 08-12-2012, 29-03-2019, 6)");
        }
        
        public override void Down()
        {
        }
    }
}
