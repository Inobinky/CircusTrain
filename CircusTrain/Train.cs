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
            _wagons.Add(new Wagon());

            foreach (Animal animal in _animals)
            {
                foreach (Wagon wagon in _wagons())
                {
                    if (wagon.IsSafeToAddAnimal(animal) && wagon.WillAnimalFit(animal))
                    {
                        wagon.AddAnimal(animal);
                        Console.WriteLine("Added animal: " + animal + " " + animal.size);
                        Console.WriteLine("Wagon capacity: " + wagon.Capacity);
                    }
                    else
                    {
                        _wagons.Add(new Wagon());
                        Console.WriteLine("CREATED NEW WAGON: " + _wagons.Count + " WAGONS NOW CURRENTLY ACTIVE");
                    }
                    Console.WriteLine("Amount of animals in this wagon: " + wagon.Animals.Count);
                }
            }
            Console.WriteLine(_wagons.Count + " AMOUNT OF WAGONS");

        }

        private Wagon GetWagonForThisAnimal(Animal animal)
        {
            return new Wagon();
        }
    }
}
