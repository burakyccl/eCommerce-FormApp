using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SiparisOtomasyon
{
    public partial class Form1 : Form
    {
        

        Baglanti baglan = new Baglanti();
        List<SiparisDetay> SiparisDetayLari = new List<SiparisDetay>();
        List<Musteri> MusteriList = new List<Musteri>();


        public Form1()
        {
            InitializeComponent();
        }

        private void MusteriRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (MusteriRadio.Checked)
            {
                YoneticiGrpBox.Hide();
                MusteriGrpBox.Show();
                btnKayitOl.Show();



            }
        }

        private void YoneticiRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (YoneticiRadio.Checked == true)
            {
                YoneticiGrpBox.Show();
                MusteriGrpBox.Hide();
                btnKayitOl.Hide();
            }
        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (YoneticiRadio.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("Select * from Yonetici where yoneticiAd = @p1 and yoneticiSifre=@p2", baglan.baglan());
                cmd.Parameters.AddWithValue("@p1", yoneticiAd.Text);
                cmd.Parameters.AddWithValue("@p2", yoneticiSifre.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    YoneticiPaneli ypan = new YoneticiPaneli();
                    ypan.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Adınız Ve Soyadınız Ya da şifreniz hatalı!" + "\nLütfen kontrol ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else{
                SqlCommand cmd = new SqlCommand("Select * from Kullanici where kullaniciAd = @p1 and kullaniciSifre=@p2", baglan.baglan());
                cmd.Parameters.AddWithValue("@p1", musteriAd.Text);
                cmd.Parameters.AddWithValue("@p2", musteriSifre.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    string kullaniciİsim = dr.GetString(1);
                    int kullaniciId = dr.GetInt32(0);
                    KullaniciPaneli kpan = new KullaniciPaneli{ kullaniciAd = kullaniciİsim, kullaniciId = kullaniciId};
                    kpan.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Adınız Ve Soyadınız Ya da şifreniz hatalı!" + "\nLütfen kontrol ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Musteri cs = new Musteri();
            cs.MusteriAd = musteriAd.Text;
            cs.MusteriSifre = musteriSifre.Text;
            cs.MusteriAdres = musteriAdres.Text;
            SqlCommand cmd = new SqlCommand("insert into Kullanici(kullaniciAd,kullaniciSifre,kullaniciAdres)values(@p1,@p2,@p3)", baglan.baglan());
            cmd.Parameters.AddWithValue("@p1", cs.MusteriAd);
            cmd.Parameters.AddWithValue("@p2", cs.MusteriSifre);
            cmd.Parameters.AddWithValue("@p3", cs.MusteriAdres);
            cmd.ExecuteNonQuery();
            baglan.baglan().Close();
            MessageBox.Show("Kaydınız Yapılmıştır", "Müşteri Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void musteriSifre_TextChanged(object sender, EventArgs e)
        {
            musteriSifre.PasswordChar = '*';
        }

        private void yoneticiSifre_TextChanged(object sender, EventArgs e)
        {
            yoneticiSifre.PasswordChar = '*';
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
