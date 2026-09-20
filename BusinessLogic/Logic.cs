using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DecanatPRO
{
    public class Logic
    {
        public List<Student> students { get; set; } = new List<Student>();

        public void AddStudent(string name, string speciality, string group)
        {   

            students.Add(new Student(name, speciality, group));
            

        }
        public void DeleteStudent(int index)
        {
            students.RemoveAt(index);      
        }
        public void ShowTable() 
        {

        }
        public void ShowGistogram()
        {

        }
    }
}