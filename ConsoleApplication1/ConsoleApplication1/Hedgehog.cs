using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Hedgehog : Animal
    {
        //field
        private int noOfSpikes;
        private float speed;

        //prop
        public int NoOfspikes
        {
            set
            {
                noOfSpikes = value;
            }
            get
            {
                return noOfSpikes;
            }
        }
        //
        public float Speed
        {
            set
            {
                speed = value;
            }
            get
            {
                return speed;
            }
        }
    }
}
