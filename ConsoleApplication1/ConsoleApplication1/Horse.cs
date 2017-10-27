using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Horse:Animal
    {
        private int strenght;
        private float length;

        public int Strenght
        {
            get
            {
                return strenght;
            }
            set
            {
                strenght = value;
            }
        }
        public float Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        public override string Stats()
        {
            return base.Stats();
        }
    }
}
