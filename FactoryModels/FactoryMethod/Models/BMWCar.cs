﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
    class BMWCar:Car
    {
        public override void Drive()
        {
            Console.WriteLine("Drive BMWCar");
        }
    }
}
