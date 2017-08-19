using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawPerson.Models
{
    /// <summary>
    /// 指挥者类
    /// </summary>
    public class Director
    {
        private AbstractBuilder _abstractBuilder;

        public Director(AbstractBuilder abstractBuilder)
        {
            _abstractBuilder = abstractBuilder;

        }

        public void CreatePerson()
        {
            _abstractBuilder.DrawHead();
            _abstractBuilder.DrawArms();
            _abstractBuilder.DrawLegs();
        }

        
    }
}
