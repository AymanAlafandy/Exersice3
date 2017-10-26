using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Animal
    {
        private string name;
        private string color;
        private double weight;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public Animal()
        {

        }
        public Animal(string nam, string col, double wei, int age)
        {
            Name = nam;
            Color = col;
            Weight = wei;
            Age = age;
        }

        public virtual string Stats()
        {
            return "Your name is " + Name + "\nYour color is " + Color +
                   "\nYour weight is " + Weight + "nYour age is" + Age + ".";
        }
        //Animal anim = new Animal ("Buby", "red", 3,89, 3);

        //3.2) Q 8. Bird
        //3.2) Q 9. Animal
    }
}
