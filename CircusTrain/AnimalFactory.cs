using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public class AnimalFactory
    {
        public static Animal makeAnimal(int size)
        {
            return new Carnivore(size);
        }
    }
}
