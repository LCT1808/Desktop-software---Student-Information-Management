namespace Student_management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "Avatar", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "Avatar");
        }
    }
}
