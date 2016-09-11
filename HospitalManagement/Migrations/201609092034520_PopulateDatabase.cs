namespace HospitalManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genders (Sex) VALUES ('Male')");
            Sql("INSERT INTO Genders (Sex) VALUES ('Female')");
            Sql("INSERT INTO Religions (Name) VALUES ('Christianity')");
            Sql("INSERT INTO Religions (Name) VALUES ('Islamic')");
            Sql("INSERT INTO Religions (Name) VALUES ('Traditional')");
            Sql("INSERT INTO MaritalStatus (Status) VALUES ('Single')");
            Sql("INSERT INTO MaritalStatus (Status) VALUES ('Married')");
            Sql("INSERT INTO MaritalStatus (Status) VALUES ('Divorced')");
            Sql("INSERT INTO MaritalStatus (Status) VALUES ('Widowed')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genders WHERE Id IN (1, 2)");
            Sql("DELETE FROM Religions WHERE Id IN (1, 2, 3)");
            Sql("DELETE FROM MaritalStatus WHERE Id IN (1, 2, 3, 4)");
        }
    }
}
