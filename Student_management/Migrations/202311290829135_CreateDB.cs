namespace Student_management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Pwd = c.String(),
                        Role = c.String(),
                        Name = c.String(),
                        Phone = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LoginHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoginTime = c.DateTime(nullable: false),
                        Account_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.Certificates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CerID = c.String(),
                        NameOfCer = c.String(),
                        Date = c.DateTime(nullable: false),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentID = c.String(),
                        Fullname = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Department = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Certificates", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.LoginHistories", "Account_Id", "dbo.Accounts");
            DropIndex("dbo.Certificates", new[] { "Student_Id" });
            DropIndex("dbo.LoginHistories", new[] { "Account_Id" });
            DropTable("dbo.Students");
            DropTable("dbo.Certificates");
            DropTable("dbo.LoginHistories");
            DropTable("dbo.Accounts");
        }
    }
}
