using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Person
    {

        private int age;
        public int Age
        {           
            set { age = value; }
            get { return age; }
        }
        //
        private string fName;

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        //
        private string lName;
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        //
        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        //
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }


    }
}
