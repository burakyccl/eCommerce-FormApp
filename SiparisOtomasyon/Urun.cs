using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon
{
    public class Urun
    {
        public float KargoAgirlik { get; set; }
        public string Aciklama { get; set; }

        public List<SiparisDetay> SiparisDetays { get; set; }

    }
}
