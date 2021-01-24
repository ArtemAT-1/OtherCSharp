using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N (строки): ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Введите M (столбцы): ");
            int m = Int32.Parse(Console.ReadLine());

            int[,] myArr = new int[n+1, m+1];
            Console.Write("Массив:\n");
            Random ran = new Random();
            int min = 0;
            int ro = 0, c = 0;
            for (int i = 1; i < n+1; i++)
            {
                for (int j = 1; j < m+1; j++)
                {
                    myArr[i, j] = ran.Next(0, 9);
                    Console.Write("{0,5}", myArr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Координаты 0:");
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < m + 1; j++)
                {
                    if (myArr[i, j] <= 0)
                    {
                        min = myArr[i, j];
                        ro = i;
                        c = j;
                        Console.Write("({0}:{1})", ro, c);
                    }
                }
            }
            Console.ReadKey();
     
        }

    }
}
