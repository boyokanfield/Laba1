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
            Notebook notebook = Notebook.CreateNotebook();
            Console.WriteLine("Добро пожаловать в записную телефонную книжку!");
            Console.WriteLine("Для взаимодействия с книжкой выберите один из вариантов:");
            Console.WriteLine("1 - Создание записи");
            Console.WriteLine("2 - Редактирование записи");
            Console.WriteLine("3 - Удаление записи");
            Console.WriteLine("4 - Просмотр записи");
            Console.WriteLine("5 - Просмотр всех записей");
            Console.WriteLine("6 - Выход из книжки");
            Console.Write("Введите номер действия: ");
            string command = Console.ReadLine();
            bool work = true;
            while (work)
            {
                switch (command)
                {
                    case "1":
                        {
                            Console.WriteLine("========== СОЗДАНИЕ ЗАПИСИ ==========");
                            Notebook.AddNote(notebook);
                            Console.WriteLine("========== СОЗДАНИЕ ЗАПИСИ ЗАВЕРШЕНО ==========");
                            Console.Write("Введите номер действия: ");
                            command = Console.ReadLine();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("========== РЕДАКТИРОВАНИЕ ЗАПИСИ ==========");
                            Console.Write("Введите ID записи для редактирования: ");
                            if (notebook.notes.Count == 0)
                                Console.WriteLine("\nИзвините, но записная книжка не имеет записей.");
                            else
                                Notebook.EditNote(notebook, Check.CheckID(notebook, Console.ReadLine()));
                            Console.WriteLine("========== РЕДАКТИРОВАНИЕ ЗАПИСИ ЗАВЕРШЕНО ==========");
                            Console.Write("Введите номер действия: ");
                            command = Console.ReadLine();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("========== УДАЛЕНИЕ ЗАПИСИ ==========");
                            Console.Write("Введите ID записи для удаления: ");
                            if (notebook.notes.Count == 0)
                                Console.WriteLine("\nИзвините, но записная книжка не имеет записей.");
                            else
                                Notebook.DeleteNote(notebook, Check.CheckID(notebook, Console.ReadLine()));
                            Console.WriteLine("========== УДАЛЕНИЕ ЗАПИСИ ЗАВЕРШЕНО ==========");
                            Console.Write("Введите номер действия: ");
                            command = Console.ReadLine();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("========== ПРОСМОТР ЗАПИСИ ==========");
                            Console.Write("Введите ID записи для просмотра: ");
                            if (notebook.notes.Count == 0)
                                Console.WriteLine("\nИзвините, но записная книжка не имеет записей.");
                            else
                                Notebook.ShowNote(notebook, Check.CheckID(notebook, Console.ReadLine()));
                            Console.WriteLine("========== ПРОСМОТР ЗАПИСИ ЗАВЕРШЕН ==========");
                            Console.Write("Введите номер действия: ");
                            command = Console.ReadLine();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("========== ПРОСМОТР ВСЕХ ЗАПИСЕЙ ==========");
                            if (notebook.notes.Count == 0)
                                Console.WriteLine("\nИзвините, но записная книжка не имеет записей.");
                            else
                                Notebook.ShortShowNote(notebook);
                            Console.WriteLine("========== ПРОСМОТР ВСЕХ ЗАПИСЕЙ ЗАВЕРШЕН ==========");
                            Console.Write("Введите номер действия: ");
                            command = Console.ReadLine();
                            break;
                        }
                    case "6":
                        {
                            work = false;
                            Console.WriteLine("========== ВЫХОД ИЗ КНИЖКИ ==========");
                            Console.WriteLine("До свидания!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Извините, но данной команды не существует. Пожалуйста, выберите команду из преложенного списка.");
                            Console.Write("Введите номер действия: ");
                            command = Console.ReadLine();
                            break;
                        }

                }
            }
        }
    }
}
