using System;

namespace Array
{
    class Program
    {
        static int height = 0;
        static int width = 0;
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------------------------------------");
            Console.ResetColor();
            Console.Write("\nВведите кол-во цифр в строку:\t");
            height = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во цифр в столбец:\t");
            width = int.Parse(Console.ReadLine());
            Console.WriteLine();
            RandommyArray();
            SortingmyArrayIncrease();



        }
        static void RandommyArray()
        {
            int[,] myArray = new int[height, width];
            Random ran = new Random();
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    myArray[y, x] = ran.Next(0, 10);
                }
            }
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y, x] + " ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n--------------------------------------------");
            Console.ResetColor();

        }
        static void SortingmyArrayIncrease()
        {

        }

        
    }
}
