using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructMode.Models
{
    /// <summary>
    /// 抽象产品类
    /// </summary>
    public class AbstractProduct
    {
        ObservableCollection<string> product=new ObservableCollection<string>();

        public void add(string part)
        {
            product.Add(part);
        }

        public void Show()
        {
            foreach (var s in product)
            {
                Console.WriteLine(s);
            }
        }
    }

}
