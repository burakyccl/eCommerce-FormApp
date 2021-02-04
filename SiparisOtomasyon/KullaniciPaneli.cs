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
    public partial class KullaniciPaneli : Form
    {
        

        public string kullaniciAd = "";
        public int kullaniciId = 0;

        Baglanti con = new Baglanti();
        public KullaniciPaneli()
        {
            InitializeComponent();
        }

        private void KullaniciPaneli_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select kullaniciAd From Kullanici", con.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label10.Text = "Sayın, " + kullaniciAd;
            }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*From Urunler", con.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Close();
            MessageBox.Show("İyi Günler Dileriz...");
        }
        double ToplamUcret;
        double ToplamAgirlik;
        public double KdvNet;
        public double kargo;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SiparisDetay drd = new SiparisDetay();
            Siparis dr = new Siparis();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            listBox1.Items.Add(dataGridView1.Rows[secilen].Cells[1].Value.ToString());
            ToplamUcret += double.Parse(dataGridView1.Rows[secilen].Cells[3].Value.ToString());
            label6.Text = ToplamUcret.ToString();
            ToplamAgirlik += double.Parse(dataGridView1.Rows[secilen].Cells[4].Value.ToString());
            label9.Text = ToplamAgirlik.ToString();

            KdvNet = double.Parse(dr.vergiHesapla(ToplamUcret).ToString()) - ToplamUcret;
            label7.Text = KdvNet.ToString();
            kargo = double.Parse(drd.AgirlikHesapla(ToplamAgirlik).ToString());
            label8.Text = (ToplamUcret + KdvNet).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int rastgeleNumara = rastgele.Next(1000, 9999);

            foreach (string MusteriSiparisler in listBox1.Items)
            {
                DateTime tarih = DateTime.Now;

                SqlCommand cmd = new SqlCommand("insert into Siparis(siparisTarih,siparisDurum,siparisKullanici,siparisUrun,siparisNo)values(@p1,@p2,@p3,@p4,@p5)", con.baglan());
                cmd.Parameters.AddWithValue("@p1", tarih.ToString());
                cmd.Parameters.AddWithValue("@p2", "Odenmedi");
                cmd.Parameters.AddWithValue("@p3", kullaniciId);
                cmd.Parameters.AddWithValue("@p4", MusteriSiparisler);
                cmd.Parameters.AddWithValue("@p5", rastgeleNumara);
                cmd.ExecuteNonQuery();
            }

            listBox1.Items.Clear();
            ToplamUcret = 0;
            ToplamAgirlik = 0;
            KdvNet = 0;
            kargo = 0;
            SatinAl stnal = new SatinAl { siparisNo = rastgeleNumara, kullaniciAdTemp = kullaniciAd, kullaniciIdTemp = kullaniciId};
            stnal.Show();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

   
    }
}
