using System;

namespace ConsoleApp04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*имеется аррей стрингов с фамами сотрудников
             фамилии предопределены (иванов, петров, сидоров)
            и массив с именами сотрудников (ваня, петя, коля)
            вывести фам и имя сотрудника*/
            string[] lastName = new string[3] { "Иванов", "Петров", "Сидоров" };
            string[] firstName = new string[3] { "Ваня", "Петя", "Коля" };
            for (int i = 0; i < lastName.Length; i++) Console.WriteLine($"{lastName[i]} {firstName[i]}");
        }
    }
}
