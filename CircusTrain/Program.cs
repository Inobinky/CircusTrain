﻿using System;
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
            Train train = new Train();
            train.AddAnimal(new Animal(true, 1));
        }
    }
}
