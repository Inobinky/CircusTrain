using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public class Train
    {
        public List<Wagon> _wagons;
        public List<Animal> _animals;
        public int WagonCount;
        public int totalAnimalPoints;

        public Train()
        {
            this._animals = _animals;
        }

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        public void AddAnimals(IEnumerable<Animal> animals)
        {

        }

        public void DistributeAnimals()
        {
            foreach (Animal animalItem in _animals)
            {
                totalAnimalPoints += animalItem._animalSize;
            }
            
            WagonCount = totalAnimalPoints / 10;

            foreach (Animal animalItem in _animals)
            {
                if (animalItem._isCarnivore)
                {
                    if (animalItem._animalSize == 1)
                    {

                    }
                    else if (animalItem._animalSize == 3)
                    {

                    }
                    else if (animalItem._animalSize == 5)
                    {

                    }
                }
            }
        }

        //private Wagon GetWagonForThisAnimal(Animal animal) { }
    }
}
