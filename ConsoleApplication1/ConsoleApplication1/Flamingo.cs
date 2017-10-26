using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Flamingo : Bird
    {
        //fields
        private float height;
        public string gracious;

        //prop
        public float Height
        {
            set
            {
                height = value;
            }
            get
            {
                return height;
            }
        }
        //
        public string Gracious
        {
            set
            {
                gracious = value;
            }
            get
            {
                return gracious;
            }
        }
    }
}
