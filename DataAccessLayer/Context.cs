using DecanatPRO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DecanatPRO
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DataContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chunyai\OneDrive\Документы\GitHub\DecanatPRO\DataAccessLayer\Database1.mdf;Integrated Security=True")
        {}
    }
}
