using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Dog:Animal
    {
        private string smell;
        private float intelligence;

        public string Smell
        {
            get
            {
                return smell;
            }
            set
            {
                smell = value;
            }
        }
        public float Intelligence
        {
            get
            {
                return intelligence;
            }
            set
            {
                intelligence = value;
            }
        }

    }
}
