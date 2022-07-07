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

            Console.WriteLine($"The computer created an array with a length of {Resolution.sizeOfArray}:");

            resolution.PrintGotArray();
            Resolution.Power = 2;
            resolution.GetArrayInPower();

            Console.WriteLine($"Array of elements in degree {Resolution.power}");

            resolution.PrintGotArray();
            Console.WriteLine();


        }
    }

    class Resolution
    {
        private static int[] array = new int[0];
        public static int sizeOfArray;
        public static int power;
        public static int Power
        {
            get
            {
                return power;
            }
            set
            {
                if (value > 0)
                {
                    power = value;
                }
                else
                {
                    Console.WriteLine("Input is incorrect!");
                }
            }
        }
        public int[] GetRandomArray(byte minSize, byte maxSize, int MinValue, int MaxValue)
        {
            sizeOfArray = new Random().Next(minSize, maxSize);
            Array.Resize(ref array, sizeOfArray);
            for (int i = 0; i < sizeOfArray; i++)
            {
                array[i] = new Random().Next(MinValue, MaxValue);
            }
            return array;
        }

        public int[] GetArrayInPower(/*int power*/)
        {

            for (int i = 0; i < sizeOfArray; i++)
            {
                int temp = 1;
                //System.Math.Pow(array[i], power);
                for (int j = 0; j < power; j++)
                {
                    temp *= array[i];
                }
                array[i] = temp;
            }
            //Power = power;
            return array;
        }

        public void PrintGotArray()
        {
            if (sizeOfArray >= 3)
            {
                Console.Write($"[{array[0]},");
                for (int i = 1; i < sizeOfArray - 1; i++)
                {
                    Console.Write($" {array[i]},");
                }
                Console.WriteLine($" {array[sizeOfArray - 1]}]");
            }
            else if (sizeOfArray == 2)
            {
                Console.WriteLine($"[{array[0]}, {array[1]}]");
            }
            else if (sizeOfArray == 1)
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