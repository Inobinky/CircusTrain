using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public class Animal
    {
        public enum AnimalSize { Small = 1, Medium = 3, Large = 5 };
        public enum AnimalType { Herbivore, Carnivore };

        public AnimalSize animalSize;
        public AnimalType animalType;

        public Animal(AnimalSize size, AnimalType type)
        {
            this.animalType = type;
            this.animalSize = size;
        }
    }
}
