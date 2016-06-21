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
            Console.WriteLine("My animal is a: " + A.Species);
            Console.WriteLine("My animal is covered with: " + A.ExternalCovering);

            Mammal P;
            P = new Mammal(1);
            Console.WriteLine("My Mammal has " + P.AvgNumOffspring + " average number of offspring.");

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
            private string _IsDessertDweller;

            public Lizard()
            {
            }
            public Lizard(string _IsDessertDweller)
            {
                IsDessertDweller = _IsDessertDweller;
            }

            public string IsDessertDweller
            {
                get
                {
                    return _IsDessertDweller;
                }
                set
                {
                    _IsDessertDweller = value;
                }
            }
        }
    }
}
