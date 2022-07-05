namespace Seminar4
{
    class Task25

    // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
    // возводит число A в натуральную степень B.
    // 3, 5 -> 243 (3⁵)
    // 2, 4 -> 16

    {
        static void Main(string[] args)
        {
            Decision Degree = new Decision();
            while (true)
            {
                Degree.TaskConditions();
                string? answer = Console.ReadLine();
                if (!String.IsNullOrEmpty(answer)) answer = answer.ToLower();
                if (answer == "y")
                {
                    Degree.FillPow();
                    Degree.PrintPow();
                    Console.ReadKey(); // or Thread.Sleep(4000);
                    continue;
                }
                else if (answer == "n") break;
                else continue;
            }
        }
    }
}

class Decision
{
    private static int number;
    private static int pow;
    private static int result;

    private int Pow()
    {
        for (int i = 0; i < pow; i++)
        {
            result = result * number;
        }
        return result;
    }

    public void TaskConditions()
    {
        Console.Clear();
        Console.WriteLine("Do you want to get the result of the");
        Console.WriteLine("first number to the power of the second?");
        Console.Write("Yes or no? Please enter y/n: ");
        //Console.WriteLine();

    }
    public void FillPow()
    {
        try
        {
            Console.Write("Please enter a number: ");
            string? valueNumber = Console.ReadLine();
            if (!String.IsNullOrEmpty(valueNumber)) number = Convert.ToInt32(valueNumber.ToString());

            Console.Write("Please enter a degree: ");
            string? valuePow = Console.ReadLine();
            if (!String.IsNullOrEmpty(valuePow)) pow = Convert.ToInt32(valuePow.ToString());
        }
        catch
        {
            Console.WriteLine("You must enter a digit!");
            Console.WriteLine("Erroneous input is taken as zero.");
        }
    }

    public void PrintPow()
    {
        result = Pow();
        Console.WriteLine($"{number} to {pow} degree is {result}");
        number = 0;
        pow = 0;
        result = 1;
    }
}