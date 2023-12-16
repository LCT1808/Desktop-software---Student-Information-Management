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
        public MyDBContext() : base("Data Source=DESKTOP-J1JFN5D\\MSSQLSERVER01;Initial Catalog= Student_Management;Trusted_Connection = True; TrustServerCertificate=True;User ID = lecamtu; Password=lecamtu") { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<LoginHistory> LoginHistories { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
    }
}
