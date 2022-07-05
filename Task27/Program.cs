// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

namespace Seminar4
{
    class Task27
    {
        static void Main(string[] args)
        {
            Console.Clear();
            try
            {
            Console.WriteLine("Please enter number:");
            string? number = Console.ReadLine();
            int result = 0;
            if (!String.IsNullOrEmpty(number))
            {
                foreach (char c in number)
                {
                    result += Convert.ToInt32(c.ToString());
                }
            }
            Console.WriteLine($"The sum of all digits in number is: {result}");
            Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Input is incorrect!");
                Console.WriteLine();
            }
        }
    }
}