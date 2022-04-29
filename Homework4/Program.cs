using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._1
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите кол-во строк матрицы");
                int Row = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во столбцов матрицы");
                int Col = int.Parse(Console.ReadLine());
                Random Gen = new Random();
                if (Row > 0 && Col > 0)
                {
                    int[,] M = new int[Row, Col];
                    int sum = 0;
                    for (int i = 0; i < Row; i++)
                    {
                        for (int j = 0; j < Col; j++)
                        {
                            M[i, j] = Gen.Next(-10, 10);
                            sum += M[i, j];
                            Console.Write($"{M[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"Сумма чисел матрицы:{sum} ");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Введено недопустимое значение");
                    continue;
                }
            }
        }
    }
}
