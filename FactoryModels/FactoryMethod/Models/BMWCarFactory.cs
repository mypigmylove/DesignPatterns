using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
    class BMWCarFactory:CarFactory
    {
        public override Car CreateCar()
        {
            return new BMWCar();
        }
    }
}
