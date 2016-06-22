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

            Human Jim = new Human();
            Jim.Species = "Homosapian";
            Jim.ExternalCovering = "Skin";
            Jim.AvgNumOffspring = 5;
            Jim.HairColor = "dark";
            
            Console.WriteLine("Jim is a " + Jim.Species + ".");
            Console.WriteLine("His body is covered in " + Jim.ExternalCovering + ".");
            Console.WriteLine("Jim has " + Jim.AvgNumOffspring + " kids, which is more than the average number of offspring.");
            Console.WriteLine("Jim's hair is " + Jim.HairColor + ".");
            Console.WriteLine("Jim has " + Jim.NumLegs() + " legs");

            Dog Rover = new Dog();
            Rover.Breed = "Mutt";
            Rover.ExternalCovering = "Scruffy Fur";
            Rover.AvgNumOffspring = 6;
            Rover.Species = "Canis familiaris Linnaeus";

            Console.WriteLine("Rover is a " + Rover.Breed + " from the species " + Rover.Species + " with " + Rover.ExternalCovering + ".");
            Console.WriteLine("She once had a litter of " + Rover.AvgNumOffspring + " puppies.");

            Lizard Larry = new Lizard();
            Larry.IsDesertDweller = "desert dweller";
            Larry.AvgWeight = 220;
            Larry.ExternalCovering = "dry skin";
            Larry.Species = "Lounge Lizard";

            Console.WriteLine("Larry, of the species " + Larry.Species + " is a " + Larry.AvgWeight + " pound " + Larry.IsDesertDweller + " with " + Larry.ExternalCovering + ".");

            Snake Sam = new Snake();
            Sam.IsVenomous = "is venomous";
            Sam.AvgWeight = 12;
            Sam.ExternalCovering = "scales";
            Sam.Species = "King Sanke";

            Console.WriteLine("Sam is a " + Sam.IsVenomous + " " + Sam.Species + " covered with " + Sam.ExternalCovering + " weighing " + Sam.AvgWeight + " pounds.");

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
            Species = _Species;
            ExternalCovering = _ExternalCovering;
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
        public virtual int NumLegs()
        {
            return 4;
        }
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
    }
    public class Reptile : Animal
    {
        private int _AvgWeight;

        public Reptile()
        {
        }
        public Reptile(int _AvgWeight)
        {
            AvgWeight = _AvgWeight;
        }

        public int AvgWeight
        {
            get
            {
                return _AvgWeight;
            }
            set
            {
                _AvgWeight = value;
            }
        }
    }
    public class Human : Mammal
    {
        private string _HairColor;

        public Human()
        {
        }
        public Human(string _HairColor)
        {
            HairColor = _HairColor;
        }

        public string HairColor
        {
            get
            {
                return _HairColor;
            }
            set
            {
                _HairColor = value;
            }
        }
        public override int NumLegs()
        {
            return 2;
        }
    }
    public class Dog : Mammal
    {
        private string _Breed;

        public Dog()
        {
        }
        public Dog(string _Breed)
        {
            Breed = _Breed;
        }

        public string Breed
        {
            get
            {
                return _Breed;
            }
            set
            {
                _Breed = value;
            }
        }
    }
    public class Snake : Reptile
    {
        private string _IsVenomous;

        public Snake()
        {
        }
        public Snake(string _IsVenomous)
        {
            IsVenomous = _IsVenomous;
        }

        public string IsVenomous
        {
            get
            {
                return _IsVenomous;
            }
            set
            {
                _IsVenomous = value;
            }
        }
    }
    public class Lizard : Reptile
    {
        private string _IsDesertDweller;

        public Lizard()
        {
        }
        public Lizard(string _IsDesertDweller)
        {
            IsDesertDweller = _IsDesertDweller;
        }

        public string IsDesertDweller
        {
            get
            {
                return _IsDesertDweller;
            }
            set
            {
                _IsDesertDweller = value;
            }
        }
    }
}
