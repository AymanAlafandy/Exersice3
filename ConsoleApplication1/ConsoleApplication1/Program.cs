using ConsoleApplication1; // Ayman
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
            string Age = Console.ReadLine();
            int age0 = 0;
            if (!int.TryParse(Age, out age0))
            {
                Console.WriteLine("Age? Age could not be parsed");
            }
            Console.Write("Height: ");
            string Height = Console.ReadLine();
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

            Console.WriteLine("Hi, " + " " + FName + " " + LName + ", Age" + age0 + ", Height" + height0 + ", Weight" + weight0);
            Console.ReadLine();
            Animal animal0 = new Animal();
            Add(animal0);
            Animal dog0 = new Dog();
            Add(dog0);
            UserError error0 = new UserError();
            Add(error0);
        }

        //3.3) 3.
        List<Animal> Animals = new List<Animal>();
        //3.3) 4.
      
        public static void Add (Animal animal)
            {
             List<Animal> Animals = new List<Animal>();
            Animals.Add(animal);
            Console.WriteLine(Animals[0]);
            Console.WriteLine(Animals[1]);
            
            //3.3) 5.
           
                foreach (var anim in Animals)
                {
                Console.WriteLine(anim.Stats());
                }

            }
            
 }           //  3.3) 6.
            //Animal dog = new Dog();
            List<Animal> Anim = new List<Animal>();

            public static void Add(Animal animal)
            {
            List<Animal> Anim = new List<Animal>();
            Anim.add(dog);
            Console.WriteLine(Anim[0]);
            Console.WriteLine(Anim[1]);

            foreach (Animal anima in animals)
            {
              Console.WriteLine(anima.Stats());
            
            //public  void Add(Dogs dog)
            //{
            //    Dog.Add(dog);
            }
        //  3.3) Q 7.It is not working because Horse and Dog are different objects/subclasses and both of them are children      
        //  3.3) Q 8. The List must be Animal type to accept all animals.   
        //  3.3)  9.

        //  3.3)  10.

        //  3.3)  11.

        //  3.3)  12.

        //  3.3)  13.

        //  3.4)  7.
        List<UserError> Errors = new List<UserError>();
        //3.3) 4.

        public static void Add(UserError error)
        {
        List<UserError> Errors = new List<UserError>();
        Errors.Add(error);
        Console.WriteLine(Errors[0]);
        Console.WriteLine(Errors[1]);

        //  3.4)  8.
        foreach (UserError uerror in Errors)
        {
            Console.WriteLine(uerror.UEMessage());
        }

            //  3.4)  Q 11. Polymorphism is important for:
            // avoiding repetition and very long cod
            // ahving structure
            //  3.4)  Q 12. Polymorphism can be used to write a  cleaner and better code by using virtual and override
            //  3.4)  Q 13. The difference is that 
            //an abstract class is just a template use a generic form and
            // an interface
        }


    }
