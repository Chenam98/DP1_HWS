using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_HWS
{
    public abstract class GarageHandler
    {
        protected GarageHandler next;

        public void NextCheck(GarageHandler next)
        {
            this.next = next;
        }

        public abstract void GarageCarHandler(Car car);
    }
}