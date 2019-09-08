using System;
using System.Threading;

namespace ZamanovTaskOne
{
    class ArmyHelicopter : AbsHelicopter, IHelicopter
    {
        //readonly brim
        public readonly string name = "ArmyHelicopter";

        //constructors
        public ArmyHelicopter() : base()
        {
        }

        //instance costructor
        public ArmyHelicopter(string model, double capacity, double power, uint fuel) : base(model, capacity, power, fuel)
        {
        }

        //copy constructor
        public ArmyHelicopter(ArmyHelicopter CopyItem)
        {
            Model = CopyItem.Model;
            LoadCapacity = CopyItem.LoadCapacity;
            Power = CopyItem.Power;
            Fuel = CopyItem.Fuel;
        }

        //Properties

        protected override double LoadCapacity { set; get; } = 15;
        protected override uint Fuel { set; get; } = 100;
        protected override string Model { set; get; } = "Ми-8";
        protected override double Power { set; get; } = 100;
        public void Landing()
        {
            Console.WriteLine("Вертолёт идёт на посадку, советуем пристегнуть ремни...");
            Thread.Sleep(2000);

            Random rnd = new Random();
            int result = rnd.Next(10);

            if (result % 2 == 0)
            {
                Console.WriteLine("Посадочка выдалась так себе...Пилот! Ёб@@на в р@т!");
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
            }
        }


        //Destructor(finalizator)
        ~ArmyHelicopter()
        {
            LoadCapacity = 0;
            Fuel = 0;
            Model = "";
            Power = 0;
        }
    }
}
