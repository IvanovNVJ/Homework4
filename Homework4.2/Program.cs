using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._2
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите длинну последовательности:");
                int array_length = int.Parse(Console.ReadLine());
                    int[] array = new int[array_length];
                    if (array_length > 0)
                    {
                        for (int i = 0; i < array_length; i++)
                        {
                            Console.WriteLine("Введите следующее число последовательности");
                            array[i] = int.Parse(Console.ReadLine());

                        }
                        Array.Sort(array);
                        Console.WriteLine($"Наименьшее число последовательности: {array[0]}");
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
