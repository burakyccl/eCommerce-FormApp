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
    public partial class YoneticiMusteriTakip : Form
    {
        Baglanti con = new Baglanti();
        public YoneticiMusteriTakip()
        {
            InitializeComponent();
        }
        private void YoneticiMusteriTakip_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Kullanici", con.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int musteriId = 0;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            musteriId = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
            YoneticiMusteriTakipSiparis ymts = new YoneticiMusteriTakipSiparis{ musteriId = musteriId };
            ymts.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiPaneli yp = new YoneticiPaneli();
            yp.Show();
            this.Close();
        }

        
    }
}
