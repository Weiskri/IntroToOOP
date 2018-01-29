using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Superhero
    {
        private bool hasCape;
        private int strengthLevel;
        private string secretIdentity;
        private string weakness;
        private string weapon;

        public int StrengthLevel
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }

        public string Weakness
        {
            get { return this.weakness; }
            set { this.weakness = value; }
        }

        public string SecretIdentity
        {
            get { return this.secretIdentity; }
            set { this.secretIdentity = value; }
        }
        
        public string Weapon
        {
            get { return this.Weapon; }
            set { this.weapon = value; }
        }

        public Superhero ()
        {
            // this is my empty constructor
        }
        public Superhero (string weapon, string secretIdentity)
        {
            this.weapon = weapon;
            this.secretIdentity = secretIdentity;
        }
        public Superhero (string weakness, bool hasCape)
        {
            this.weakness = weakness;
            this.hasCape = hasCape;
        }

        public string Health()
        {
           if (weakness == "very weak")
            {
                strengthLevel = 0;
                return ("The superhero's strength is " + strengthLevel);
            }
           else
            {
                return ("The superhero is strong.");
            }

        }

        public int Sleep()
        {
            strengthLevel++;
            return (strengthLevel);
        }
    }
}
