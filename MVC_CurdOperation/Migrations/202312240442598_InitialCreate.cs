namespace MVC_CurdOperation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateOfBirth = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        MobileNo = c.String(),
                        Gender = c.String(),
                        Age = c.Int(nullable: false),
                        position = c.String(),
                        DateOfHire = c.String(),
                        Department = c.String(),
                        Salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
