using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class PersonHandler
    {
        Person person = new Person();


        public Person CreatePerson(int age , string fName,
            string lName, double height , double Weight)
        {
            return new Person(); //i get a help.
        }



        //
        public void SetAge(Person pers ,int age)
        {
            pers.Age = age;
        }
        public void SetFName(Person pers, string fName)
        {
            pers.FName = fName;
        }
        public void SetLName(Person pers, string lName )
        {
            pers.LName = lName;
        }
        public void SetHeight(Person pers, double height )
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight )
        {
            pers.Weight = weight;
        }



    }
}
