using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Models;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory=new BMWCarFactory();

            Car car = factory.CreateCar();

            car.Drive();

            Console.ReadLine();
        }
    }
}
