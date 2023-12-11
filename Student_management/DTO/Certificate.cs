using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management.DTO
{
    public class Certificate
    {
        public int Id { get; set; }
        public string CerID { get; set; }
        public Student Student { get; set; }
        public string NameOfCer { get; set; }
        public DateTime Date { get; set; }
    }
}
