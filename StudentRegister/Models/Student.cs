using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegister.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string Course { get; set; }

        public Student()
        {
        }

        public Student(string sor)
        {
            string[] tomb = sor.Split(";");
            Name = tomb[0];
            Dob = Convert.ToDateTime(tomb[1]);
            //Dob = Convert.ToDateTime(tomb[1]).ToShortDateString(); ;
            Email = tomb[2];
            Gender = tomb[3];
            Status = tomb[4];
            Course = tomb[5];
        }
    }
}
