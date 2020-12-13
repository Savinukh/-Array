using System;
using System.Linq;
using System.Text;

namespace Array
{
    class Program
    {
        static int height = 0;
        static int width = 0;
       
        static void Main()
        {
            int[,] myArray = new int[width, height];
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nВведите кол-во элементов в строке:\t");
            height = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во элементов в строке:\t");
            width = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();
            RandomMyArray(out myArray, width, height);
            ShowUp1(myArray);
            Console.ReadKey();
        }
        static void RandomMyArray(out int[,] array, int width, int height)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------------------------------------");
            Console.ResetColor();
            array = new int[width, height];
            Random ran = new Random();
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    array[y, x] = ran.Next(0, 10);
                }
            }
            ShowUp(array);

            var list = array.Cast<int>().ToList();
            list.Sort();
            int Part = 0;
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    array[y, x] = list[Part];
                    Part++;
                }
            }
            ShowUp(array);
        }
        static void ShowUp(int[,] array)
        {
            Console.WriteLine();
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    Console.Write(array[y, x] + " ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n--------------------------------------------");
            Console.ResetColor();
        }
       static void ShowUp1(int[,] array)
        {
            Console.WriteLine();
            var list = array.Cast<int>().ToList();
            list.Reverse();
            int Part = 0;
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    array[y, x] = list[Part];
                    Part++;
                }
            }
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    Console.Write(array[y, x] + " ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n--------------------------------------------");
            Console.ResetColor();
       }

    }



}
