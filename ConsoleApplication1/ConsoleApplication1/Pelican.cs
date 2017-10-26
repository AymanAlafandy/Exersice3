using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pelican : Bird
    {
        private string beak;

        //prop
        public string Beak
        {
            set
            {
                beak = value;
            }
            get
            {
                return beak;
            }
        }
    }
}
