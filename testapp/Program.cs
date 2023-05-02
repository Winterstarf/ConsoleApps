using System;
using System.IO;

namespace testapp
{
    class Program
    {
        enum DaysOfWeek
        {
            понедельник,
            вторник,
            среда,
            четверг,
            пятница,
            суббота,
            воскресенье
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("день 1: ");
                string inputDays1 = Console.ReadLine();
                if (!int.TryParse(inputDays1, out int intDays1) || intDays1 <= 0 || intDays1 > 31) throw new Exception("Error: there's only 31 days in a month");
                else if (inputDays1 == string.Empty) throw new Exception("Error: the string you entered is empty");
                DaysOfWeek day1 = (DaysOfWeek)((intDays1 - 1) % 7);
                Console.WriteLine($"День {inputDays1} - {day1}");
                Console.Write("день 2: ");
                string inputDays2 = Console.ReadLine();
                if (!int.TryParse(inputDays2, out int intDays2) || intDays2 <= 0 || intDays2 > 31) throw new Exception("Error: there's only 31 days in a month");
                else if (inputDays2 == string.Empty) throw new Exception("Error: the string you entered is empty");
                DaysOfWeek day2 = (DaysOfWeek)((intDays2 - 1) % 7);
                Console.WriteLine($"День {inputDays2} - {day2}");
                Console.WriteLine($"Разница между днями: {Days.ObscureCounting(intDays1, intDays2)}");

                Console.Write("футбик: ");
                string inputSoccer = Console.ReadLine();
                if (!int.TryParse(inputSoccer, out int intSoccer) || intSoccer <= 0 || intSoccer > 11) throw new Exception("Error: there's only eleven players");
                else if (inputSoccer == string.Empty) throw new Exception("Error: the string you entered is empty");
                Soccerman s = new Soccerman();
                Console.WriteLine($"Футболист - {s[intSoccer]}");
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }
    class Soccerman //класс футболера который содержит имя и номер футболера и класс футбол тимы, хранящий 11 плееров в массиве и индексатор
    {
        private string[] Players = {
            "Иван Иванович (1)",
            "Степан Михайлович (2)",
            "Михаил Розенбан (3)",
            "Игорь Боберт (4)",
            "Робин Бобин (5)",
            "Демиан Фрут (6)",
            "Валерий Путь (7)",
            "Саймон Райли (8)",
            "Соуп МакТавиш (9)",
            "Лионель Месси (10)",
            "Джон Прайс (11)"};
        public string this[int i]
        {
            get { return Players[i - 1]; }
            set { Players[i - 1] = value; }
        }
    }
    class Days
    { 
        public static int ObscureCounting(int i, int j) => (i > j) ? i - j - 1 : j - i - 1;
    }
}
