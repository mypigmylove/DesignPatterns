using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawPerson.Models
{
    public abstract class AbstractBuilder
    {
        public abstract void DrawHead();

        public abstract void DrawLegs();

        public abstract void DrawArms();

    }
}
