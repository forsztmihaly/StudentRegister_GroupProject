using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegister.Models
{
    public class StudentsSearch
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string Course { get; set; }
        public List<Student> Students { get; set; }

    }
}
