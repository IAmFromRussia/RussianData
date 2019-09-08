using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ZamanovTaskOne
{
    class CitizenHelicopter : AbsHelicopter, IHelicopter
    {
        //readonly brim
        public readonly string name = "CitizenHelicopter";

        //constructors

        //default contructor
        public CitizenHelicopter():base()
        {
        }

        //instance constructor
        public CitizenHelicopter(string model, double capacity, double power, uint fuel) : base(model, capacity, power, fuel)
        {
        }

        //copy constructor
        public CitizenHelicopter(CitizenHelicopter CopyItem)
        {
            Model = CopyItem.Model;
            LoadCapacity = CopyItem.LoadCapacity;
            Power = CopyItem.Power;
            Fuel = CopyItem.Fuel;
        }

        //Properties
        protected override double LoadCapacity { set; get; } = 30;
        protected override uint Fuel { set; get; } = 10;
        protected override string Model { set; get; } = "Sukhoi superjet 100";
        protected override double Power { set; get; } = 20;

        public void Landing()
        {
            Console.WriteLine("Вертолёт идёт на посадку, советуем пристегнуть ремни...");
            Thread.Sleep(2000);

            Random rnd = new Random();
            int result = rnd.Next(10);

            if (result%2==0)
            {
                Console.WriteLine("долбаный ssj100!!!");
            }
            else
            {
                Console.WriteLine("Замечательная посадка!");
            }

            Thread.Sleep(2000);
        }


        public void ToFly()
        {
            for (int i = 0; i <= 4; i++)
            {
                    Console.WriteLine("Летим");
                Thread.Sleep(200);
                    Console.Clear();

                    Console.WriteLine("Летим.");
                Thread.Sleep(200);
                    Console.Clear();

                    Console.WriteLine("Летим..");
                Thread.Sleep(200);
                    Console.Clear();

                    Console.WriteLine("Летим...");
                Thread.Sleep(200);
                    Console.Clear();

                //Toilet();
            }
        }
        
        public async void ToFlyAsync()
        {
            Console.WriteLine("While the helicopter is flying...");
            await Task.Run(() => ToFly());
            Console.WriteLine("The story is end=)");
        }

        //Toilet - static method, it's relized a small story about passenger
        public void Toilet()
        {
            Console.WriteLine("Oh my God! Where is toilet?");

            //randomizer fo Parachute
            Random randomizer = new Random();
            int happening = randomizer.Next(200);

            OpenTheDoor();

            if (happening % 2==0)
            {
                Console.WriteLine("Toilet is busy..");
                Parachute();
            }
            else
            {
                Console.WriteLine("Fuf, it was not so easy...");
            }

            Console.ReadKey();
            //Thread.Sleep(8000);

            //local methods
            void OpenTheDoor() => Console.WriteLine("Door is open");
            void Parachute() => Console.WriteLine("Pilot was angry, he said, that you must coming out with parachute...");

        }

        //Destructor(finalizator)
        ~CitizenHelicopter()
        {
            LoadCapacity = 0;
            Fuel = 0;
            Model = "";
            Power = 0;
        }
    }
}
