// Задача 29: Напишите программу, которая задаёт случайный массив случайного размера элементов и 
// выводит на экран массив квадратов этих чисел.

// 1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]

// 6, 1, 33 -> [36, 1, 1089]

namespace Seminar4
{
    class Task29
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Resolution resolution = new Resolution();
            resolution.GetRandomArray(5, 10, 1, 41);

            Console.WriteLine($"The computer created an array with a length of {Resolution.SizeOfArray}:");

            resolution.PrintGotArray();
            resolution.GetArrayInPower(2);

            Console.WriteLine($"Array of elements in degree {Resolution.Power}");

            resolution.PrintGotArray();
            Console.WriteLine();


        }
    }

    class Resolution
    {
        private static int[] array = new int[0];
        public static int SizeOfArray;
        public static int Power;
        public int[] GetRandomArray(byte minSize, byte maxSize, int MinValue, int MaxValue)
        {
            SizeOfArray = new Random().Next(minSize, maxSize);
            Array.Resize(ref array, SizeOfArray);
            for (int i = 0; i < SizeOfArray; i++)
            {
                array[i] = new Random().Next(MinValue, MaxValue);
            }
            return array;
        }

        public int[] GetArrayInPower(int power)
        {

            for (int i = 0; i < SizeOfArray; i++)
            {
                int temp = 1;
                //System.Math.Pow(array[i], power);
                for (int j = 0; j < power; j++)
                {
                    temp *= array[i];
                }
                array[i] = temp;
                temp = 1;
            }
            Power = power;
            return array;
        }

        public void PrintGotArray()
        {
            if (SizeOfArray >= 3)
            {
                Console.Write($"[{array[0]},");
                for (int i = 1; i < SizeOfArray - 2; i++)
                {
                    Console.Write($" {array[i]},");
                }
                Console.WriteLine($" {array[SizeOfArray - 1]}]");
            }
            else if (SizeOfArray == 2)
            {
                Console.WriteLine($"[{array[0]}, {array[1]}]");
            }
            else if (SizeOfArray == 1)
            {
                Console.WriteLine($"[{array[0]}]");
            }
            else
            {
                Console.WriteLine("Sorry, but the pc didnt create an array.");
            }
        }
    }
}