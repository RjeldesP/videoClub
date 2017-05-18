namespace VideoClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNameOfMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("update MemberShipTypes set Name = 'pay as you go' where Id = 1 ");
            Sql("update MemberShipTypes set Name = 'Monthly' where Id = 2 ");
            Sql("update MemberShipTypes set Name = 'Quartely' where Id = 3 ");
            Sql("update MemberShipTypes set Name = 'Annual' where Id = 4 ");
        }
        
        public override void Down()
        {
        }
    }
}
