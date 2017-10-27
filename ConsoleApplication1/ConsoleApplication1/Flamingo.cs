using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Flamingo:Bird
    {
        private string graciousness;
        private float height;

        public string Graciousness

        {
            get
            {
                return graciousness;
            }
            set
            {
                graciousness = value;
            }
        }
        public float Height
        { 
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

    }
}
