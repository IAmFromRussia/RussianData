using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZamanovTaskOne
{
    class Experiment
    {
       public async void FlyAsync()
        {
            Console.WriteLine("Async method is srarting");
            await Task.Run(() => WhyHelicopterIsFly());
            Console.WriteLine("Async method was ended");
        }

        public static void WhyHelicopterIsFly()
        {
            Console.WriteLine("Yes, you helicopter is flying now");
            Thread.Sleep(10000);
            Console.WriteLine("You helicopter was landing successfully");
        }

        public void Fly()
        {
            for (uint i = 0; i <= 4; i++)
            {
                Console.WriteLine("Охренеть! Летим!");
                Thread.Sleep(200);
                Console.Clear();

                Console.WriteLine("Охренеть! Летим!.");
                Thread.Sleep(200);
                Console.Clear();

                Console.WriteLine("Охренеть! Летим!..");
                Thread.Sleep(200);
                Console.Clear();

                Console.WriteLine("Охренеть! Летим!...");
                Thread.Sleep(200);
                Console.Clear();
            }
        }

    }
}
