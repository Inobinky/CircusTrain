using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public class Animal
    {
        public bool _isCarnivore;
        public int _animalSize; //1 = small, 3 = medium, 5 = large

        public Animal(bool isCarnivore, int size)
        {
            this._isCarnivore = isCarnivore;
            this._animalSize = size;
        }
    }
}
