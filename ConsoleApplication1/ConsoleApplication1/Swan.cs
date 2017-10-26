using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Swan : Bird
    {
        //field
        private string sbeauty;
        private float length;

        //prop
        public string SBeauty
        {
            set
            {
                sbeauty = value;
            }
            get
            {
                return sbeauty;
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
