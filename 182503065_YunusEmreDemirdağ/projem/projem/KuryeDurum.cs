using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projem
{
    public partial class KuryeDurum : Form
    {
        public KuryeDurum()
        {
            InitializeComponent();
        }

        SqlCon con = new SqlCon();

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void KuryeDurum_Load(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("http://maps.google.com/maps?q=");
            rchAdres.Text = "Depoya Dönüyorum: Sakarya mahallesi, gürsel caddesi, liyamarin2 sitesi A-B blok Altı No:8A";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select SiparisVeren, SiparisAdres, SiparisDetay, SiparisTarih, TelefonNo from tblsiparisDetay", con.bgl());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.bgl().Close();
        }

        private void btnTeslimAldım_Click(object sender, EventArgs e)
        {
            MainForm.pnsiparis_static.Location = new System.Drawing.Point(820, 144);
            btnTeslimAldım.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            btnAdresteyim.Visible= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm.pnsiparis_static.Visible= false;
            btnTelimEttim.Visible= false;
            btnİptalEt.Visible= false;

            SqlCommand cmd2 = new SqlCommand("Delete From tblsiparisDetay", con.bgl());
            cmd2.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select SiparisVeren, SiparisAdres, SiparisDetay, SiparisTarih, TelefonNo, KuryeAdi from tblSiparisDetay", con.bgl());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.bgl().Close();

            MainForm.pnsiparis_static.Location = new System.Drawing.Point(34, 120);
        }

      

        private void btnİptalEt_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tblIptalSiparis (SiparisVeren, SiparisTarih, SiparisAdres, SiparisDetay, TelefonNo, iptalNedeni, KuryeAdi) values (@s1, @s2, @s3, @s4, @s5, @s6, @s7)", con.bgl());
            cmd.Parameters.AddWithValue("@s1", Sipariş.siparisveren);
            cmd.Parameters.AddWithValue("@s2", Sipariş.tarih);
            cmd.Parameters.AddWithValue("@s3", Sipariş.siparisadres);
            cmd.Parameters.AddWithValue("@s4", Sipariş.siparisdetay);
            cmd.Parameters.AddWithValue("@s5", Sipariş.telefonNo);
            cmd.Parameters.AddWithValue("@s6", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@s7", MainForm.kurye_static.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sipariş iptal edildi!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SqlCommand cmd2 = new SqlCommand("Delete From tblsiparisDetay where SiparisVeren=@s1", con.bgl());
            cmd2.Parameters.AddWithValue("@s1", txtsiparisVeren.Text);
            cmd2.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select SiparisVeren, SiparisAdres, SiparisDetay, SiparisTarih, TelefonNo from tblsiparisDetay", con.bgl());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.bgl().Close();

            txtsiparisVeren.Text = "";
            richTextBox1.Text = "";
            
            btnAdresteyim.Visible = false;
            btnTelimEttim.Visible = false;
            btnTeslimAldım.Visible = false;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            txtsiparisVeren.Text = dataGridView1.Rows[e.RowIndex].Cells["SiparisVeren"].FormattedValue.ToString();
        }
    }
}
