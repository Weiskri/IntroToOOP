using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        private string hairLength;
        private int height;
        private string runningSpeed;
        private double weight;
        private string disposition;

        public string Disposition
        {
            get { return this.disposition; }
            set { this.disposition = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

       public Dog()
        {

        }

        public Dog (string hairLength, int height, string runningSpeed, double weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        public void Run()
        {
            runningSpeed = "is slow";
        }

        public void Bark()
        {
            Console.WriteLine("\a");
        }

        public void Potty()
        {
            weight--;
        }

        public void Cuddle()
        {
            disposition = "happy";
            Console.WriteLine("The dog is " + disposition);
        }
    }
}
