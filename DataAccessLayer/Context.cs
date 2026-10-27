using DecanatPRO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DecanatPRO
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DataContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\labs\DecanatPRO\DataAccessLayer\Database2.mdf;Integrated Security=True")
        {
            Database.SetInitializer<DataContext>(null);
        }
    }
}
