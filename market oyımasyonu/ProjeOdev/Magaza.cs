using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdev
{
    public class Magaza
    {
        public string MagazaAdi { get; set; }
        public Adres adres { get; set; }
        public List<Calisan> Calisanlar { get; set; }
        public Magaza()
        {
            this.adres = new Adres();
            this.Calisanlar = new List<Calisan>();

        }
        public void CalisanEkle(Calisan a)
        {
            Calisanlar.Add(a);
        }
        
     
      
    }
}
