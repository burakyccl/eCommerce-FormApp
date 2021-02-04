using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon
{
    public class Musteri
    {
        public string MusteriAd { get; set; }
        public string MusteriAdres { get; set; }
        public string MusteriSifre { get; set; }
        public List<Siparis> Siparisler { get; private set; }
    }
}
