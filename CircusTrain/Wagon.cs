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

        public List<Animal> Animals
        {
            get { return _animals; }
            set { _animals = value; }
        }

        public Wagon()
        {
            Capacity = 10;
            Animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            try
            {
                if (IsSafeToAddAnimal(animal))
                {
                    try
                    {
                        if (WillAnimalFit(animal))
                        {
                            _animals.Add(animal);
                            Capacity -= (int)animal.size;
                        }
                    }
                    catch (WagonCapacityException)
                    {
                        Console.WriteLine("[Wagon is full!]");
                        throw new WagonCapacityException("[Cannot add animal because the wagon is full.");
                    }
                }
            }
            catch (WagonSafetyException)
            {
                Console.WriteLine("[Unsafe to add animal!]");
                throw new WagonSafetyException("Cannot add animal because it's unsafe.");
            }
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
            if (AreCarnivoresOnBoard())
            {
                foreach (Carnivore carnivore in _animals)
                {
                    if (carnivore.size >= animal.size)
                    {
                        return false;
                    }
                    return true;
                }
            }
            return true;
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
