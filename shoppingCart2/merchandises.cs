using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCart2
{
    class merchandises
    {
        public string name { get; set; }
        public int price { get; set; }

        public merchandises(string _name, int _price)
        {
            name = _name;
            price = _price;

        }
    }
}
