using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal //Classes & Objects
    {
        public string name;
        public string sound;
        static int numOfAnimals = 0;

        public Animal() //Constructor: Initialized Values
        {
            name = "No Name";
            sound = "No sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name")
        {
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name", string sound = "No Sound")
        {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        public void MakeSound() //Method
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }


    }
}
