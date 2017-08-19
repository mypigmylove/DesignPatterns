using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructMode.Models
{
    class Builder2:AbstractBuilder
    {
        AbstractProduct product=new AbstractProduct();
        public override void BuilderA()
        {
            product.add("AAAAA");
        }

        public override void BuilderB()
        {
            product.add("BBBBB");
        }

        public override void BuilderC()
        {
            product.add("CCCCC");
        }

        public override AbstractProduct GetProduct()
        {
            return product;
        }
    }
}
