using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    class AnimalFactory
    {
        public static IEnumerable<Animal> RandomAnimals(int min, int max)
        {

        }

        public static Animal RandomAnimal(Random r)
        {
            Animal a;

            int randomsSize = r.Next(0, 3);
            Size size = (Size)(Enum.GetValues(typeof(Size)).GetValue(randomsSize));

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
