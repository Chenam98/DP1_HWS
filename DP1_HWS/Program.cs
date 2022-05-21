using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_HWS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Singleton Clock EXR

            Console.WriteLine("Clock EXR : ");
            Console.WriteLine();

            Clock clock1 = Clock.GetTime();
            Clock clock2 = Clock.GetTime();

            if (clock1 == clock2)
            {
                Console.WriteLine("Clock works!");
                Console.WriteLine();
                Console.WriteLine("right now the time is : ");
                Console.WriteLine();
                Console.WriteLine(DateTime.Now.TimeOfDay.ToString()); 
            }
            else
            {
                Console.WriteLine("Ooops .... try again ...");
            }
            #endregion

            #region Chain Of Responsabillity Car EXR

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Car EXR : ");
            Console.WriteLine();
            

            Car c1 = new Car("Suzuki", true);
            Car c2 = new Car("Mazda", true);
            Car c3 = new Car("Kia", true);
            Car c4 = new Car("Tesla", false);
           

            GarageHandler firstCheck = new FirstCheck();
            GarageHandler mechanicCheck = new MechanicHandler();
            GarageHandler electricCheck = new ElectricCheck();
            GarageHandler afterChecks = new ElectricCheck();

            firstCheck.NextCheck(mechanicCheck);
            mechanicCheck.NextCheck(electricCheck);
            electricCheck.NextCheck(afterChecks);
            afterChecks.NextCheck(null);

            firstCheck.GarageCarHandler(c1);
            mechanicCheck.GarageCarHandler(c2);
            electricCheck.GarageCarHandler(c3);
            afterChecks.GarageCarHandler(c4);

            #endregion

            #region Factory Method Diet EXR

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Diet EXR : ");
            Console.WriteLine();



            #endregion

        }
    }
}
