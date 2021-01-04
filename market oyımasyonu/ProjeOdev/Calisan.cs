using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdev
{
    public class Calisan : Kisi
    {
        
        public string Departman { get;  set; }
        public DateTime CalismaSuresi { get; set; }
     
        public string CalisanSube { get; set; }
        

        public Magaza magaza { get; set; }
        public Calisan()
        {
            this.magaza = new Magaza();

        }
        

    }

}

