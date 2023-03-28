using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Номер(-а) курса(-ов) через пробел: ");
                    string inputString = Console.ReadLine();
                    string[] inputSplited = inputString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    int[] inputInt = new int[inputSplited.Length]; //получение инпута от юзера и вкладывание значений в массив kursnums

                    for (int i = 0; i < inputSplited.Length; i++)
                    {
                        int num = Convert.ToInt32(inputSplited[i]);
                        if (num <= 0 || num > 4) throw new Exception($"курса {num} не существует");
                        inputInt[i] = num;
                    }
                    Array.Sort(inputInt);
                    
                    if (inputInt.Length >= 5) throw new Exception("число введённых курсов больше 4-х");
                    if (inputInt.Count() != inputInt.Distinct().Count()) throw new Exception("повторяющиеся номера курсов");
                    int[,] studs = College.StudNum();

                    College.ShowGroupsByCourse(studs);
                    Console.WriteLine($"Сумма студентов всех групп введённого курса(-ов): {College.ShowInputSum(studs, inputInt)}");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
    class College
    {
        public static int[,] StudNum() //возвращает массив stud с рандомными значениями кол-ва студентов в 4 курсах по 8 групп
        {
            int[,] stud = new int[4, 8];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++) stud[i, j] = rnd.Next(1, 30);
            }
            return stud;
        }
        public static void ShowGroupsByCourse(int[,] stud)
        {
            for (int i = 0; i < stud.GetLength(0); i++)
            {
                List<int> list = new List<int>();
                for (int j = 0; j < stud.GetLength(1); j++) list.Add(stud[i, j]);
                Console.WriteLine($"Курс {i+1}: {string.Join(' ', list)}");
                list.Clear();
            }
            Console.WriteLine();
        }
        public static int ShowInputSum(int[,] stud, int[] nums) //возвращает sum студентов групп введённых курсов (массив nums)
        {
            int sum = 0;
            foreach (int i in nums) for (int j = 0; j < stud.GetLength(1); j++) sum += stud[i - 1, j];
            return sum;
        }
    }
}
