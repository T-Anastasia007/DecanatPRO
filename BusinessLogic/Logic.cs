using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{students[i].Name} | Специальность: {students[i].Speciality} Группа: {students[i].Group}");
            }
        }
        public void ShowGistogram()
        {
            var gistogram = students
                .GroupBy(x => x.Speciality)
                .Select(x => new
                {
                    Spec = x.Key,
                    Count = x.Count()
                });
            foreach (var g in gistogram)
            {
                Console.Write($"{g.Spec}: ");
                for (int i = 0;i < g.Count; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("");
            }
        }
        public void CheckOnDurak(string proverim)
        {

        }
    }
}