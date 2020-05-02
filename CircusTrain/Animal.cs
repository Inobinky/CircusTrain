using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public abstract class Animal
    {
        public int size;

        public int Size() { return size; }
        public void setSize(int newSize) { size = newSize; }
    }
}
