using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdev
{
   public class Kisi
    {

        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public Adres adres { get;  set; }
        public Calisan calisan { get; set; }
        public decimal maas;
      
        public decimal Maas
        {
            get { return maas; }
            set 
            {

                maas = value;
            }
 
        }
        // Composit 
        public Kisi()
        {
            this.adres = new Adres();

        }
        
    }
}
