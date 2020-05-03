using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public abstract class Animal
    {
        private Size size;

        public Size animalSize() { return size; }
        public void setSize(Size newSize) { size = newSize; }
    }
}
