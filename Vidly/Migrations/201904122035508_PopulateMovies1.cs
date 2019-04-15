namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies1 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");

            Sql("INSERT INTO Movies (Id, Name, IsSubscribedToNewsletter, GenreId, NumberInStock) VALUES (1,'Hangover',1,1,44)");

            Sql("INSERT INTO Movies (Id, Name, IsSubscribedToNewsletter, GenreId, NumberInStock) VALUES (2,'Hangover',1,3,23)");

            Sql("INSERT INTO Movies (Id, Name, IsSubscribedToNewsletter, GenreId, NumberInStock) VALUES (3,'Hangover',1,4,12)");

            Sql("SET IDENTITY_INSERT Movies OFF");

        }
        
        public override void Down()
        {
        }
    }
}
