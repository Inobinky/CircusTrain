using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public class Carnivore : Animal
    {
        public Size carnivoreSize;
        
        public Carnivore(Size size)
        {
            this.carnivoreSize = size;
            setSize(carnivoreSize);
        }
    }
}
