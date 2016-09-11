namespace HospitalManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegistrationModelModified001 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Registrations", "RegistrationNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "FacultyNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "HealthInsuranceSchemeId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Registrations", "HealthInsuranceSchemeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Registrations", "FacultyNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Registrations", "RegistrationNumber", c => c.Int(nullable: false));
        }
    }
}
