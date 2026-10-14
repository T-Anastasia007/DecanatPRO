using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Главная точка входа для приложения.
/// </summary>
namespace DecanatPRO
{
    public class Dapper : IRepository<Student>
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chunyai\OneDrive\Документы\GitHub\DecanatPRO\DataAccessLayer\Database1.mdf;Integrated Security=True";
        //поменять при работе
        public void Create(Student student)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO Students (Name, Speciality, [Group]) VALUES (@Name, @Speciality, @Group)";
                db.Execute(sqlQuery, student);
                
            }
        }
        public void Update(Student student) //по желанию
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "UPDATE Students SET Name = @Name, Speciality = @Speciality, [Group] = @Group WHERE Id = @Id";
                db.Execute(sqlQuery, student);
            }
        }
        public IEnumerable<Student> ReadAll()
        {
            List<Student> students;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                students = db.Query<Student>("SELECT * FROM Students").ToList();
            }
            return students;
        }
        public Student ReadById(int id)
        {
            Student student;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                student = db.Query<Student>("SELECT * FROM Students WHERE Id = @id", new { id }).FirstOrDefault();
            }
            return student;
        }
        public void Delete(Student student)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM Students WHERE Id = @Id";
                db.Execute(sqlQuery, student);
            }
        }
    }
}
