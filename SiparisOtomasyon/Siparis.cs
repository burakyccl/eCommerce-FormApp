using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon
{
    public class Siparis
    {
        public DateTime Tarih { get; set; }
        public string SiparisDurum { get; set; }
        List<Odeme> Odemeler { get; set; }
        public SiparisDetay SiparisDetayLari;

        public double vergiHesapla(double maliyet)
        {
            return maliyet * 1.18;
        }
    }
}
