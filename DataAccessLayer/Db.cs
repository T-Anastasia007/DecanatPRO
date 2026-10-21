using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

//namespace DecanatPRO
//{
//    public static class Db
//    {
//        private const string Server = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True";
//        public const string ConnectionString = Server + ";Initial Catalog=DecanatDb";

//        public static void EnsureCreated()
//        {
//            using (var master = new SqlConnection(Server + ";Initial Catalog=master"))
//            {
//                master.Execute("IF DB_ID('DecanatDb') IS NULL CREATE DATABASE DecanatDb");
//            }
//            using (var db = new SqlConnection(ConnectionString))
//            {
//                db.Execute(@"IF OBJECT_ID('Students') IS NULL
//                    CREATE TABLE Students (
//                        Id INT IDENTITY(1,1) PRIMARY KEY,
//                        Name NVARCHAR(100) NOT NULL,
//                        Speciality NVARCHAR(100) NOT NULL,
//                        [Group] NVARCHAR(50) NOT NULL)");
//            }
//        }
//    }
//}
