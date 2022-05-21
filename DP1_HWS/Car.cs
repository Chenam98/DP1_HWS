using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_HWS
{
    public class Car
    {
        public bool isFixed;
        public string Model { get; set; }

        public Car(string model, bool isFixed)
        {
            this.isFixed = isFixed;
            Model = model;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

}
