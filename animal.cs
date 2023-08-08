using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Code0
{
    class Animal
    {
        private string name;
        private string sound;
        public static  int numOfAnimals = 0;
        static int numofsad = 0;
        public const string SHELTER = "Derek's home for animals";
        public readonly int idNum;

        public Animal() : this("no name,", "no sound") { }
        
        public Animal(string name) : this(name, "No sound") { }

        public Animal(string name, string sound)
        {
            Setnam(name);
            Sound = sound;

            NumOfAnimals = 1;
            Random rnd = new Random();
            idNum = rnd.Next(1, 2137548593);
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1} ", name, sound);
        }
        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }
       
        
        public void Setnam(string name)
        {
           if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
           else
            {
                this.name = "No Name";
                Console.WriteLine("Name can't contain nunbers");

            }
        }
        
        public string GetName()
        {
            return name;
        }
        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No sound";
                    Console.WriteLine("Sound is too long");
                } else
                {
                    sound = value;
                }
            }
        }
        public string Owner { get; set; } = "No Owner";

        public static int NumOfAnimals
        {
            get { return numOfAnimals;}
            set { numOfAnimals += value; }
        }
    }
}
