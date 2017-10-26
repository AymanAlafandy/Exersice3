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
            PersonHandler personHandler = new PersonHandler();
            Person person = new Person();

            Console.Write("Enter Age: ");
            int inputForAge = Int32.Parse(Console.ReadLine());
            personHandler.SetAge(person, inputForAge);

            Console.Write("Enter First Name: ");
            string inputFirstName = Console.ReadLine();
            personHandler.SetFName(person, inputFirstName);

            Console.Write("Enter Last Name: ");
            var inputLastName = Console.ReadLine();
            personHandler.SetLName(person, inputLastName);

            Console.Write("Enter Weight: ");
            var inputWeight = double.Parse(Console.ReadLine());
            personHandler.SetWeight(person, inputWeight);

            Console.Write("Enter Height: ");
            var inputHeight = double.Parse(Console.ReadLine());
            personHandler.SetHeight(person, inputHeight);



            Console.WriteLine(person.Age);
            Console.WriteLine(person.FName);
            Console.WriteLine(person.LName);
            Console.WriteLine(person.Weight);
            Console.WriteLine(person.Height);
        }
    }
}

//i could not do it without help and that means tht i need more knoledge
