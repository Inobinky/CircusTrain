using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CircusTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            Train t = new Train();

            t.AddAnimals();
            t.DistributeAnimals();

            WriteLine(t);
            ReadLine();
        }
    }
}
