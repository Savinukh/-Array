using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во цифр в строку:\t");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во цифр в столбец:\t");
            int width = int.Parse(Console.ReadLine());
            int[,] myArray = new int[height, width];
            Random ran = new Random();
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    myArray[y, x] = ran.Next(10);
                }
            }
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y,x] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
