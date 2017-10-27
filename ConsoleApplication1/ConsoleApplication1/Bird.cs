using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Bird:Animal
    {
        private float wingspan;
        private float flyspeed;

        public float Wingspan
        {
            get
            {
                return wingspan;
            }
            set
            {
                wingspan = value;
            }
        }
        public float Flyspeed
        {
            get
            {
                return flyspeed;
            }
            set
            {
                flyspeed = value;
            }
        }
        public override string Stats()
        {
            return base.Stats();
        }
    }
}
