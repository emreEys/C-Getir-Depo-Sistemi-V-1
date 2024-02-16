namespace projem
{
    partial class guncelSiparis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guncelSiparis));
            this.rchSiparis = new System.Windows.Forms.RichTextBox();
            this.btnSiparisiGordum = new System.Windows.Forms.Button();
            this.btnSiparisHazir = new System.Windows.Forms.Button();
            this.tblUrunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getirDepoDataSet2 = new projem.GetirDepoDataSet1();
            this.tblUrunlerTableAdapter = new projem.GetirDepoDataSet1TableAdapters.tblUrunlerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.rchHazırlanan = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getirDepoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rchSiparis
            // 
            this.rchSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchSiparis.Location = new System.Drawing.Point(12, 26);
            this.rchSiparis.Name = "rchSiparis";
            this.rchSiparis.Size = new System.Drawing.Size(281, 103);
            this.rchSiparis.TabIndex = 0;
            this.rchSiparis.Text = "";
            // 
            // btnSiparisiGordum
            // 
            this.btnSiparisiGordum.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSiparisiGordum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisiGordum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisiGordum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSiparisiGordum.Location = new System.Drawing.Point(180, 387);
            this.btnSiparisiGordum.Name = "btnSiparisiGordum";
            this.btnSiparisiGordum.Size = new System.Drawing.Size(257, 33);
            this.btnSiparisiGordum.TabIndex = 1;
            this.btnSiparisiGordum.Text = "Siparişi Gördüm";
            this.btnSiparisiGordum.UseVisualStyleBackColor = false;
            this.btnSiparisiGordum.Click += new System.EventHandler(this.btnSiparisiGordum_Click);
            // 
            // btnSiparisHazir
            // 
            this.btnSiparisHazir.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSiparisHazir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisHazir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisHazir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSiparisHazir.Location = new System.Drawing.Point(180, 387);
            this.btnSiparisHazir.Name = "btnSiparisHazir";
            this.btnSiparisHazir.Size = new System.Drawing.Size(257, 33);
            this.btnSiparisHazir.TabIndex = 2;
            this.btnSiparisHazir.Text = "Sipariş Hazır";
            this.btnSiparisHazir.UseVisualStyleBackColor = false;
            this.btnSiparisHazir.Click += new System.EventHandler(this.btnSiparisHazir_Click);
            // 
            // tblUrunlerBindingSource
            // 
            this.tblUrunlerBindingSource.DataMember = "tblUrunler";
            this.tblUrunlerBindingSource.DataSource = this.getirDepoDataSet2;
            // 
            // getirDepoDataSet2
            // 
            this.getirDepoDataSet2.DataSetName = "GetirDepoDataSet2";
            this.getirDepoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUrunlerTableAdapter
            // 
            this.tblUrunlerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(702, 205);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtUrun
            // 
            this.txtUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrun.Location = new System.Drawing.Point(265, 132);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(202, 38);
            this.txtUrun.TabIndex = 5;
            this.txtUrun.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rchHazırlanan
            // 
            this.rchHazırlanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchHazırlanan.Location = new System.Drawing.Point(433, 26);
            this.rchHazırlanan.Name = "rchHazırlanan";
            this.rchHazırlanan.Size = new System.Drawing.Size(281, 103);
            this.rchHazırlanan.TabIndex = 6;
            this.rchHazırlanan.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(93, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Siparis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(526, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hazırlanan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(336, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ara";
            // 
            // guncelSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(756, 423);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rchHazırlanan);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rchSiparis);
            this.Controls.Add(this.btnSiparisiGordum);
            this.Controls.Add(this.btnSiparisHazir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guncelSiparis";
            this.Text = "guncelSiparis";
            this.Load += new System.EventHandler(this.guncelSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getirDepoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchSiparis;
        private System.Windows.Forms.Button btnSiparisiGordum;
        private System.Windows.Forms.Button btnSiparisHazir;
        private GetirDepoDataSet1 getirDepoDataSet2;
        private System.Windows.Forms.BindingSource tblUrunlerBindingSource;
        private GetirDepoDataSet1TableAdapters.tblUrunlerTableAdapter tblUrunlerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.RichTextBox rchHazırlanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}