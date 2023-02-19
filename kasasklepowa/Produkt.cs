using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasasklepowa
{
    public class Produkt
    {
        public string KodKreskowy { get; set; }
        public string Nazwa { get; set; }
        public decimal CenaNetto { get; set; }
        public decimal CenaBrutto => CenaNetto * 1.23m;
    }



}