using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using static System.Net.Mime.MediaTypeNames;
namespace DecanatPRO
{
    public class Logic
    {
        public new Dictionary<string, string> SpecGroup;
        private int _id = 1;
        public List<Student> students { get; set; } = new List<Student>();

        public void AddStudent(string name, string group, string speciality)
        {

            if (!SpecGroup.ContainsKey(group))
            {
                SpecGroup.Add(group, speciality);
            }
            if (SpecGroup.TryGetValue(group, out string value))
            {
                if (value != speciality)
                {
                    speciality = value;
                }
            }
            var newstud = new Student(name, speciality, group);
            students.Add(newstud);
            newstud.index = _id;
            _id++;

            //bool TryGetValue
        }
        public void DeleteStudent(int indexx)
        {
            students.RemoveAt(indexx);
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
            
            //text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            if (proverim == null || proverim.Length > 50 || proverim.Length < 2)
            {
                return "Некорректная длина слова!";
            }
            switch (checkmode)
            {
                case CheckMode.Letters:
                    foreach (char a in proverim)
                    {
                        if ((a < 'a' || a > 'z') && (a < 'A' || a > 'Z') && (a < 'А' || a > 'я') && a != 'Ё' && a != 'ё' && a != '-')
                        {
                            return "В ФИО/названии содержатся специальные символы или цифры!";
                        }
                    }
                    return null;
                case CheckMode.SpecChars:
                    foreach (char a in proverim)
                    {
                        if ((a < 33 || a > 64) && (a < 'a' || a > 'z') && (a < 'A' || a > 'Z') && (a < 'А' || a > 'я') && a != 'Ё' && a != 'ё')
                        {
                            return "В ФИО/названии содержатся недопустимые символы!";
                        }
                    }
                    return null;
                case CheckMode.Specalnst:
                    foreach (char a in proverim)
                    {
                        if ((a < 'a' || a > 'z') && (a < 'A' || a > 'Z') && (a < 'А' || a > 'я') && a != 'Ё' && a != 'ё' && a != '-' && a != ' ')
                        {
                            return "В ФИО/названии содержатся недопустимые символы!";
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
    SpecChars,
    Specalnst
}