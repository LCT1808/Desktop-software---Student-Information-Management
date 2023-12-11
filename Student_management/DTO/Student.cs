using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management.DTO
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentID { get; set; }
        public string Fullname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public ICollection<Certificate> Certificates { get; set; }
    }
}
