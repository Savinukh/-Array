﻿using System;
using System.Linq;

namespace Array
{
    class Program
    {
        static int height = 0;
        static int width = 0;
        static int[,] myArray = new int[width, height];
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nВведите кол-во элементов в строке:\t");
            height = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во элементов в строке:\t");
            width = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();
            RandomMyArray();
            ShowUp1();
            Console.ReadKey();
        }
        static void RandomMyArray()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------------------------------------");
            Console.ResetColor();
            myArray = new int[width, height];
            Random ran = new Random();
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    myArray[y, x] = ran.Next(0, 10);
                }
            }
            ShowUp();

            var list = myArray.Cast<int>().ToList();
            list.Sort();
            int Part = 0;
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    myArray[y, x] = list[Part];
                    Part++;
                }
            }
            ShowUp();
        }
        static void ShowUp()
        {
            Console.WriteLine();
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
       static void ShowUp1()
        {
            Console.WriteLine();
            var list = myArray.Cast<int>().ToList();
            list.Reverse();
            int Part = 0;
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    myArray[y, x] = list[Part];
                    Part++;
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

    }



}
