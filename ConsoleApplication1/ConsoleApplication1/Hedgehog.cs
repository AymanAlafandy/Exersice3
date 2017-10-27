using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Hedgehog: Animal
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
        public override string Stats()
        {
            return base.Stats();
        }
    }
}
