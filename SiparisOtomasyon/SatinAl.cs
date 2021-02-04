using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon
{
    public partial class SatinAl : Form
    {
        public string kullaniciAdTemp = "";
        public int kullaniciIdTemp = 0;
        public int siparisNo = 0;
        Baglanti con = new Baglanti();
        public SatinAl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödeme Başarılı. Güle Güle Kullanın.");

            SqlCommand cmd = new SqlCommand("Update Siparis set siparisDurum=@p1 where siparisNo=@p2", con.baglan());
            cmd.Parameters.AddWithValue("@p1", "Odendi");
            cmd.Parameters.AddWithValue("@p2", siparisNo);
            cmd.ExecuteNonQuery();
            this.Close();
            KullaniciPaneli kp = new KullaniciPaneli { kullaniciAd = kullaniciAdTemp, kullaniciId = kullaniciIdTemp };
            kp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödeme Başarılı. Güle Güle Kullanın.");

            SqlCommand cmd = new SqlCommand("Update Siparis set siparisDurum=@p1 where siparisNo=@p2", con.baglan());
            cmd.Parameters.AddWithValue("@p1", "Odendi");
            cmd.Parameters.AddWithValue("@p2", siparisNo);
            cmd.ExecuteNonQuery();
            this.Close();
            KullaniciPaneli kp = new KullaniciPaneli { kullaniciAd = kullaniciAdTemp, kullaniciId = kullaniciIdTemp };
            kp.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
