using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdev
{
    public class Tedarikci
    {
        private List<Urun> urunler = new List<Urun>();

        public void UrunEkle(Urun a)
        {
            urunler.Add(a);
        }

    }

}
