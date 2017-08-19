using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructMode.Models;

namespace ConstructMode
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder1=new Builder1();

            var director=new Director(builder1);

            var product1 = director.GetProduct();

            product1.Show();

            Console.ReadLine();

        }
    }
}
