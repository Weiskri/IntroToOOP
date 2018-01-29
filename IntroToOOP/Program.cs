using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Mr.Fuzzy";

            Cat secondCat = new Cat("Midnight", 14, "black");

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);

            firstCat.Eat(); // calling the eat method on the first cat object

            secondCat.Meow();

            firstCat.HairLength = "nice and short";
            secondCat.HairLength = "too long";
            Console.WriteLine(firstCat.Hairball());
            Console.WriteLine(secondCat.Hairball());

            //Console.WriteLine("Here are the characteristics of the dog:");
            //Dog firstDog = new Dog();
            //firstDog.Weight = 20;
            //firstDog.Disposition = "sad";
            //Console.WriteLine("The dog was " + firstDog.Disposition);
            //firstDog.Cuddle();
            //firstDog.Bark();
            //firstDog.Potty();
            //Console.WriteLine(firstDog.Weight);
            //firstDog.Run();
            //Console.WriteLine("The dog " + firstDog.RunningSpeed);
        }
    }

}
