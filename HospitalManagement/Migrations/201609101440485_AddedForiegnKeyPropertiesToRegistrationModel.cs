namespace HospitalManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForiegnKeyPropertiesToRegistrationModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Registrations", "Gender_Id", "dbo.Genders");
            DropForeignKey("dbo.Registrations", "MaritalStatus_Id", "dbo.MaritalStatus");
            DropForeignKey("dbo.Registrations", "Religion_Id", "dbo.Religions");
            DropIndex("dbo.Registrations", new[] { "Gender_Id" });
            DropIndex("dbo.Registrations", new[] { "MaritalStatus_Id" });
            DropIndex("dbo.Registrations", new[] { "Religion_Id" });
            RenameColumn(table: "dbo.Registrations", name: "Gender_Id", newName: "GenderId");
            RenameColumn(table: "dbo.Registrations", name: "MaritalStatus_Id", newName: "MaritalStatusId");
            RenameColumn(table: "dbo.Registrations", name: "Religion_Id", newName: "ReligionId");
            AlterColumn("dbo.Registrations", "GenderId", c => c.Int(nullable: false));
            AlterColumn("dbo.Registrations", "MaritalStatusId", c => c.Int(nullable: false));
            AlterColumn("dbo.Registrations", "ReligionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Registrations", "GenderId");
            CreateIndex("dbo.Registrations", "MaritalStatusId");
            CreateIndex("dbo.Registrations", "ReligionId");
            AddForeignKey("dbo.Registrations", "GenderId", "dbo.Genders", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Registrations", "MaritalStatusId", "dbo.MaritalStatus", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Registrations", "ReligionId", "dbo.Religions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Registrations", "ReligionId", "dbo.Religions");
            DropForeignKey("dbo.Registrations", "MaritalStatusId", "dbo.MaritalStatus");
            DropForeignKey("dbo.Registrations", "GenderId", "dbo.Genders");
            DropIndex("dbo.Registrations", new[] { "ReligionId" });
            DropIndex("dbo.Registrations", new[] { "MaritalStatusId" });
            DropIndex("dbo.Registrations", new[] { "GenderId" });
            AlterColumn("dbo.Registrations", "ReligionId", c => c.Int());
            AlterColumn("dbo.Registrations", "MaritalStatusId", c => c.Int());
            AlterColumn("dbo.Registrations", "GenderId", c => c.Int());
            RenameColumn(table: "dbo.Registrations", name: "ReligionId", newName: "Religion_Id");
            RenameColumn(table: "dbo.Registrations", name: "MaritalStatusId", newName: "MaritalStatus_Id");
            RenameColumn(table: "dbo.Registrations", name: "GenderId", newName: "Gender_Id");
            CreateIndex("dbo.Registrations", "Religion_Id");
            CreateIndex("dbo.Registrations", "MaritalStatus_Id");
            CreateIndex("dbo.Registrations", "Gender_Id");
            AddForeignKey("dbo.Registrations", "Religion_Id", "dbo.Religions", "Id");
            AddForeignKey("dbo.Registrations", "MaritalStatus_Id", "dbo.MaritalStatus", "Id");
            AddForeignKey("dbo.Registrations", "Gender_Id", "dbo.Genders", "Id");
        }
    }
}
