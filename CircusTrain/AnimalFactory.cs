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
            List<Animal> animals = new List<Animal>();
            Animal a;
            a = new Carnivore(size);
            animals.Add(a);
            Console.WriteLine(a.size);
            return a;
        }
    }
}
