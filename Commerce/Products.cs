using System;
using System.Collections.Generic;
using System.Text;

namespace Commerce
{
    internal class Products
    {
        internal int id { get; set; }
        internal string name { get; set; }
        internal DateTime productionDate { get; set; }
        internal DateTime expirationDate { get; set; }
        internal double price { get; set; }
    }
}
