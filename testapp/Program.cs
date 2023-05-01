using System;
using System.IO;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("день: ");
                string inputDays = Console.ReadLine();
                if (!int.TryParse(inputDays, out int intDays) || intDays <= 0 || intDays > 31) throw new Exception("Error: there's only 31 days in a month");
                else if (inputDays == string.Empty) throw new Exception("Error: the string you entered is empty");
                DaysOfWeek day = (DaysOfWeek)(intDays % 7);
                Console.WriteLine($"Сегодня - {day}");

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
        enum DaysOfWeek
        {
            понедельник = 1,
            вторник,
            среда,
            четверг,
            пятница,
            суббота,
            воскресенье
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
}
