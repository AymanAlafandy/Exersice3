using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Hedgehog
    {
        private int noOfSpikes;
        private float spead;

        public int NoOfSpikes
        {
            get
            {
                return noOfSpikes;
            }
            set
            {
                noOfSpikes = value;
            }
        }
        public float Spead
        {
            get
            {
                return spead;
            }
            set
            {
                spead = value;
            }
        }
    }
}
