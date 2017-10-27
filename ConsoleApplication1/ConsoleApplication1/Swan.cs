using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Swan:Bird
    {
        private string sbeauty;
        private float lenght;

        public string Sbeauty
        {
            get
            {
                return sbeauty;
            }
            set
            {
                sbeauty = value;
            }
        }
        public float Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                lenght = value;
            }
        }

    }
}
