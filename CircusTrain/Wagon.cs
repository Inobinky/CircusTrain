using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    class Wagon
    {
        public int capacity;
        private List<Animal> _animals;

        public Wagon(IEnumerable<Animal> animals)
        {

        }

        public void AddAnimal(Animal addedAnimal)
        {

            if ((capacity + addedAnimal._animalSize) > 10)
            {
                
            }
            else
            {
                foreach (Animal animalItem in _animals)
                {
                    if (addedAnimal._isCarnivore && (!animalItem._isCarnivore && animalItem._animalSize < addedAnimal._animalSize))
                    {
                        capacity += addedAnimal._animalSize;
                    }
                }
            }
        }
    }
}
