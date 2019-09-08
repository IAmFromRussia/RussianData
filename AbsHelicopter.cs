using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ZamanovTaskOne
{
    public abstract class AbsHelicopter
    {
        //readonly brim
        protected readonly uint yearOfIssue = 2019;
        //static brim
        protected const string feature = "This program was writing by Danila Permogorsky in ";

        //function of output for this brims
        public void ProgramInformation()
        {
            Console.Write(feature);
            Console.WriteLine(yearOfIssue);
        }

        public void End()
        {
            Console.WriteLine("Press any key to complete...");
        }


        protected virtual string Model { set; get; } 
        protected virtual double LoadCapacity { set; get; }
        protected virtual double Power { set; get; }
        protected virtual uint Fuel { set; get; }

        public AbsHelicopter (string model,double capacity, double power, uint fuel)
        {
            Model = model;
            LoadCapacity = capacity;
            Power = power;
            Fuel = fuel;
        }

        public AbsHelicopter()
        {
            Model = "";
            LoadCapacity = 0.0;
            Power = 0.0;
            Fuel = 0;
        }

        public void TankUp()
        {
            Console.WriteLine("Заправка...");
            Thread.Sleep(2000);
            Console.WriteLine("Вёртолёт заправлен");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
