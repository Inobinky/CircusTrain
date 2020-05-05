using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircusTrain
{
    public class Train
    {
        private List<Wagon> _wagons;
        private List<Animal> _animals;

        public Train()
        {
            _wagons = new List<Wagon>();
            _animals = new List<Animal>();
        }

        //public int WagonCount { get; set; }

        /*public void AddAnimal(Animal animal)
        {

        }*/

        public void AddAnimals(IEnumerable<Animal> animals)
        {
            _animals.AddRange(animals);
        }

        public void DistributeAnimals()
        {
            foreach (Animal animal in _animals)
            {
                foreach (Wagon wagon in _wagons)
                {
                    if (wagon.IsSafeToAddAnimal(animal))
                    {
                        wagon.AddAnimal(animal);
                    }
                    else
                    {
                        _wagons.Add(new Wagon());
                    }
                }
            }
        }

        private Wagon GetWagonForThisAnimal(Animal animal)
        {
            return new Wagon();
        }
    }
}
