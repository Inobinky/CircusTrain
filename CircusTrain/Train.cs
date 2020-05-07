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

        public Train()
        {
            _wagons = new List<Wagon>();
            _animals = new List<Animal>();
        }

        //public int WagonCount { get; set; }

        /*public void AddAnimal(Animal animal)
        {

        }*/

        public void AddAnimals(IEnumerable<Animal> animals)
        {
            _animals.AddRange(animals);
            Console.WriteLine(_animals.Count + " Animals in total");
        }

        public void DistributeAnimals()
        {
            Wagon wagonForCarnivore;
            Wagon tempWagon;
            Wagon newWagonForCarnivore;

            Console.WriteLine(_animals.OfType<Carnivore>().Count() + " Carnivores");
            Console.WriteLine(_animals.OfType<Herbivore>().Count() + " Herbivores");

            foreach (Carnivore carnivore in _animals.OfType<Carnivore>())
            {
                wagonForCarnivore = new Wagon();
                wagonForCarnivore.AddAnimal(carnivore);
                _wagons.Add(wagonForCarnivore);
            }

            Console.WriteLine(_wagons.Count() + " Wagons for Carnivores");

            for (int i = 0; i < _wagons.Count; i++)
            {
                Console.WriteLine("I = " + i);

                tempWagon = _wagons.ElementAt(i);

                foreach (Herbivore herbivore in _animals.OfType<Herbivore>())
                {
                    if (tempWagon.WillAnimalFit(herbivore) && tempWagon.IsSafeToAddAnimal(herbivore))
                    {
                        tempWagon.AddAnimal(herbivore);
                    }
                    else
                    {
                        //newWagonForCarnivore = new Wagon();
                        //newWagonForCarnivore.AddAnimal(herbivore);
                        //_wagons.Add(newWagonForCarnivore);
                        Console.WriteLine("added");
                    }
                }
            }
        }

        public void DisplayWagons()
        {
            Console.WriteLine(string.Format($"Complete Distribution of wagons:"));

            for (int i = 0; i < _wagons.Count; i++)
            {                
                Console.WriteLine(string.Format("Wagon {0}: {1}",
                    _wagons.ElementAt(i),
                    _wagons.ElementAt(i).Animals
                    //_wagons.ElementAt(i).Animals.GetRange.size
                    ));
            }
        }

        private Wagon GetWagonForThisAnimal(Animal animal)
        {
            Wagon newWagon = new Wagon();
            if (newWagon.IsSafeToAddAnimal(animal))
            {
                if (newWagon.WillAnimalFit(animal))
                {
                    newWagon.AddAnimal(animal);
                }
            }
            else
            {
                _wagons.Add(newWagon);
                newWagon.AddAnimal(animal);
            }
            return newWagon;
        }
    }
}
