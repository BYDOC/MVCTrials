namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Movies (Name,IsSubscribedToNewsletter,Genre,NumberInStock)  VALUES('Hellboy',1,'Action',50)");
        }
        
        public override void Down()
        {
        }
    }
}
