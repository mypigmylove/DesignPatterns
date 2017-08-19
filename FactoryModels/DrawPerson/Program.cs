using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawPerson.Models;

namespace DrawPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            var fatPerson=new FatBuilder();
            var director=new  Director(fatPerson);

            director.CreatePerson();

            Console.ReadLine();
        }
    }
}
