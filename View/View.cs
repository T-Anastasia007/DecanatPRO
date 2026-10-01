using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace DecanatPRO
{
    public class View
    {
        static void Main(string[] args)
        {
            Logic l = new Logic();
            l.AddStudent("Иванов Иван Иванович", "ГФ21-1", "Прикладная информатика");
            l.AddStudent("Петров Пётр Петрович", "ГФ25-2", "Прикладная информатика");
            l.AddStudent("Крутой Чувак Очень", "ИК21-2", "Дизайн");
            Random r = new Random();
            bool wle = true;
            while (wle)
            {
                RandomPashalka(r);
                Console.WriteLine("");
                Console.WriteLine("1. Добавить студента");
                Console.WriteLine("2. Удалить студента");
                Console.WriteLine("3. Показать таблицу");
                Console.WriteLine("4. Показать гистаграмму");
                Console.WriteLine("5. Выйти");
                string swch = Console.ReadLine();
                int arturpirojkov = 0;
                switch (swch)
                {
                    case "1":
                        AddStudentInput(l);
                        break;
                    case "2":
                        DeleteStudentInput(l);
                        break;
                    case "3":
                        ShowTable(l);
                        break;
                    case "4":
                        ShowHistro(l);
                        break;
                    case "5":
                        wle = false;
                        break;
                    default:
                        Console.WriteLine("Неккоретный ввод!");
                        break;
                }
            }
        }

        private static void ShowHistro(Logic l)
        {
            var histo = l.ShowHistogram();
            foreach (var i in histo)
            {
                Console.Write($"{i.Key}: ");
                for (int j = 0; j < i.Value; j++)
                {
                    Console.Write("-");
                }
                System.Console.WriteLine("");
            }
            Console.ReadLine();
            Console.Clear();
        }

        private static void ShowTable(Logic l)
        {
            var _tablee = l.ShowTable();
            Console.WriteLine("| ID |            Имя            |      Группа      |               Специальность               ");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            foreach (var t in _tablee)
            {
                Console.WriteLine($"ID {t[0]} | Имя: {t[1]} | Группа: {t[3]} | Специальность {t[2]}");
            }
            Console.ReadLine();
            Console.Clear();
        }

        private static void DeleteStudentInput(Logic l)
        {
            var _table = l.ShowTable();
            foreach (var t in _table)
            {
                Console.WriteLine($"ID {t[0]} | Имя: {t[1]} | Группа: {t[3]} | Специальность {t[2]}");
            }
            Console.WriteLine("Введите ID того, кого хотите отчислить (ЕСЛИ НИКОГО, НАЖМИТЕ X)");
            int del = 0;
            while (true)
            {
                string otch = Console.ReadLine();
                if (otch == "X")
                { 
                    Console.Clear(); 
                    break; 
                }
                if (Int32.TryParse(otch, out del))
                {
                    if (l.DeleteStudent(del))
                    {
                        Console.WriteLine("Успешно!");
                    }
                    else
                    {
                        Console.WriteLine("Студент с таким ID не найден :(");
                    }
                    break;
                }
                Console.WriteLine("Вы ввели не цифры...");
            }
            Console.ReadLine();
            Console.Clear();
        }

        private static void AddStudentInput(Logic l)
        {
            string _lastname = "";
            string _firstname = "";
            string _middlename = "";
            string _group = "";
            string _spec = "";
            Console.WriteLine("Введите Фамилию: ");
            _lastname = Check(l, CheckMode.Letters);
            Console.Clear();
            Console.WriteLine("Введите Имя: ");
            _firstname = Check(l, CheckMode.Letters);
            Console.Clear();
            Console.WriteLine("Введите Отчество (Нажмите X если отсутствует): ");
            _middlename = Check(l, CheckMode.Letters, true);
            Console.Clear();
            string _name = $"{_lastname} {_firstname} {_middlename}".Trim();
            Console.WriteLine("Введите группу: ");
            _group = Check(l, CheckMode.SpecChars);
            Console.Clear();
            Console.WriteLine("Введите специальность: ");
            _spec = Check(l, CheckMode.Specalnst);
            Console.Clear();
            _group = _group.Trim();
            _spec = _spec.Trim();
            Console.WriteLine($"Добавлен {_name} | {_group} | {_spec}");
            l.AddStudent(_name, _group, _spec);
        }

        private static string Check(Logic l, CheckMode ckmd, bool checkEmpty = false)
        {
            while (true)
            {
                string check = Console.ReadLine().Trim();
                if (checkEmpty && (check == "" || check == "X" || check == "Х"))
                {
                    return "";
                }
                string err = l.CheckOnDurak(check, ckmd);
                if (err != null)
                {
                    Console.WriteLine(err);
                    continue;
                }
                return check;
            }
        }
        private static void RandomPashalka(Random r)
        {
            int rr = r.Next(0, 10);
            Console.WriteLine("------ Decanat Pro ------");
            if (rr == 5)
            {
                Console.WriteLine("");
                Console.WriteLine("Купить подписку за 199 рублей в день");

            }
        }
    }
}
