using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using static System.Net.Mime.MediaTypeNames;
using Model;

namespace DecanatPRO
{
    /// <summary>
    /// Для выбора БД
    /// </summary>
    public enum TypeofDB
    {
        Dapper,
        EF
    }
    public class Logic
    {
        private IRepository<Student> repository;
        /// <summary>
        /// Инициализация логики
        /// </summary>
        public Logic(TypeofDB type)
        {
            switch (type)
            {
                case TypeofDB.Dapper:
                    repository = new Dapper();
                    break;
                case TypeofDB.EF:
                    repository = new EntityFramework(new DataContext());
                    break;
            }
            if (!repository.ReadAll().Any())
            {
                AddStudent("Иванов Иван Иванович", "ГФ21-1", "Прикладная информатика");
                AddStudent("Петров Пётр Петрович", "ГФ25-2", "Прикладная информатика");
                AddStudent("Крутой Чувак Очень", "ИК21-2", "Дизайн");
            }
        }

        /// <summary>
        /// Добавляет студентов
        /// </summary>
        /// <param name="name"></param>
        /// <param name="group"></param>
        /// <param name="speciality"></param>
        public void AddStudent(string name, string group, string speciality)
        {
            var sameGroup = repository.ReadAll().FirstOrDefault(s => s.Group == group);
            if (sameGroup != null)
            {
                speciality = sameGroup.Speciality;
            }
            repository.Create(new Student(name, speciality, group));
        }
        /// <summary>
        /// Удаляет студентов
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteStudent(int id)
        {
            if (repository.ReadById(id) == null)
            {
                return false;
            }
            repository.Delete(repository.ReadById(id));
            return true;
        }
        /// <summary>
        /// Формирует List с информацией о студентах
        /// </summary>
        /// <returns></returns>
        public List<string[]> ShowTable()
        {
            var table = new List<string[]>();
            foreach (var s in repository.ReadAll())
            {
                table.Add( new string[] { s.Id.ToString(), s.Name, s.Speciality, s.Group });
            }
            return table;
        }
        /// <summary>
        /// Формирует словарь для составления гистограммы по специальностям
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> ShowHistogram()
        {
            var gistogram = repository.ReadAll()
                .GroupBy(s => s.Speciality)
                .ToDictionary(k => k.Key, c => c.Count());
            return gistogram;
        }
        /// <summary>
        /// Проверяет вводимый текст
        /// </summary>
        /// <param name="proverim"></param>
        /// <param name="checkmode"></param>
        /// <returns>
        /// В зависимости от ошибки возвращает соответвующий текст
        /// </returns>
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
                            return "Неверный ввод специальности: используйте буквы, а также (-), если нужно";
                        }
                    }
                    return null;
                default:
                    return "Неизвестный режим проверки!";
            }
        }
    }
}
/// <summary>
/// Режимы проверки слов в имени, группы и специальности
/// </summary>
public enum CheckMode
{
    Letters,
    SpecChars,
    Specalnst
}