using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DecanatPRO
{
    public class EntityFramework : IRepository<Student>
    {
        private DataContext _context;
        public EntityFramework(DataContext context)
        {
            _context = context;
        }
        public void Create(Student obj)
        {
            _context.Set<Student>().Add(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Student> ReadAll()
        {
            return new List<Student>(_context.Set<Student>());
        }

        public Student ReadById(int id)
        {
            return _context.Students.Where(o => o.Id == id).FirstOrDefault();
        }

        //public void Update(Student obj)
        //{
        //    Student origin = _context.Students.Where(o => o.Id == obj.Id).FirstOrDefault();
        //    origin.Name = obj.Name;
        //    origin.Speciality = obj.Speciality;
        //    origin.Group = obj.Group;
        //    _context.SaveChanges();
        //}

        public void Delete(Student obj)
        {
            _context.Set<Student>().Remove(obj);
            _context.SaveChanges();
        }
    }
}
