using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
           int[,] myArray = new int[5, 6];
            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);
            for (int y = 0;y < height; y++)
            {
                for (int x = 0;x< width; x++)
                {
                    Console.Write(myArray [y,x] + " ");
                }
                Console.WriteLine();
            }
                         
        Console.ReadKey();
        }
    }
}
