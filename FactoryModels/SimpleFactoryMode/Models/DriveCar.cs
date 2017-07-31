using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMode.Models
{
    class DriveCar
    {
        public static Car CreateCar(string name)
        {
            Car car = null;
            switch (name)
            {
                case "BMW":
                    car=new BMWCar();
                    break;
                case "Audi":
                    car=new AudiCar();
                    break;
                case "Benzi":
                    car=new BenziCar();
                    break;
            }

            return car;

        }
    }
}
