using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{ 
    public interface IModel
    {
        void Add(string name, string group, string speciality);
        bool Delete(int ID);
        List<string[]> ShowTable();
    }
}
