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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        SqlCon con = new SqlCon();

        private void button1_Click(object sender, EventArgs e)
        {

            Login lg = new Login();
            lg.Show();
            this.Hide();

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("http://maps.google.com/maps?q=");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış yapılıyor", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (btnDepoMusait.Text == "Depo Müsait")
            {
                MessageBox.Show("Depo Meşgule Geçiyor", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnDepoMusait.BackColor = Color.Red;
                btnDepoMusait.Text = "Depo Mesgul";
                btnKuryeDurum.Visible = false;
                btnSiparis.Visible = false;
                lblKuryeDurum.Visible = false;
                lblSiparis.Visible = false;
                MusaitMesgul(false);
            }
            else
            {
                MessageBox.Show("Depo Müsaite Geçiyor", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnDepoMusait.BackColor = Color.Green;
                btnDepoMusait.Text = "Depo Müsait";
                btnKuryeDurum.Visible = true;
                btnSiparis.Visible = true;
                lblKuryeDurum.Visible = true;
                lblSiparis.Visible = true;
                MusaitMesgul(true);

            }
        }
        public static Panel pnsiparis_static;
        public static Label kurye_static;
        public static Label siparisVeren_static;
        public static List<Panel> kuryeler = new List<Panel>();

        private void MainForm_Load(object sender, EventArgs e)
        {

            kuryeler.Add(panelEmrah);
            kuryeler.Add(panelYusuf);
            kuryeler.Add(panelRıdvan);
            kuryeler.Add(panelMevlut);
            pnsiparis_static = pnsiparis;
            kurye_static = lblKurye;
            siparisVeren_static = lblSiparisVeren;


            lblKullanici.Text = Login.user;
            btnDepoMusait.BackColor = Color.Red;
            btnDepoMusait.Text = "Depo Meşgul";
            btnKuryeDurum.Visible = false;
            btnSiparis.Visible = false;
            lblKuryeDurum.Visible = false;
            lblSiparis.Visible = false;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select SiparisVeren, SiparisAdres, SiparisDetay, SiparisTarih, TelefonNo, iptalNedeni, KuryeAdi from tblIptalSiparis", con.bgl());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.bgl().Close();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            Sipariş sp = new Sipariş();
            sp.Show();

        }

        private void btnKuryeDurum_Click(object sender, EventArgs e)
        {
            KuryeDurum kd = new KuryeDurum();
            kd.Show();
        }

        private void pnsiparis_Click(object sender, EventArgs e)
        {
            guncelSiparis gs = new guncelSiparis();
            gs.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from tblIptalSiparis", con.bgl());
            cmd.ExecuteNonQuery();
            con.bgl().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select SiparisVeren, SiparisAdres, SiparisDetay, SiparisTarih, TelefonNo, iptalNedeni, KuryeAdi from tblIptalSiparis", con.bgl());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.bgl().Close();


        }

        public void MusaitMesgul(bool a)
        {
            if (a == true)
            {
                btnEmrah.Text = "Müsait";
                btnEmrah.BackColor = Color.Green;
                btnYusuf.Text = "Müsait";
                btnYusuf.BackColor = Color.Green;
                btnRıdvan.Text = "Müsait";
                btnRıdvan.BackColor = Color.Green;
                btnMevlut.Text = "Müsait";
                btnMevlut.BackColor = Color.Green;

            }
            else if (a == false)
            {
                btnEmrah.Text = "Meşgul";
                btnEmrah.BackColor = Color.Red;
                btnYusuf.Text = "Meşgul";
                btnYusuf.BackColor = Color.Red;
                btnRıdvan.Text = "Meşgul";
                btnRıdvan.BackColor = Color.Red;
                btnMevlut.Text = "Meşgul";
                btnMevlut.BackColor = Color.Red;
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select SiparisVeren, SiparisAdres, SiparisDetay, SiparisTarih, TelefonNo, iptalNedeni, KuryeAdi from tblIptalSiparis", con.bgl());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.bgl().Close();
        }
    }
}
