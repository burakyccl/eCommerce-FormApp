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
    public partial class YoneticiMusteriTakipSiparis : Form
    {
        public int musteriId = 0;
        Baglanti con = new Baglanti();
        public YoneticiMusteriTakipSiparis()
        {
            InitializeComponent();
        }

        private void YoneticiMusteriTakipSiparis_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Siparis Where siparisKullanici = @p1", con.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", musteriId);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
