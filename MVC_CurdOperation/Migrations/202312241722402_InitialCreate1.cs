namespace MVC_CurdOperation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "DateOfBirth", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "MobileNo", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Gender", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "position", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "DateOfHire", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Department", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Department", c => c.String());
            AlterColumn("dbo.Employees", "DateOfHire", c => c.String());
            AlterColumn("dbo.Employees", "position", c => c.String());
            AlterColumn("dbo.Employees", "Gender", c => c.String());
            AlterColumn("dbo.Employees", "MobileNo", c => c.String());
            AlterColumn("dbo.Employees", "Address", c => c.String());
            AlterColumn("dbo.Employees", "Email", c => c.String());
            AlterColumn("dbo.Employees", "DateOfBirth", c => c.String());
            AlterColumn("dbo.Employees", "Name", c => c.String());
        }
    }
}
