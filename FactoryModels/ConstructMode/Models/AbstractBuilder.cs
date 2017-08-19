using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructMode.Models
{
    /// <summary>
    /// 抽象建造者类，约束了具体创建者必须要完成的步骤
    /// </summary>
    public abstract class AbstractBuilder
    {
        /// <summary>
        /// partA
        /// </summary>
        public abstract void BuilderA();

        /// <summary>
        /// partB
        /// </summary>
        public abstract void BuilderB();

        /// <summary>
        /// partC
        /// </summary>
        public abstract void BuilderC();

        /// <summary>
        /// 获得产品
        /// </summary>
        /// <returns></returns>
        public abstract AbstractProduct GetProduct();


    }
}
