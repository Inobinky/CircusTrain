using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public abstract class Animal
    {
        public Size size;

        public Animal()
        {

        }

        public Size animalSize() { return size; }
        public void setSize(Size newSize) { size = newSize; }
    }
}
