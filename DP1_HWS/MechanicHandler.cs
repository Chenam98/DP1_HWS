using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_HWS
{
    internal class MechanicHandler : GarageHandler
    {
        public override void GarageCarHandler(Car car)
        {
            Random random = new Random();
            int rnd = random.Next(1, 11);

            if (rnd >= 6)
            {
                Console.WriteLine("First Check passeed successfully");
                if (next != null)
                {
                    next.GarageCarHandler(car);
                }
                else
                    Console.WriteLine("Repearing....");
            }
        }
    }   
}
