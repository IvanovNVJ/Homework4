using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._3
{
    internal class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Введите маскимальное число интервала");
            int max_value = int.Parse(Console.ReadLine());
            Random Gen = new Random();
            int value = Gen.Next(max_value);
            while (true)
            {
                Console.WriteLine("Введите число");
                try
                {
                    int users_value = int.Parse(Console.ReadLine());
                    if (users_value > 0)
                    {
                        if (users_value == value)
                        {
                            Console.WriteLine("Победа! Winner, winner, chicken dinner!");
                            Console.ReadKey();
                            break;

                        }
                        else if (users_value < value)
                        {
                            Console.WriteLine("Введенное значение меньше задуманного");
                            continue;
                        }
                        else 
                        {
                            Console.WriteLine("Введенное значение больше задуманного");
                            continue;
                        }
                    }
                }
                catch
                {
                    break;
                }
            }

                
                

            
        }
    }
}
