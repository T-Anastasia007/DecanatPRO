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
                            if (l.CheckOnDurak( _group, CheckMode.SpecChars) != null)
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

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:
                        wle = false;
                        break;
                }
            }
        }
    }
}
