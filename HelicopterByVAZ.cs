using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ZamanovTaskOne
{
    class HelicopterByVAZ : AbsHelicopter, IHelicopter
    {
        //readonly brim
        public readonly string name = "HelicopterByVAZ";
        //private brim
        private readonly string TopSecret = "The helicopter is not awesome!!!";
        //protected brim
        protected readonly string ForNextGeneration = "The AutoVAZ factory needs in new engineers. Please make something for this...";

        //constructors

        //default constructor
        public HelicopterByVAZ() : base()
        {
        }

        //instance constructor
        public HelicopterByVAZ(string model, double capacity, double power, uint fuel) : base(model, capacity, power, fuel)
        {
        }

        //copy constructor
        public HelicopterByVAZ(HelicopterByVAZ CopyItem)
        {
            Model = CopyItem.Model;
            LoadCapacity = CopyItem.LoadCapacity;
            Power = CopyItem.Power;
            Fuel = CopyItem.Fuel;
        }

        //Properties
        protected override double LoadCapacity { set; get; } = 10;
        protected override uint Fuel { set; get; } = 30;
        protected override string Model { set; get; } = "Карбюраторный вертолёт с двигателем от жигулей";
        protected override double Power { set; get; } = 8;

        public void Landing()
        {
            Console.WriteLine("Мы падаем, просьба сохранять патриотизм...");
            Thread.Sleep(2000);

            Random rnd = new Random();
            int result = rnd.Next(10);

            if (result % 2 == 0)
            {
                Console.WriteLine("Падение пришлось на курятник, пострадал не один десяток яиц");
            }
            else
            {
                Console.WriteLine("Замечательная посадка!");
            }

            Thread.Sleep(2000);

        }
        public void ToFly()
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
        
        //Destructor(finalizator)
        ~HelicopterByVAZ()
        {
            Console.WriteLine("Destructor is called!!!");
            LoadCapacity = 0;
            Fuel = 0;
            Model = "";
            Power = 0;
        }

        public void Information()
        {
            Console.WriteLine(TopSecret);
            Console.WriteLine(ForNextGeneration);
            Console.WriteLine(name);

            Console.WriteLine("Model = {0}", Model);
            Console.WriteLine("Power = {0}",Power);
            Console.WriteLine("LoadCapacity = {0}",LoadCapacity);
            Console.WriteLine("Fuel = {0}",Fuel);
        }
    }
}
