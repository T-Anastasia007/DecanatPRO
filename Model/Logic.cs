using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Interfaces;
namespace Model
{
    public class Businesslogic : IModel
    {
        private List<Student> students = new List<Student>();
        private int ID;
        public bool Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Add(string name, string group, string speciality)
        {
            var sameGroup = students.FirstOrDefault(s => s.Group == group);
            if (sameGroup != null)
            {
                speciality = sameGroup.Speciality;
            }
            students.Add(new Student { Name = name, Group = group, Speciality = speciality, Id = ID });
            ID++;
        }
        public List<string[]> ShowTable()
        {
            var table = new List<string[]>();
            foreach (var s in students)
            {
                table.Add(new string[] { s.Id.ToString(), s.Name, s.Speciality, s.Group });
            }
            return table;
        }
        public void Update()
        {

        }
    }
}
