using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Concrete
{
    public class CartLine //sepetteki her bir eleman 
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }//kaç tane alıcak
    }

}
