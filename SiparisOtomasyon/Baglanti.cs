using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon
{
    public class Baglanti
    {
        public SqlConnection baglan()
        {
            SqlConnection bgl = new SqlConnection(@"server = (localdb)\mssqllocaldb; initial catalog = sistem; integrated security = true");
            bgl.Open();
            return bgl;
        }
    }
}
