using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Bird : Animal
    {
        //fields
        private float wingSpan;
        private float flyingSpeed;

        //prop
        public float WingSpan
        {
            set
            {
                wingSpan = value;
            }
            get
            {
                return wingSpan;
            }
        }
        //
        public float FlyingSpeed
        {
            set
            {
                flyingSpeed = value;
            }
            get
            {
                return flyingSpeed;
            }
        }
    }
}
