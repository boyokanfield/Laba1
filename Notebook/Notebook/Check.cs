using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Notebook
{
    class Check
    {
        public static string Name(string s)
        {
            while(!s.All(l => char.IsLetter(l)))
            {
                Console.WriteLine("Данное поле необходимо заполнить корректно. Попробуйте ещё раз");
                Console.Write("> ");
                s = Console.ReadLine();
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public static string Number(string s)
        {
            while (!ulong.TryParse(s, out ulong a))
            {
                Console.WriteLine("Данное поле необходимо заполнить корректно. Попробуйте ещё раз");
                Console.Write("> ");
                s = Console.ReadLine();
            }
            return s;
        }

        public static DateTime Date(string s)
        {
            if (!DateTime.TryParse(s, out DateTime value))
            {
                Console.WriteLine("Вы ввели довольно странную дату");
                return DateTime.MinValue;
            }
            else
                return value;
        }

        public static string ID(Notebook notebook, string s)
        {
            while (!int.TryParse(s, out int id) || !notebook.notes.Keys.Contains(id))
            {
                Console.WriteLine("Данное поле необходимо заполнить корректно. Попробуйте ещё раз");
                Console.Write("> ");
                s = Console.ReadLine();
                if (s == "Отмена")
                    break;
            }
            return s;
        }

        public static string SimpleString(string s)
        {
            if(s.All(l => char.IsLetter(l)))
                return s;
            else
            {
                Console.WriteLine("Какое-то странное значение");
                return "";
            }
        }
    }
}
