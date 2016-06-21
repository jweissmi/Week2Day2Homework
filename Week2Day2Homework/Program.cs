using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal A;
            A = new Animal("Cat", "Scales");
            //Type t = A.GetType();
            Console.WriteLine("My animal is a: " + A.Species);
            Console.WriteLine("My animal is covered with: " + A.ExternalCovering);

            Mammal P;
            P = new Mammal(1);
            //Type t = A.GetType();
            Console.WriteLine("My Mammal has " + P.AvgNumOffspring + " average number of offstring.");
          
            Console.ReadLine();

        }
    }
    public class Animal
    {
        private string _Species;
        private string _ExternalCovering;

        public Animal()
        {
        }
        public Animal(string _Species, string _ExternalCovering)
        {
            this.Species = _Species;
            this.ExternalCovering = _ExternalCovering;
        }

        public string Species
        {
            get
            {
                return _Species;
            }
            set
            {
                _Species = value;
            }
        }
        public string ExternalCovering
        {
            get
            {
                return _ExternalCovering;
            }
            set
            {
                _ExternalCovering = value;
            }
        }

        public virtual string GetDisplayText(string sep) =>
            Species + sep + ExternalCovering;

    }
    public class Mammal : Animal
    {
        private int _AvgNumOffspring;

        public Mammal()
        {
        }
        public Mammal(int _AvgNumOffspring)
        {
            AvgNumOffspring = _AvgNumOffspring;
        }

        public int AvgNumOffspring
        {
            get
            {
                return _AvgNumOffspring;
            }
            set
            {
                _AvgNumOffspring = value;
            }
        }
        public class Reptile : Animal
        {

        }
        public class Human : Mammal
        {

        }
        public class Dog : Mammal
        {

        }
        public class Snake : Reptile
        {

        }
        public class Lizard : Reptile
        {

        }
    }
}
