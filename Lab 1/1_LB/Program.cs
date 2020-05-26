using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_LB
{
    class Program
    {
        static int Calculation(int x)
        {        
            int result = (x + 5) * 2;            
            return result;
        } 

        static void Main(string[] args)
        {       
            List<int> mas = new List<int>();
            for (int i = 1; i < 10; i++)
            {
                mas.Add(i);
            }
            mas.AsParallel().ForAll(x =>
            {
                Console.WriteLine(
                    $"Номер потока - {Thread.CurrentThread.ManagedThreadId} \tВычисление - ({x} + 5) * 2 = {(x + 5) * 2}");
            });

            var resylt = from x in mas.AsParallel()
                         select Calculation(x);
            Console.WriteLine("Возвращаем результат в порядке возрастания: ");
           List<int> mas2 = resylt.ToList();
            foreach (var x in mas2)

                Console.WriteLine($"{x}");
            Console.ReadLine();
        }
        
     }
    
}
