namespace HospitalManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegistrationModelModified002 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registrations", "RelativeAddress", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Registrations", "RelativeAddress");
        }
    }
}
