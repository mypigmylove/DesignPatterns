using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructMode.Models
{
    /// <summary>
    /// 指挥者类，与客户端打交道，负责配置建造者
    /// </summary>
    public class Director
    {
        private AbstractBuilder totalBuilder;

        public Director(AbstractBuilder builder)
        {
            totalBuilder = builder;
        }

        public AbstractProduct GetProduct()
        {
            totalBuilder.BuilderA();
            totalBuilder.BuilderB();
            totalBuilder.BuilderC();
            return totalBuilder.GetProduct();
        }
    }
}
