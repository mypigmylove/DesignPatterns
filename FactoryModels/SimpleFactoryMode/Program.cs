using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactoryMode.Models;

namespace SimpleFactoryMode
{
    class Program
    {   
        static void Main(string[] args)
        {
            Car car = DriveCar.CreateCar("BMW");

            car.Drive();

            Console.ReadLine();
        }
    }
}
