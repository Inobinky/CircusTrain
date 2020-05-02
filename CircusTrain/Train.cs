using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    public class Train
    {
        public void AddAnimal(int size)
        {
            AnimalFactory.makeAnimal(size);
        }
    }
}
