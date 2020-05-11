﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircusTrain.Factory;

namespace CircusTrain.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Train t = new Train();

            t.AddAnimals(AnimalFactory.RandomAnimals(10, 15));
            t.DistributeAnimals();
            t.DisplayWagons();
        }
    }
}