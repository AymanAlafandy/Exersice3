using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Hourse : Animal
    {
        //field
        private int strength;
        private float length;

        //prop
        public int Strength
        {
            set
            {
                strength = value;
            }
            get
            {
                return strength;
            }
        }
        //
        public float Length
        {
            set
            {
                length = value;
            }
            get
            {
                return length;
            }
        }
    }
}
