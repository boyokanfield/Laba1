using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    class Note
    {
        private string surname;
        public string Surname
        {
            get { return this.surname; }
            set { this.surname = value; }
        }
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        private string secondName;
        public string SecondName
        {
            get { return this.secondName; }
            set { this.secondName = value; }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }
        private string country;
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }
        private string organization;
        public string Organization
        {
            get { return this.organization; }
            set { this.organization = value; }
        }
        private string position;
        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
        private string info;
        public string Info
        {
            get { return this.info; }
            set { this.info = value; }
        }

        public static Note CreateNote()
        {
            Note note = new Note();
            //string s;
            Console.Write("Фамилия: ");
            note.Surname = Check.IsEmpty(Console.ReadLine());
            Console.Write("Имя: ");
            note.Name = Check.IsEmpty(Console.ReadLine());
            Console.Write("Отчество: ");
            note.SecondName = Console.ReadLine();
            Console.Write("Номер телефона: ");
            note.PhoneNumber = Check.CheckNumber(Console.ReadLine());
            Console.Write("Страна: ");
            note.Country = Check.IsEmpty(Console.ReadLine());
            Console.Write("Дата рождения: ");
            note.DateOfBirth = Check.CheckDate(Console.ReadLine());
            Console.Write("Организация: ");
            note.Organization = Console.ReadLine();
            Console.Write("Должность: ");
            note.Position = Console.ReadLine();
            Console.Write("Прочие заметки: ");
            note.Info = Console.ReadLine();
            return note;
        }

        public static void EditNote(Note note)
        {
            Console.Write("Выберите поля для изменения: ");
            string fieldList = Console.ReadLine();
            string[] field = fieldList.Split(',');
            for (int i = 0; i < field.Length; i++)
            {
                switch (field[i])
                {
                    case "1":
                        {
                            Console.Write("Новая фамилия: ");
                            note.Surname = Check.IsEmpty(Console.ReadLine());
                            break;
                        }
                    case "2":
                        {
                            Console.Write("Новое имя: ");
                            note.Name = Check.IsEmpty(Console.ReadLine());
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Новое отчество: ");
                            note.SecondName = Console.ReadLine();
                            break;
                        }
                    case "4":
                        {
                            Console.Write("Новый номер телефона: ");
                            note.PhoneNumber = Check.CheckNumber(Console.ReadLine());
                            break;
                        }
                    case "5":
                        {
                            Console.Write("Новая страна: ");
                            note.Country = Check.IsEmpty(Console.ReadLine());
                            break;
                        }
                    case "6":
                        {
                            Console.Write("Новая дата рождения: ");
                            note.DateOfBirth = Check.CheckDate(Console.ReadLine());
                            break;
                        }
                    case "7":
                        {
                            Console.Write("Новая организация: ");
                            note.Organization = Console.ReadLine();
                            break;
                        }
                    case "8":
                        {
                            Console.Write("Новая должность: ");
                            note.Position = Console.ReadLine();
                            break;
                        }
                    case "9":
                        {
                            Console.Write("Новые прочие заметки: ");
                            note.Info = Console.ReadLine();
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

        public static void ShowNote(Note note)
        {
            Console.WriteLine("Фамилия: " + note.Surname);
            Console.WriteLine("Имя: " + note.Name);
            Console.WriteLine("Отчество: " + note.SecondName);
            Console.WriteLine("Номер телефона: " + note.PhoneNumber);
            Console.WriteLine("Страна: " + note.Country);
            if (note.DateOfBirth == DateTime.MinValue)
                Console.WriteLine("Дата рождения: ");
            else
                Console.WriteLine("Дата рождения: " + note.DateOfBirth.Day + "." + note.DateOfBirth.Month + "." + note.DateOfBirth.Year);
            Console.WriteLine("Организация: " + note.Organization);
            Console.WriteLine("Должность: " + note.Position);
            Console.WriteLine("Прочие заметки: " + note.Info);
        }

        public static string ShortShowNote(Note note)
        {
            string s = note.Surname + " " + note.Name + " " + note.PhoneNumber;
            return s;
        }
    }
}
