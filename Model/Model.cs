using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecanatPRO
{
    public class Student
    {
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }
        public int indexx;
        public Student(string name, string speciality, string group)
        {
            Name = name;    
            Speciality = speciality;
            Group = group;
        }
    }
}
