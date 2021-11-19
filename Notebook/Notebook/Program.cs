using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            Console.WriteLine("Добро пожаловать в записную телефонную книжку!");
            Console.WriteLine("Для взаимодействия с книжкой выберите один из вариантов:");
            Console.WriteLine("Создать - Создание записи");
            Console.WriteLine("Редактировать - Редактирование записи");
            Console.WriteLine("Удалить - Удаление записи");
            Console.WriteLine("Просмотреть - Просмотр записи");
            Console.WriteLine("Просмотреть все - Просмотр всех записей");
            Console.WriteLine("Выйти - Выход из книжки");
            Console.Write("Введите команду: ");
            string command = Console.ReadLine();
            bool work = true;
            while (work)
            {
                switch (command)
                {
                    case "Создать":
                        {
                            Console.WriteLine("========== СОЗДАНИЕ ЗАПИСИ ==========");
                            notebook.AddNote();
                            Console.WriteLine("========== СОЗДАНИЕ ЗАПИСИ ЗАВЕРШЕНО ==========\n");
                            Console.Write("Введите команду: ");
                            command = Console.ReadLine();
                            break;
                        }
                    case "Редактировать":
                        {
                            Console.WriteLine("========== РЕДАКТИРОВАНИЕ ЗАПИСИ ==========");
                            Console.Write("Введите ID записи для редактирования: ");
                            if (notebook.notes.Count == 0)
                                Console.WriteLine("\nИзвините, но записная книжка не имеет записей.");
                            else
                            {
                                string s = Check.ID(notebook, Console.ReadLine());
                                if (s == "Отмена")
                                {
                                    Console.WriteLine("========== РЕДАКТИРОВАНИЕ ЗАПИСИ ЗАВЕРШЕНО ==========\n");
                                    Console.Write("Введите команду: ");
                                    command = Console.ReadLine();
                                    break;
                                }
                                else
                                    notebook.EditNote(Convert.ToInt32(s));
                            }
                            Console.WriteLine("========== РЕДАКТИРОВАНИЕ ЗАПИСИ ЗАВЕРШЕНО ==========\n");
                            Console.Write("Введите команду: ");
                            command = Console.ReadLine();
                            break;
                        }
                    case "Удалить":
                        {
                            Console.WriteLine("========== УДАЛЕНИЕ ЗАПИСИ ==========");
                            Console.Write("Введите ID записи для удаления: ");
                            if (notebook.notes.Count == 0)
                                Console.WriteLine("\nИзвините, но записная книжка не имеет записей.");
                            else
                            {
                                string s = Check.ID(notebook, Console.ReadLine());
                                if (s == "Отмена")
                                {
                                    Console.WriteLine("========== УДАЛЕНИЕ ЗАПИСИ ЗАВЕРШЕНО ==========\n");
                                    Console.Write("Введите команду: ");
                                    command = Console.ReadLine();
                                    break;
                                }
                                else
                                    notebook.DeleteNote(Convert.ToInt32(s));
                            }
                            Console.WriteLine("========== УДАЛЕНИЕ ЗАПИСИ ЗАВЕРШЕНО ==========\n");
                            Console.Write("Введите команду: ");
                            command = Console.ReadLine();
                            break;
                        }
                    case "Просмотреть":
                        {
                            Console.WriteLine("========== ПРОСМОТР ЗАПИСИ ==========");
                            Console.Write("Введите ID записи для просмотра: ");
                            if (notebook.notes.Count == 0)
                                Console.WriteLine("\nИзвините, но записная книжка не имеет записей.");
                            else
                            {
                                string s = Check.ID(notebook, Console.ReadLine());
                                if (s == "Отмена")
                                {
                                    Console.WriteLine("========== ПРОСМОТР ЗАПИСИ ЗАВЕРШЕН ==========\n");
                                    Console.Write("Введите команду: ");
                                    command = Console.ReadLine();
                                    break;
                                }
                                else
                                    notebook.ShowNote(Convert.ToInt32(s));
                            }
                            Console.WriteLine("========== ПРОСМОТР ЗАПИСИ ЗАВЕРШЕН ==========\n");
                            Console.Write("Введите команду: ");
                            command = Console.ReadLine();
                            break;
                        }
                    case "Просмотреть все":
                        {
                            Console.WriteLine("========== ПРОСМОТР ВСЕХ ЗАПИСЕЙ ==========");
                            if (notebook.notes.Count == 0)
                                Console.Write("\nИзвините, но записная книжка не имеет записей.");
                            else
                                notebook.ShortShowNote();
                            Console.WriteLine("========== ПРОСМОТР ВСЕХ ЗАПИСЕЙ ЗАВЕРШЕН ==========\n");
                            Console.Write("Введите команду: ");
                            command = Console.ReadLine();
                            break;
                        }
                    case "Выйти":
                        {
                            work = false;
                            Console.WriteLine("========== ВЫХОД ИЗ КНИЖКИ ==========\n");
                            Console.WriteLine("До свидания!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Извините, но данной команды не существует. Пожалуйста, выберите команду из преложенного списка.\n");
                            Console.Write("Введите команду: ");
                            command = Console.ReadLine();
                            break;
                        }

                }
            }
        }
    }
}
