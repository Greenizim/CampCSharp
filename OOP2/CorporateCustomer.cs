using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    internal class CorporateCustomer:Customer//burdada eyni sekilde inheritance miras
    {
       //bunlar entitydir bunlarin icinde operasyon edilmemelidir
        public string CompanyName { get; set; }
        public string TaxId { get; set; }
    }
}
