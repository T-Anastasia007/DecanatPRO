using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IView
    {
        void ButtonRemove(object sender, EventArgs e);
        void ButtonAdd(object sender, EventArgs e);
        void Refresh(object sender, EventArgs e);
    }
}
