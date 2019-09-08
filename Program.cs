using System;

namespace ZamanovTaskOne
{
    class Program
    {
        static void RunProgram()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Gray;

            //ArmyHelicopter AHel = new ArmyHelicopter("Any called", 2, 3, 4);//instance constructor
            //Console.WriteLine(AHel.name);//readonly brim for this class

            ////methods
            //AHel.TankUp();
            //AHel.ToFly();
            //AHel.Landing();
            //Console.Clear();

            CitizenHelicopter CHel = new CitizenHelicopter();//default constructor
            CitizenHelicopter sec = new CitizenHelicopter(CHel);//copy constructor
            Console.WriteLine(sec.name);//readonly brim for this class

            //methods
            //CHel.TankUp();
            CHel.ToFlyAsync();
            CHel.Toilet();
            //CHel.Landing();
            Console.Clear();

            //HelicopterByVAZ VAZHel = new HelicopterByVAZ("MyHelicopter", 2, 3, 4);
            //Console.WriteLine(VAZHel.name);//readonly brim for this class

            //VAZHel.Information();

            ////methods
            //VAZHel.TankUp();
            //VAZHel.ToFly();
            //VAZHel.Landing();
            //Console.Clear();

            CHel.ProgramInformation();
            CHel.End();
        }



        static void Main()
        {
            RunProgram();
        }
    }
}
