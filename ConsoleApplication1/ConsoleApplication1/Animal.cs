using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Animal
    {
        //Fields
        private string name;
        private double weight;
        private int age;
        private string color;

        //prop
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        //
        public double Weight
        {
            set
            {
                weight = value;
            }
            get
            {
                return weight;
            }

        }
        //
        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
        //
        public string Color
        {
            set
            {
                color = value;
            }
            get
            {
                return color;
            }
        }
        
        //constructor
        public Animal()
        {

        }
        //
        public Animal(string namePara, double weightPara,
            int agePara, string colorPara)
        {
            Animal anim = new Animal();
            Name = namePara;
            Weight = weightPara;
            Age = agePara;
            Color = colorPara;            
        }

        //method


    }
}
