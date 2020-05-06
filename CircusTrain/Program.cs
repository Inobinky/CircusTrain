using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            Train t = new Train();

            t.AddAnimals(AnimalFactory.RandomAnimals(10, 15));
            t.DistributeAnimals();
        }
    }
}
