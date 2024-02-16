namespace projem
{
    partial class KuryeDurum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KuryeDurum));
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnTeslimAldım = new System.Windows.Forms.Button();
            this.btnAdresteyim = new System.Windows.Forms.Button();
            this.btnTelimEttim = new System.Windows.Forms.Button();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtsiparisVeren = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnİptalEt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblSiparisDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getirDepoDataSet1 = new projem.GetirDepoDataSet1();
            this.tblSiparisDetayTableAdapter = new projem.GetirDepoDataSet1TableAdapters.tblsiparisDetayTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSiparisDetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getirDepoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(377, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 23);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(411, 635);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Controls.Add(this.btnTeslimAldım);
            this.tabPage1.Controls.Add(this.btnAdresteyim);
            this.tabPage1.Controls.Add(this.btnTelimEttim);
            this.tabPage1.Controls.Add(this.rchAdres);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(403, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "       Durum      ";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(-4, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(410, 420);
            this.webBrowser1.TabIndex = 9;
            // 
            // btnTeslimAldım
            // 
            this.btnTeslimAldım.BackColor = System.Drawing.Color.DarkViolet;
            this.btnTeslimAldım.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeslimAldım.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimAldım.ForeColor = System.Drawing.Color.White;
            this.btnTeslimAldım.Location = new System.Drawing.Point(-4, 539);
            this.btnTeslimAldım.Name = "btnTeslimAldım";
            this.btnTeslimAldım.Size = new System.Drawing.Size(410, 62);
            this.btnTeslimAldım.TabIndex = 5;
            this.btnTeslimAldım.Text = "Teslim Aldım";
            this.btnTeslimAldım.UseVisualStyleBackColor = false;
            this.btnTeslimAldım.Click += new System.EventHandler(this.btnTeslimAldım_Click);
            // 
            // btnAdresteyim
            // 
            this.btnAdresteyim.BackColor = System.Drawing.Color.DarkViolet;
            this.btnAdresteyim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdresteyim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdresteyim.ForeColor = System.Drawing.Color.White;
            this.btnAdresteyim.Location = new System.Drawing.Point(0, 539);
            this.btnAdresteyim.Name = "btnAdresteyim";
            this.btnAdresteyim.Size = new System.Drawing.Size(403, 58);
            this.btnAdresteyim.TabIndex = 6;
            this.btnAdresteyim.Text = "Adresteyim";
            this.btnAdresteyim.UseVisualStyleBackColor = false;
            this.btnAdresteyim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTelimEttim
            // 
            this.btnTelimEttim.BackColor = System.Drawing.Color.DarkViolet;
            this.btnTelimEttim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelimEttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTelimEttim.ForeColor = System.Drawing.Color.White;
            this.btnTelimEttim.Location = new System.Drawing.Point(-4, 539);
            this.btnTelimEttim.Name = "btnTelimEttim";
            this.btnTelimEttim.Size = new System.Drawing.Size(411, 58);
            this.btnTelimEttim.TabIndex = 7;
            this.btnTelimEttim.Text = "Teslim Ettim";
            this.btnTelimEttim.UseVisualStyleBackColor = false;
            this.btnTelimEttim.Click += new System.EventHandler(this.button2_Click);
            // 
            // rchAdres
            // 
            this.rchAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchAdres.Location = new System.Drawing.Point(3, 542);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(397, 52);
            this.rchAdres.TabIndex = 10;
            this.rchAdres.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtsiparisVeren);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.btnİptalEt);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(403, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "       Sipariş Detay     ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtsiparisVeren
            // 
            this.txtsiparisVeren.Location = new System.Drawing.Point(170, 416);
            this.txtsiparisVeren.Name = "txtsiparisVeren";
            this.txtsiparisVeren.Size = new System.Drawing.Size(225, 32);
            this.txtsiparisVeren.TabIndex = 13;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 234);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(388, 137);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // btnİptalEt
            // 
            this.btnİptalEt.BackColor = System.Drawing.Color.DarkViolet;
            this.btnİptalEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİptalEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptalEt.ForeColor = System.Drawing.Color.White;
            this.btnİptalEt.Location = new System.Drawing.Point(0, 539);
            this.btnİptalEt.Name = "btnİptalEt";
            this.btnİptalEt.Size = new System.Drawing.Size(410, 58);
            this.btnİptalEt.TabIndex = 9;
            this.btnİptalEt.Text = "İptal Et";
            this.btnİptalEt.UseVisualStyleBackColor = false;
            this.btnİptalEt.Click += new System.EventHandler(this.btnİptalEt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Siparis veren: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tblSiparisDetayBindingSource
            // 
            this.tblSiparisDetayBindingSource.DataMember = "tblSiparisDetay";
            this.tblSiparisDetayBindingSource.DataSource = this.getirDepoDataSet1;
            // 
            // getirDepoDataSet1
            // 
            this.getirDepoDataSet1.DataSetName = "GetirDepoDataSet1";
            this.getirDepoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSiparisDetayTableAdapter
            // 
            this.tblSiparisDetayTableAdapter.ClearBeforeFill = true;
            // 
            // KuryeDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 634);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KuryeDurum";
            this.Text = "KuryeDurum";
            this.Load += new System.EventHandler(this.KuryeDurum_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSiparisDetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getirDepoDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnTelimEttim;
        private System.Windows.Forms.Button btnAdresteyim;
        private System.Windows.Forms.Button btnTeslimAldım;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GetirDepoDataSet1 getirDepoDataSet1;
        private System.Windows.Forms.BindingSource tblSiparisDetayBindingSource;
        private GetirDepoDataSet1TableAdapters.tblsiparisDetayTableAdapter tblSiparisDetayTableAdapter;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.TextBox txtsiparisVeren;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnİptalEt;
        private System.Windows.Forms.Label label1;
    }
}