using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Model
{
    public class Student : IDomainObject
    {
        public string Name;
        public string Group;
        public string Speciality;
        public int Id { get; set; }
    }
}
