namespace HospitalManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Modified : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Registrations", "Telephone", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Registrations", "RelativePhone", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Registrations", "HealthInsuranceSchemeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Registrations", "HealthInsuranceSchemeId", c => c.Long(nullable: false));
            AlterColumn("dbo.Registrations", "RelativePhone", c => c.Long(nullable: false));
            AlterColumn("dbo.Registrations", "Telephone", c => c.Long(nullable: false));
        }
    }
}
