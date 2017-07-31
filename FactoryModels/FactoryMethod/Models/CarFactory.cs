﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
    abstract class CarFactory
    {
        public abstract Car CreateCar();
    }
}
