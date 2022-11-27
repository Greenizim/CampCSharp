using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    internal class IndividualCustomer:Customer//buna inheritance miras deyilir burda ferdi bir musteridir deyirik bax korperative
    {
        public string IdNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
