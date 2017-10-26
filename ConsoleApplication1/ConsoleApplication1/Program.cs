using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonHandler personHandler0 = new PersonHandler();
           // Person person1 = new Person();

            Console.Write("Enter Age: ");
            int inputForAge = Int32.Parse(Console.ReadLine());
            //personHandler0.SetAge(pers, inputForAge);
            personHandler0.CreatePerson = Int32.Parse(Console.ReadLine());
            Console.Write("Enter First Name: ");
            string inputFirstName = Console.ReadLine();
            personHandler0.SetFName(person1, inputFirstName);

            Console.Write("Enter Last Name: ");
            var inputLastName = Console.ReadLine();
            personHandler0.SetLName(person1, inputLastName);

            Console.Write("Enter Weight: ");
            var inputWeight = double.Parse(Console.ReadLine());
            personHandler0.SetWeight(person1, inputWeight);

            Console.Write("Enter Height: ");
            var inputHeight = double.Parse(Console.ReadLine());
            personHandler0.SetHeight(person1, inputHeight);



            Console.WriteLine(person1.Age);
            Console.WriteLine(person1.FName);
            Console.WriteLine(person1.LName);
            Console.WriteLine(person1.Weight);
            Console.WriteLine(person1.Height);
        }
    }
}

//i could not do it without help and that means tht i need more knoledge
