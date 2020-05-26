using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _3_LB
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokenSource = new CancellationTokenSource();
            var tokenSr = tokenSource.Token;

            Task task = new Task(() => Tok(tokenSr));
            task.Start();
            Thread.Sleep(1000);

            Console.WriteLine("Нажмите Enter, чтобы прервать задачу...");
            Console.ReadKey();
            tokenSource.Cancel();
            Console.ReadLine();
        }

        static void Tok(CancellationToken tokenSr)
        {
            while (!tokenSr.IsCancellationRequested) ;
            Console.WriteLine("Прерывание прошло успешно!");

        }
    }
    
}
