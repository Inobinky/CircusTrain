using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public class Carnivore : Animal
    {
        public int carnivoreSize;

        public Carnivore(int size)
        {
            this.carnivoreSize = size;
            setSize(carnivoreSize);
        }
    }
}
