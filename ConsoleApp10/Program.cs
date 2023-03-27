using System;

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
                    string input = Console.ReadLine();
                    string[] splitedInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    int[] kursnums = new int[splitedInput.Length];
                    for (int i = 0; i < splitedInput.Length; i++)
                    {
                        int num = Convert.ToInt32(splitedInput[i]);
                        if (num == 0 || num < 0 || num > 4) throw new Exception("не может быть такого курса");
                        kursnums[i] = num;
                    }
                    int[,] stud = College.StudNum();
                    Console.WriteLine($"Сумма студентов всех групп введённого курса(-ов): {College.ShowStudSum(stud, kursnums)}");
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
        public static int[,] StudNum()
        {
            int[,] stud = new int[4, 8];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++) stud[i, j] = rnd.Next(1, 30);
            }
            return stud;
        }

        public static int ShowStudSum(int[,] stud, int[] nums)
        {
            int sum = 0;
            for (int k = 0; k < nums.Length; k++)
            {
                for (int i = 0; i < stud.GetLength(0); i++)
                {
                    if (nums[k] == i + 1)
                    {
                        for (int j = 0; j < stud.GetLength(1); j++)
                        {
                            sum += stud[i, j];
                        }
                    }
                }
            }
            return sum;
        }
    }
}
