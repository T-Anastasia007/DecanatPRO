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
        public Dictionary<string, string> SpecGroup { get; set; } = new Dictionary<string, string>();
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
        public List<string> ShowTable()
        {
            var table = new List<string>();
            foreach (var s in students)
            {
                table.Add($"{s.index}. {s.Name} | {s.Group} | {s.Speciality}");
            }
            return table;
        }
        public Dictionary<string, int> ShowHistogram()
        {
            var gistogram = students
                .GroupBy(s => s.Speciality)
                .ToDictionary(k => k.Key, c => c.Count());
            return gistogram;
        }
        public string CheckOnDurak(string proverim, CheckMode checkmode)
        {
            //proverim = proverim.Trim(); добавить в main, как и s = иван | char.ToUpper(s[0]) + s.Substring(1); s = Иван

            //text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); -убирает пробелы

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
                            return "Неверный ввод: в ФИО используйте только буквы и (-), если нужно";
                        }
                    }
                    return null;
                case CheckMode.SpecChars:
                    foreach (char a in proverim)
                    {
                        if ((a < 33 || a > 64) && (a < 'a' || a > 'z') && (a < 'A' || a > 'Z') && (a < 'А' || a > 'я') && a != 'Ё' && a != 'ё' && a != ' ')
                        {
                            return "Неверный ввод: в названии группы содержатся недопустимые символы!";
                        }
                    }
                    return null;
                case CheckMode.Specalnst:
                    foreach (char a in proverim)
                    {
                        if ((a < 'a' || a > 'z') && (a < 'A' || a > 'Z') && (a < 'А' || a > 'я') && a != 'Ё' && a != 'ё' && a != '-' && a != ' ')
                        {
                            return "Неверный ввод: используйте буквы, а также (-), если нужно";
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