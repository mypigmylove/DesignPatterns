using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMode.Models
{
    class AudiCar:Car
    {
        public override void Drive()
        {
            Console.WriteLine("Today I drive AudiCar car");
        }
    }
}
