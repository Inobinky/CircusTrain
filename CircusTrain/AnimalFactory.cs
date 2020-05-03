using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public class AnimalFactory
    {        
        public static IEnumerable<Animal> RandomAnimals(int min, int max)
        {
            List<Animal> animals = new List<Animal>();
            Random r = new Random();

            int amount = r.Next(min, max);
            int count = 0;

            while (count < amount)
            {
                Animal a = RandomAnimal(r);
                animals.Add(a);
                count++;
            }

            return animals.AsEnumerable();
        }
        
        public static Animal RandomAnimal(Random r)
        {
            Animal a;
            
            int randomSize = r.Next(0, 3);
            Size size = (Size)(Enum.GetValues(typeof(Size)).GetValue(randomSize));

            int type = r.Next(0, 2);
            if (type == 1)
            {
                a = new Carnivore(size);
            }
            else
            {
                a = new Herbivore(size);
            }
            return a;
        }
    }
}
