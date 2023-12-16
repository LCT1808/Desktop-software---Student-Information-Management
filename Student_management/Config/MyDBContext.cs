using Student_management.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management.Config
{
    public class MyDBContext: DbContext
    {
        public MyDBContext() : base("Data Source=sheep;Initial Catalog=Student_Management;Trusted_Connection=True;TrustServerCertificate=True") { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<LoginHistory> LoginHistories { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
    }
}
