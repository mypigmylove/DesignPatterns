using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructMode.Models
{
    class Builder1:AbstractBuilder
    {

        AbstractProduct product=new AbstractProduct();

        public override void BuilderA()
        {
            product.add("AAA");
        }

        public override void BuilderB()
        {
            product.add("BBB");
        }

        public override void BuilderC()
        {
            product.add("CCC");
        }

        public override AbstractProduct GetProduct()
        {
            return product;
        }
    }
}
