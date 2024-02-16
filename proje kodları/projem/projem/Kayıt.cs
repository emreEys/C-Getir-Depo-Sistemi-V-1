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
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
        }

        SqlCon con = new SqlCon();
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPass1.Text == TxtPass2.Text)
            {
                SqlCommand cmd = new SqlCommand("insert into tblLogin (LUser, LPassword) values (@l1, @l2)", con.bgl());
                cmd.Parameters.AddWithValue("@l1", txtUser.Text);
                cmd.Parameters.AddWithValue("@l2", Sha256.pass256(txtPass1.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show(txtUser.Text + " Has Been Registered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPass1.Text = "";
                TxtPass2.Text = "";
                txtUser.Text = "";
                con.bgl().Close();
            }
            else
            {
                MessageBox.Show("The Passwords are different", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass1.UseSystemPasswordChar = false;
                TxtPass2.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass1.UseSystemPasswordChar = true;
                TxtPass2.UseSystemPasswordChar = true;
            }
        }

        private void Kayıt_Load(object sender, EventArgs e)
        {
            txtPass1.UseSystemPasswordChar = true;
            TxtPass2.UseSystemPasswordChar = true;
        }
    }
}
