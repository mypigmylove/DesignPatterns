using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawPerson.Models
{
    class ThinBuilder:AbstractBuilder
    {
        public override void DrawHead()
        {
            Console.WriteLine("Thin Person DrawHead");
        }

        public override void DrawLegs()
        {
            Console.WriteLine("Thin Person DrawLegs");
        }

        public override void DrawArms()
        {
            Console.WriteLine("Thin Person DrawArms");
        }
    }
}
