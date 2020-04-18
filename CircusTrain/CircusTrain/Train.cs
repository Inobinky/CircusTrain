using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    class Train
    {
        private List<Wagon> _wagons;
        private List<Animal> _animals;

        public Train()
        {

        }

        public int WagonCount()
        {

        }

        public void AddAnimal(Animal animal)
        {

        }

        public void AddAnimals(IEnumerable<Animal> animals)
        {

        }

        public void DistributeAnimals()
        {

        }

        private Wagon GetWagonForThisAnimal(Animal animal)
        {

        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var wagon in _wagons)
            {
                builder.Append(wagon.ToString());
            }

            return base.ToString();
        }
    }
}
