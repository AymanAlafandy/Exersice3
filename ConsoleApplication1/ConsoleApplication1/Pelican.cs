using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Pelican:Bird
    {
        private string beak;
        private float leglenght;

        public string Beak
        {
            get
            {
                return beak;
            }
            set
            {
                beak = value;
            }
        }
        public float Leglenght
        {
            get
            {
                return leglenght;
            }
            set
            {
                leglenght = value;
            }
        }
    }
}
