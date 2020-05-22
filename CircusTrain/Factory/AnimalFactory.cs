using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain.Factory
{
    public class AnimalFactory
    {        
        /// <summary>
        /// Returns a List with randomly generated various animals. It is specified by the user what the minimum and maximum amount of animals should be.
        /// </summary>
        /// <param name="min">Minimum amount of random animals.</param>
        /// <param name="max">Maximum amount of random animals.</param>
        /// <returns></returns>
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

        public static Animal SmallHerbivore { get => new Herbivore(Size.Small); }
        public static Animal MediumHerbivore { get => new Herbivore(Size.Medium); }
        public static Animal LargeHerbivore { get => new Herbivore(Size.Large); }

        public static Animal SmallCarnivore { get => new Carnivore(Size.Small); }
        public static Animal MediumCarnivore { get => new Carnivore(Size.Medium); }
        public static Animal LargeCarnivore { get => new Carnivore(Size.Large); }
    }
}
