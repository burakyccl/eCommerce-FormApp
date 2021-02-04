using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon
{
    class Kredi : Odeme
    {
        public decimal KartNo { get; set; }
        public string KartTipi { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
    }
}
