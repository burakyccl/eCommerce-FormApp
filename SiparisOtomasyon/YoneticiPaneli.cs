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
    public partial class YoneticiPaneli : Form
    {
        

        Baglanti con = new Baglanti();
        public YoneticiPaneli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Urunler(urunAd,urunAciklama,urunFiyat,urunAgirlik)values(@p1,@p2,@p3,@p4)", con.baglan());
            cmd.Parameters.AddWithValue("@p1", textBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@p2", textBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@p3", Convert.ToSingle(textBox3.Text));
            cmd.Parameters.AddWithValue("@p4", Convert.ToSingle(textBox4.Text));
            cmd.ExecuteNonQuery();
            con.baglan().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*From Urunler", con.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            YoneticiMusteriTakip ymt = new YoneticiMusteriTakip();
            ymt.Show();
            this.Close();
        }

        private void YoneticiPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*From Urunler", con.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From Urunler where urunId=@p1", con.baglan());
            cmd.Parameters.AddWithValue("@p1", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.baglan().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*From Urunler", con.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Urunler set urunAd=@p1,urunAciklama=@p2,urunFiyat=@p3,urunAgirlik=@p4 where urunId=@p5", con.baglan());
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            cmd.Parameters.AddWithValue("@p3", textBox3.Text);
            cmd.Parameters.AddWithValue("@p4", textBox4.Text);
            cmd.Parameters.AddWithValue("@p5", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.baglan().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*From Urunler", con.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }

      
    }
}
