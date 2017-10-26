using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Dog : Animal
    {
        //field
        private string smell;
        private float intelligence;

        //prop
        public string Smell
        {
            set
            {
                smell = value;
            }
            get
            {
                return smell;
            }
        }
        //
        public float Intelligence
        {
            set
            {
                intelligence = value;
            }
            get
            {
                return intelligence;
            }
        }
    }
}
