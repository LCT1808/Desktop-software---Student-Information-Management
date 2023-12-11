namespace Student_management.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Student_management.Config.MyDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Student_management.Config.MyDBContext context)
        {
            context.Accounts.AddOrUpdate(new DTO.Account() { Username = "admin", Name = "TuTienTuan", DateOfBirth = DateTime.Now,
                Phone = "0123456789", Pwd = "123456", Role = "admin", Status = true});
        }
    }
}
