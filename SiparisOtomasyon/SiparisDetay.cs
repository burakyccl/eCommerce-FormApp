using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon
{
    public class SiparisDetay
    {
        public int SiparisAdet { get; set; }
        public string Durum { get; set; }

        public double AgirlikHesapla(double Agirlik)
        {
            return Agirlik * 1.5;
        }
      
    }
}
