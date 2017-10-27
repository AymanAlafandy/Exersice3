using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class PersonHandler
    {
       
        public void SetAge(Person pers, int age)
        {
            pers.Age=age;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person();
            person.LName = lname;
            person.FName = fname;
            person.Age = age; 
            person.Height = height;
            person.Weight = weight;
            return person;
        }

        //private List<Person> list = new List<Person>();
        //public void AddPerson(Person person)
        //{
        //    list.AddPerson(person);
        //}
        //public void(List)()
        //{
        //    foreach (var person in list)
	       // {
        //    Console.WriteLine(person);
	       // }
        //}
        //public override string ToString()
        //{
        //    var result = "";
        //    foreach (var person in list)
	       // {
        //     result += person + "\n";
        //    }
        //return result;

	    }
    }

