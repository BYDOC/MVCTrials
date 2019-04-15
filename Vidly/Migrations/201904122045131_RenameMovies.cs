namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Update Movies set Name='Hellboy' where Id=2 ");
            Sql("Update Movies set Name='Wall-E' where Id=3 ");
        }
        
        public override void Down()
        {
        }
    }
}
