using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
    class BenziCar:Car
    {
        public override void Drive()
        {
            Console.WriteLine("Drive BenziCar");
        }
    }
}
