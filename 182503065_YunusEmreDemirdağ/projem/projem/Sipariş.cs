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
    public partial class Sipariş : Form
    {
        public Sipariş()
        {
            InitializeComponent();
        }
        SqlCon con = new SqlCon();

        public static String siparisveren;
        public static String tarih;
        public static String siparisadres;
        public static String siparisdetay;
        public static String telefonNo;

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

       

        private void Sipariş_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lblTime.Text = now.ToString();
        }

        
        Random rand = new Random();
        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            Panel kurye =  MainForm.kuryeler[rand.Next(0, MainForm.kuryeler.Count)];
            
            MainForm.kuryeler.Remove(kurye);
            kurye.Controls.OfType<Button>().First().BackColor = Color.Red;
            kurye.Controls.OfType<Button>().First().Text = "Meşgul";

            MainForm.kurye_static.Text = kurye.Controls.OfType<Label>().First().Text;
            MainForm.siparisVeren_static.Text = txtSiparisVeren.Text;
            MainForm.pnsiparis_static.Visible=true;

            SqlCommand cmd2 = new SqlCommand("insert into tblsiparisDetay (SiparisVeren, SiparisTarih, SiparisAdres, SiparisDetay, TelefonNo, KuryeAdi) values (@s1, @s2, @s3, @s4, @s5, @s6)", con.bgl());
            cmd2.Parameters.AddWithValue("@s1", txtSiparisVeren.Text);
            cmd2.Parameters.AddWithValue("@s2", lblTime.Text);
            cmd2.Parameters.AddWithValue("@s3", txtSiparisAdres.Text);
            cmd2.Parameters.AddWithValue("@s4", richTextBox1.Text);
            cmd2.Parameters.AddWithValue("@s5", mskTelefon.Text);
            cmd2.Parameters.AddWithValue("@s6", kurye.Controls.OfType<Label>().First().Text);

            siparisveren = txtSiparisVeren.Text;
            tarih = lblTime.Text;
            siparisadres = txtSiparisAdres.Text;
            siparisdetay = richTextBox1.Text;
            telefonNo = mskTelefon.Text;

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Your ShopList Has Been Registered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSiparisVeren.Text = "";
            txtSiparisAdres.Text = "";
            richTextBox1.Text = "";
            mskTelefon.Text = "";
            con.bgl().Close();


            this.Close();
            
  
        }


    }
}
