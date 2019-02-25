namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembership2 : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes set Name = 'Pay As You Go' where Id = 1 ");
        }
        
        public override void Down()
        {
        }
    }
}
