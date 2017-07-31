using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMode.Models
{
    abstract class Car
    {
        public string Name { get; set; }

        public int Year { get; set; }

        public abstract void Drive();
    }
}
