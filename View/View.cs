using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace DecanatPRO
{
    public class View
    {
        static void Main(string[] args)
        {
            Logic l = new Logic();
            // === Тестовые студенты (заполняется автоматически при запуске) ===
            l.AddStudent("Иванов Иван Иванович", "ПИ-21-1", "Прикладная информатика");
            l.AddStudent("Петров Пётр Петрович", "ПИ-21-1", "Прикладная информатика");
            l.AddStudent("Сидорова Анна Сергеевна", "ПИ-21-2", "Прикладная информатика");
            l.AddStudent("Кузнецов Дмитрий Олегович", "ИС-22-1", "Информационные системы");
            l.AddStudent("Смирнова Ольга Ивановна", "ИС-22-1", "Информационные системы");
            l.AddStudent("Попов Алексей Николаевич", "МО-23-1", "Математическое обеспечение");
            // ================================================================
            Random r = new Random();
            bool wle = true;
            while (wle)
            {
                int rr = r.Next(0, 10);
                Console.WriteLine("------ Decanat Pro ------");
                if (rr == 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Купить подписку за 199 рублей в день");

                }
                Console.WriteLine("");
                Console.WriteLine("1. Добавить студента");
                Console.WriteLine("2. Удалить студента");
                Console.WriteLine("3. Показать таблицу");
                Console.WriteLine("4. Показать гистаграмму");
                Console.WriteLine("5. Выйти");
                int swch = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (swch)
                {
                    case 1:
                        string _lastname = "";
                        string _firstname = "";
                        string _middlename = "";
                        string _group = "";
                        string _spec = "";
                        while (true)
                        {
                            Console.WriteLine("Введите Фамилию: ");
                            _lastname = Console.ReadLine();
                            if (l.CheckOnDurak(_lastname, CheckMode.Letters) != null)
                            {
                                Console.WriteLine(l.CheckOnDurak(_lastname, CheckMode.Letters));
                                continue;
                            }
                            break;
                        }
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("Введите Имя: ");
                            _firstname = Console.ReadLine();
                            if (l.CheckOnDurak(_firstname, CheckMode.Letters) != null)
                            {
                                Console.WriteLine(l.CheckOnDurak(_firstname, CheckMode.Letters));
                                continue;
                            }
                            break;
                        }
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("Введите Отчество (при наличии): ");
                            _middlename = Console.ReadLine();
                            if (_middlename == "" || _middlename == " ")
                            {
                                break;
                            }
                            if (l.CheckOnDurak(_middlename, CheckMode.Letters) != null)
                            {
                                Console.WriteLine(l.CheckOnDurak(_middlename, CheckMode.Letters));
                                continue;
                            }
                            break;
                        }
                        Console.Clear();
                        string _name = $"{_lastname} {_firstname} {_middlename}".Trim();
                        while (true)
                        {
                            Console.WriteLine("Введите группу: ");
                            _group = Console.ReadLine();
                            if (l.CheckOnDurak(_group, CheckMode.SpecChars) != null)
                            {
                                Console.WriteLine(l.CheckOnDurak(_group, CheckMode.SpecChars));
                                continue;
                            }
                            break;
                        }
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("Введите специальность: ");
                            _spec = Console.ReadLine();
                            if (l.CheckOnDurak(_spec, CheckMode.Specalnst) != null)
                            {
                                Console.WriteLine(l.CheckOnDurak(_spec, CheckMode.Specalnst));
                                continue;
                            }
                            break;
                        }
                        Console.Clear();
                        _group = _group.Trim();
                        _spec = _spec.Trim();
                        Console.WriteLine($"Добавлен {_name} | {_group} | {_spec}");
                        l.AddStudent(_name, _group, _spec);
                        break;
                    case 2:
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
                            if (otch == "X") { Console.Clear(); break; }
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
                        break;
                    case 3:
                        var _tablee = l.ShowTable();
                        Console.WriteLine("| ID |            Имя            |      Группа      |               Специальность               ");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        foreach (var t in _tablee)
                        {
                            Console.WriteLine($"ID {t[0]} | Имя: {t[1]} | Группа: {t[3]} | Специальность {t[2]}");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
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
                        break;
                    case 5:
                        wle = false;
                        break;
                    default:
                        Console.WriteLine("Неккоретный ввод!");
                        break;
                }
            }
        }
    }
}
