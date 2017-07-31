using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
    class BenziCarFactory:CarFactory
    {
        public override Car CreateCar()
        {
            return new BenziCar();
        }
    }
}
