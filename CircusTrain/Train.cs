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

        public int WagonCount { get; set; }
        public List<Wagon> Wagons { get; set; }

        public Train()
        {
            _wagons = new List<Wagon>();
            _animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        /// <summary>
        /// Adds the list of random animals to the train (not yet distributed).
        /// </summary>
        /// <param name="animals">The List of animals.</param>
        public void AddAnimals(IEnumerable<Animal> animals)
        {
            _animals.AddRange(animals);
            Console.WriteLine(_animals.Count + " Animals in total");
        }

        /// <summary>
        /// Distributes the list of animals in the train into the wagons where they fit in and are safe to be added to.
        /// </summary>
        public void DistributeAnimals()
        {
            Wagon wagon;

            foreach (Carnivore carnivore in _animals.OfType<Carnivore>())
            {
                wagon = new Wagon();
                wagon.AddAnimal(carnivore);
                _wagons.Add(wagon);
            }

            foreach (Herbivore herbivore in _animals.OfType<Herbivore>())
            {
                if (_wagons.Count == 0) { _wagons.Add(new Wagon()); }

                for (int i = 0; i < _wagons.Count(); i++)
                {
                    wagon = _wagons.ElementAt(i);

                    if (wagon.WillAnimalFit(herbivore) && wagon.IsSafeToAddAnimal(herbivore))
                    {
                        wagon.AddAnimal(herbivore);
                        break;
                    }
                    else if (i == (_wagons.Count() - 1))
                    {
                        wagon = new Wagon();
                        wagon.AddAnimal(herbivore);
                        _wagons.Add(wagon);
                        break;
                    }
                    else if (i < _wagons.Count())
                    {
                        continue;
                    }
                }
            }

            WagonCount = _wagons.Count;
            Wagons = _wagons;
        }

        /*private Wagon GetWagonForThisAnimal(Animal animal)
        {
            Wagon wagon = GetWagonForThisAnimal(animal);

            if (wagon.IsSafeToAddAnimal(animal) && wagon.WillAnimalFit(animal))
            {
                wagon.AddAnimal(animal);
                return wagon;
            }
            else
            {
                wagon = new Wagon();
                wagon.AddAnimal(animal);
                _wagons.Add(wagon);
                return wagon;
            }
        }*/

        public void DisplayWagons()
        {
            Console.WriteLine(_animals.OfType<Carnivore>().Count() + " Carnivores");
            Console.WriteLine(_animals.OfType<Herbivore>().Count() + " Herbivores");
            Console.WriteLine(string.Format($"\nComplete Distribution of wagons:"));

            for (int i = 0; i < _wagons.Count; i++)
            {
                Wagon wagon = _wagons.ElementAt(i);
                Console.WriteLine(string.Format($"\nWagon {i} Contains: \n"));
                foreach (Carnivore carnivore in wagon.Animals.OfType<Carnivore>())
                {
                    Console.WriteLine("C-" + carnivore.size + ", ");
                }
                foreach (Herbivore herbivore in wagon.Animals.OfType<Herbivore>())
                {
                    Console.WriteLine("H-" + herbivore.size + ", ");
                }
            }
        }
    }
}
