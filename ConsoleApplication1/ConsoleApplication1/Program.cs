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

            AddPerson();
        }
            private static void AddPerson()
            {
            //Person person = new Person();
            Console.Write("FName: ");
            var FName = Console.ReadLine();
            if (string.IsNullOrEmpty(FName))
            {
               // return false;
            }
            Console.Write("LName: "); 
            var LName = Console.ReadLine();
            if (string.IsNullOrEmpty(LName))
            {
              //  return false;
            }
            Console.Write("Age: ");
            string Age=Console.ReadLine();
            int age0 = 0;
            if (!int.TryParse(Age, out age0))
            {
                Console.WriteLine("Age? Age could not be parsed");
            }
            Console.Write("Height: ");
            string Height =Console.ReadLine();
            double height0 = 0;
            if (!double.TryParse(Height, out height0))
            {
                Console.WriteLine("Height? Height could not be parsed");
            }
            Console.Write("Weight: ");
            string Weight = Console.ReadLine();
            double weight0 = 0;
            if (!double.TryParse(Weight, out weight0))
            {
                Console.WriteLine("Weight? Weight could not be parsed");
            }

            PersonHandler pershand = new PersonHandler();
            pershand.CreatePerson(age0, FName, LName, height0, weight0);
          
            Console.WriteLine("HI" + " "+ FName + " " + LName + ", Age" + age0 + ", Height" + height0 + ", Weight" + weight0);
            Console.ReadLine();
             
        }
    }
}
