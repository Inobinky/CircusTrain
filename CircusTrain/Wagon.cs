using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public class Wagon
    {
        private int _capacity;
        private List<Animal> _animals;

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public Wagon()
        {
            Capacity = 10;
            _animals = _animals;
        }

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
            Capacity += (int)animal.size;
        }

        public bool WillAnimalFit(Animal animal)
        {
            if ((Capacity - animal.size) < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsSafeToAddAnimal(Animal animal)
        {
            if (_animals.OfType<Carnivore>().Any() && Capacity >= (int)animal.size)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool AreHerbivoresOnBoard()
        {
            if (_animals.OfType<Herbivore>().Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool AreCarnivoresOnBoard()
        {
            if (_animals.OfType<Carnivore>().Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*private bool OnlyBiggerAnimalsOnBoard(Size size)
        {
            
        }

        private bool OnlySmallerAnimalsOnBoard(Size size)
        {

        }*/
    }
}
