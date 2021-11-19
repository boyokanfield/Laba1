using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    class Note
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Organization { get; set; }
        public string Info { get; set; }
        public string Position { get; set; }

        public Note()
        {
            Console.Write("Фамилия: ");
            Surname = Check.Name(Console.ReadLine());
            Console.Write("Имя: ");
            Name = Check.Name(Console.ReadLine());
            Console.Write("Отчество: ");
            SecondName = Check.SimpleString(Console.ReadLine());
            Console.Write("Номер телефона: ");
            PhoneNumber = Check.Number(Console.ReadLine());
            Console.Write("Страна: ");
            Country = Check.Name(Console.ReadLine());
            Console.Write("Дата рождения: ");
            DateOfBirth = Check.Date(Console.ReadLine());
            Console.Write("Организация: ");
            Organization = Console.ReadLine();
            Console.Write("Должность: ");
            Position = Check.SimpleString(Console.ReadLine());
            Console.Write("Прочие заметки: ");
            Info = Console.ReadLine();
        }

        public void EditNote()
        {
            Console.Write("Выберите поля для изменения в формате *Поле*,*Поле*...: ");
            string fieldList = Console.ReadLine();
            string[] field = fieldList.Split(',');
            for (int i = 0; i < field.Length; i++)
            {
                switch (field[i])
                {
                    case "Фамилия":
                        {
                            Console.Write("Новая фамилия: ");
                            Surname = Check.Name(Console.ReadLine());
                            break;
                        }
                    case "Имя":
                        {
                            Console.Write("Новое имя: ");
                            Name = Check.Name(Console.ReadLine());
                            break;
                        }
                    case "Отчество":
                        {
                            Console.Write("Новое отчество: ");
                            SecondName = Check.SimpleString(Console.ReadLine());
                            break;
                        }
                    case "Номер телефона":
                        {
                            Console.Write("Новый номер телефона: ");
                            PhoneNumber = Check.Number(Console.ReadLine());
                            break;
                        }
                    case "Страна":
                        {
                            Console.Write("Новая страна: ");
                            Country = Check.Name(Console.ReadLine());
                            break;
                        }
                    case "Дата рождения":
                        {
                            Console.Write("Новая дата рождения: ");
                            DateOfBirth = Check.Date(Console.ReadLine());
                            break;
                        }
                    case "Организация":
                        {
                            Console.Write("Новая организация: ");
                            Organization = Console.ReadLine();
                            break;
                        }
                    case "Должность":
                        {
                            Console.Write("Новая должность: ");
                            Position = Check.SimpleString(Console.ReadLine());
                            break;
                        }
                    case "Прочие заметки":
                        {
                            Console.Write("Новые прочие заметки: ");
                            Info = Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Извините, но опции {field[i]} не существует ");
                            break;
                        }
                }
            }
        }

        public void ShowNote()
        {
            Console.WriteLine("Фамилия: " + Surname);
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Отчество: " + SecondName);
            Console.WriteLine("Номер телефона: " + PhoneNumber);
            Console.WriteLine("Страна: " + Country);
            if (DateOfBirth == DateTime.MinValue)
                Console.WriteLine("Дата рождения: ");
            else
                Console.WriteLine("Дата рождения: " + DateOfBirth.Day + "." + DateOfBirth.Month + "." + DateOfBirth.Year);
            Console.WriteLine("Организация: " + Organization);
            Console.WriteLine("Должность: " + Position);
            Console.WriteLine("Прочие заметки: " + Info);
        }

        public string ShortShowNote()
        {
            string s = Surname + " " + Name + " " + PhoneNumber;
            return s;
        }
    }
}
