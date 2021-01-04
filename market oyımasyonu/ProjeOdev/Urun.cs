using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdev
{
    public class Urun : Tedarikci
    {
        public string urunKategorisi { get; set; }
        public string urunAdi { get; set; }
        public decimal urunAdeti { get; set; }
        public decimal urunFiyat { get; set; }
    }
}
