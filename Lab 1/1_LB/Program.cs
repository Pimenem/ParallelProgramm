using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _1_LB
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            bool on = true;
            while (on)
            {
                Console.WriteLine("Введите число для суммирования:");

                var input = Console.ReadLine();
                try
                {
                    number = Convert.ToInt32(input);
                    on = false;
                }
                catch { }
            }

            var thread = new Thread(x =>
            {
                int ResSum = 0;

                if (number > 0)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        ResSum += i;
                        Console.WriteLine("число: " + i + " результат суммирования с предудущим: " + ResSum);
                    }
                }
                else
                {
                    for (int i = number; i < 0; i++)
                    {
                        ResSum += i;
                        Console.WriteLine("число: " + i + " результат суммирования с предудущим: " + ResSum);
                    }
                }

                Console.WriteLine("Конечное суммирование: - " + ResSum);
            });
            thread.Start();
            Console.ReadLine();
        }
    }
}
