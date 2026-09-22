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
            Student newstud = new Student(name, speciality, group);
            students.Add(newstud);
            newstud.index = $"{students.Count}";
        }
        public void DeleteStudent(string indexx)
        {
            var x = students.Find(p => p.index == indexx);
            students.Remove(x);
        }
        public List<Student> ShowTable() 
        {
            //for (int i = 0; i < students.Count; i++)
            //{
            //    Console.WriteLine($"{students[i].Name} | Специальность: {students[i].Speciality} Группа: {students[i].Group}");
            //}
            return students;
        }
        public Dictionary<string, int> ShowGistogram()
        {
            var gistogram = students
                .GroupBy(s => s.Speciality)
                .ToDictionary(k => k.Key, c => c.Count());
            return gistogram;
        }
        public string CheckOnDurak(string proverim, CheckMode checkmode)
        {
            //proverim = proverim.Trim(); добавить в main, как и s = иван | char.ToUpper(s[0]) + s.Substring(1); s = Иван
            if (proverim == null || proverim.Length > 50 || proverim.Length < 2)
            {
                return "Некорректная длина слова!";
            }
            switch (checkmode)
            {
                case CheckMode.Letters:
                    foreach (char a in proverim)
                    {
                        if ((a < 'a' || a > 'z') && (a < 'A' || a > 'Z') && (a < 'А' || a > 'я') && a != 'Ё' && a != 'ё') 
                        {
                            return "В имени/названии содержатся специальные символы или цифры!";
                        }
                    }
                    return null;
                case CheckMode.SpecChars:
                    foreach (char a in proverim)
                    {
                        if ((a < 33 || a > 64) && (a < 'a' || a > 'z') && (a < 'A' || a > 'Z') && (a < 'А' || a > 'я') && a != 'Ё' && a != 'ё')
                        {
                            return "В имени/названии содержатся недопустимые символы!";
                        }
                    }
                    return null;
                default:
                    return "Неизвестный режим проверки!";
            }   
        }
    }
}
public enum CheckMode
{
    Letters,
    SpecChars
}