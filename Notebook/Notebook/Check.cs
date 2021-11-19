using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Notebook
{
    class Check
    {
        public static string IsEmpty(string s)
        {
            while (string.IsNullOrWhiteSpace(s) || s.Any(l => char.IsDigit(l)))
            {
                Console.WriteLine("Данное поле необходимо заполнить корректно. Попробуйте ещё раз");
                Console.Write(">");
                s = Console.ReadLine();
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public static string CheckNumber(string s)
        {
            while (string.IsNullOrWhiteSpace(s) || !long.TryParse(s, out long a))
            {
                Console.WriteLine("Данное поле необходимо заполнить корректно. Попробуйте ещё раз");
                Console.Write(">");
                s = Console.ReadLine();
            }
            return s;
        }

        public static DateTime CheckDate(string s)
        {
            if (!DateTime.TryParse(s, out DateTime value))
            {
                return DateTime.MinValue;
            }
            else
            {
                return value;
            }
        }

        public static int CheckID(Notebook notebook, string s)
        {
            int id;
            while (string.IsNullOrWhiteSpace(s) || !int.TryParse(s, out id) || !notebook.notes.Keys.Contains(id))
            {
                Console.WriteLine("Данное поле необходимо заполнить корректно. Попробуйте ещё раз");
                Console.Write(">");
                s = Console.ReadLine();
            }
            return id;
        }
    }
}
