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
    public partial class guncelSiparis : Form
    {
        public guncelSiparis()
        {
            InitializeComponent();
        }

        SqlCon con = new SqlCon();

        private void btnSiparisHazir_Click(object sender, EventArgs e)
        {
            MainForm.pnsiparis_static.Location = new System.Drawing.Point(570, 144);
            KuryeDurum kd = new KuryeDurum();
            kd.Show();
            this.Close();
        }

        private void btnSiparisiGordum_Click(object sender, EventArgs e)
        {
            txtUrun.Visible = true;
            MainForm.pnsiparis_static.Location = new System.Drawing.Point(320, 144);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblUrunler", con.bgl());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
            con.bgl().Close();
            dataGridView1.Visible = true;
            btnSiparisiGordum.Visible = false;
            
            
        }

        private void guncelSiparis_Load(object sender, EventArgs e)
        {
            
            txtUrun.Visible = false;
            // TODO: Bu kod satırı 'getirDepoDataSet2.tblUrunler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblUrunlerTableAdapter.Fill(this.getirDepoDataSet2.tblUrunler);
            dataGridView1.Visible = false;
           
            SqlCommand cmd = new SqlCommand("select SiparisDetay from tblsiparisDetay", con.bgl());
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                rchSiparis.Text=dr[0].ToString();
            }
            con.bgl().Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
            DataTable dt = new DataTable();
            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblUrunler where UrunAdi like '"+txtUrun.Text+"'", con.bgl());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            rchHazırlanan.Text +=  dataGridView1.Rows[e.RowIndex].Cells["UrunAdi"].FormattedValue.ToString() + ", ";
            int deger = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["UrunAdet"].FormattedValue);

            if(deger == 0)
            {
                MessageBox.Show("Malesef Ürünümüzden kalmamıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update tblUrunler set UrunAdet=@u1 where uID=@u2", con.bgl());
                cmd.Parameters.AddWithValue("@u2", dataGridView1.Rows[e.RowIndex].Cells["uID"].FormattedValue.ToString());
                cmd.Parameters.AddWithValue("@u1", deger - 1);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter("Select * from tblUrunler", con.bgl());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            

        }
    }
}
