﻿using System;
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
            foreach (Animal animal in _animals)
            {
                GetWagonForThisAnimal(animal);
            }
        }

        private Wagon GetWagonForThisAnimal(Animal animal)
        {
            Wagon wagon = MethodBase.GetCurrentMethod().DeclaringType;

            if (MethodBase.GetCurrentMethod().iss)
            {
                wagon.AddAnimal(animal);
                return wagon;
            }
            else
            {
                return null;
            }
        }

        public void DisplayWagons()
        {
            Console.WriteLine(_animals.OfType<Carnivore>().Count() + " Carnivores");
            Console.WriteLine(_animals.OfType<Herbivore>().Count() + " Herbivores");
            Console.WriteLine(string.Format($"Complete Distribution of wagons:"));

            for (int i = 0; i < _wagons.Count; i++)
            {
                Console.WriteLine(string.Format("Wagon {0}: {1}",
                    _wagons.ElementAt(i).ToString(),
                    _wagons.ElementAt(i).Animals.ToString()
                    //_wagons.ElementAt(i).Animals.GetRange.size
                    ));
            }
        }
    }
}
