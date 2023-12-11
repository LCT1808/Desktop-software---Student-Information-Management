using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management.DTO
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Pwd { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public byte[] Avatar { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Status { get; set; }
        public ICollection<LoginHistory> LoginHistories { get; set; }
    }
}
