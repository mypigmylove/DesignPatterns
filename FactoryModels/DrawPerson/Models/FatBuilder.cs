using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawPerson.Models
{
    class FatBuilder:AbstractBuilder
    {
        public override void DrawHead()
        {
            Console.WriteLine("Fat DrawHead");
        }

        public override void DrawLegs()
        {
            Console.WriteLine("Fat DrawLegs");
        }

        public override void DrawArms()
        {
            Console.WriteLine("Fat DrawArms");
        }
    }
}
