using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
    class AudiCarFactory:CarFactory
    {
        public override Car CreateCar()
        {
            return new AudiCar();
        }
    }
}
