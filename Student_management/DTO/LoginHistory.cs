using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management.DTO
{
    public class LoginHistory
    {
        public int Id { get; set; }
        public Account Account { get; set; }
        public DateTime LoginTime { get; set; }
    }
}
