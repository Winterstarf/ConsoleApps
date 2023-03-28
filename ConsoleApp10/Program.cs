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
                    string inputString = Console.ReadLine();
                    string[] inputSplited = inputString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    int[] inputInt = new int[inputSplited.Length]; //получение инпута от юзера и вкладывание значений в массив kursnums

                    for (int i = 0; i < inputSplited.Length; i++)
                    {
                        int num = Convert.ToInt32(inputSplited[i]);
                        if (num <= 0 || num > 4) throw new Exception("не может быть такого курса (или введено больше 4-х)");
                        inputInt[i] = num;
                    }
                    int[,] studs = College.StudNum();

                    Console.WriteLine($"Сумма студентов всех групп введённого курса(-ов): {College.ShowStudSum(studs, inputInt)}");
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
        public static int ShowStudSum(int[,] stud, int[] nums) //возвращает sum студентов групп введённых курсов (массив nums)
        {
            int sum = 0;
            for (int k = 0; k < nums.Length; k++)
            {
                for (int i = 0; i < stud.GetLength(0); i++)
                {
                    if (nums[k] == i + 1) //+1 т.к. в stud курсы от 0 до 3, а в nums могут быть только от 1 до 4
                    {  
                        for (int j = 0; j < stud.GetLength(1); j++) sum += stud[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
