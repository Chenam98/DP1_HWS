using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_HWS
{
    internal class Clock
    {
        private static Clock instance;

        private static readonly object key = new object();

        private Clock()
        {
          
        }

        public static Clock GetTime()
        {

            if (instance == null)
            {
                lock (key)
                {
                    if (instance == null)
                    {  
                        instance = new Clock();
                    }
                }
            }

            return instance;

        }
    }
}

