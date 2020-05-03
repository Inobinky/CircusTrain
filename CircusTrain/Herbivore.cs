using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public class Herbivore : Animal
    {
        public Size herbivoreSize;

        public Herbivore(Size size)
        {
            this.herbivoreSize = size;
            setSize(herbivoreSize);
        }
    }
}
