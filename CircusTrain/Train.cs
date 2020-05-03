using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void AddAnimal(Animal animal)
        {

        }

        public void AddAnimals(IEnumerable<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                _animals.Add(animal);
            }
        }
    }
}
