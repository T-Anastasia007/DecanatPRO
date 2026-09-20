using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public bool CheckOnDurak(string proverim, CheckMode cheсkmode)
        {
            // proverim = proverim.Trim(); добавить в main, как и s = иван | char.ToUpper(s[0]) + s.Substring(1); s = Иван
            if (proverim == null || proverim.Length > 50 || proverim.Length < 2 )
            {
                Console.WriteLine("Некорректная длина слова!");
                return false;
            }
            
            switch (cheсkmode)
            {
                case CheckMode.Letters:
                    foreach (char a in proverim)
                    {
                        if ((a < 'a' || a > 'z') && (a < 'A' || a > 'Z') && (a < 'А' || a > 'я') && a != 'Ё' && a != 'ё') // подумать над англ буквами
                        {
                            Console.WriteLine("В имени/названии содержатся специальные символы, цифры или пробел!");
                            return false;
                        }
                    }
                    return true;
                case CheckMode.SpecChars:
                    foreach (char a in proverim)
                    {
                        if ((a < 33 || a > 90) && (a < 97 || a > 122) && (a < 'А' || a > 'я') && a != 'Ё' && a != 'ё')
                        {
                            Console.WriteLine("В имени/названии содержатся недопустимые символы!");
                            return false;
                        }
                    }
                    return true;
                default:
                    Console.WriteLine("Ошибка в проверке, попробуйте еще раз");
                    return false;
            }   
        }
    }
}
public enum CheckMode
{
    Letters,
    SpecChars
}