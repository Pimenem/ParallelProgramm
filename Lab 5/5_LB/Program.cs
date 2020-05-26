using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _5_LB
{
    class Program
    {

        static async Task<int[]> ArrayAsync(int q)
        {
            int[] array = new int[q];
            Console.WriteLine("Вызов метода ArrayAsync"); 
            await Task.Run(() => { for (int i = 0; i < q; i++) { array[i] = i; } });             
            Console.WriteLine("Завершение работы метода ArrayAsync");
            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое ПОЛОЖИТЕЛЬНОЕ число и нажмите Enter: ");
            int q = Int32.Parse(Console.ReadLine());
           
            Task<int[]> t = ArrayAsync(q);  
            t.Wait();
            Console.WriteLine("Полученный массив:");
            Console.WriteLine(string.Join(",", t.Result));
            Console.ReadLine();
        }
    }
}

