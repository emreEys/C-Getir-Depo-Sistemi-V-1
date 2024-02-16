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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        SqlCon con = new SqlCon();
        public static string user;
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Select * from tblLogin where LUser=@p1 and LPassword=@p2", con.bgl());
            cmd.Parameters.AddWithValue("@p1", txtUser.Text);
            cmd.Parameters.AddWithValue("@p2", Sha256.pass256(txtPass.Text));
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                user = dr[1].ToString();
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Username or Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = "";
                txtUser.Text = "";

            }
            con.bgl().Close();
        }

        private void linkKaydol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayıt k = new Kayıt();
            k.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
                
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            txtUser.Text = "yunus emre";
            txtPass.Text = "1234";
        }
    }

    
}
