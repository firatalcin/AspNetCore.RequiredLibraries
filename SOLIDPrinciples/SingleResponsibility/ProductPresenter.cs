using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ProductPresenter
    {
        public void WriteToConsole(List<Product> productList)
        {
            productList.ForEach(x =>
            {
                Console.WriteLine($"{x.Id} - {x.Name} ");
            });
        }
    }
}
