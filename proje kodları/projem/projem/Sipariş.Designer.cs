namespace projem
{
    partial class Sipariş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sipariş));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSiparisVeren = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSiparisAdres = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkViolet;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 63);
            this.panel1.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(4, 38);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(57, 20);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "label2";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(474, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Siparis Ekranı";
            // 
            // txtSiparisVeren
            // 
            this.txtSiparisVeren.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSiparisVeren.Location = new System.Drawing.Point(236, 406);
            this.txtSiparisVeren.Name = "txtSiparisVeren";
            this.txtSiparisVeren.Size = new System.Drawing.Size(235, 38);
            this.txtSiparisVeren.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(28, 409);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 31);
            this.label14.TabIndex = 26;
            this.label14.Text = "Sipariş veren: ";
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSiparisVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisVer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSiparisVer.Location = new System.Drawing.Point(-5, 664);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(513, 60);
            this.btnSiparisVer.TabIndex = 27;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = false;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 31);
            this.label2.TabIndex = 29;
            this.label2.Text = "Siparis Adres: ";
            // 
            // txtSiparisAdres
            // 
            this.txtSiparisAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSiparisAdres.Location = new System.Drawing.Point(236, 481);
            this.txtSiparisAdres.Name = "txtSiparisAdres";
            this.txtSiparisAdres.Size = new System.Drawing.Size(235, 38);
            this.txtSiparisAdres.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(8, 89);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(482, 221);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(166, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 26);
            this.label3.TabIndex = 31;
            this.label3.Text = "Sipariş Listem";
            // 
            // mskTelefon
            // 
            this.mskTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.Location = new System.Drawing.Point(234, 548);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(237, 38);
            this.mskTelefon.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(51, 555);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 31);
            this.label4.TabIndex = 33;
            this.label4.Text = "Telefon No:";
            // 
            // Sipariş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 723);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSiparisAdres);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSiparisVeren);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sipariş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş";
            this.Load += new System.EventHandler(this.Sipariş_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.TextBox txtSiparisVeren;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSiparisAdres;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label label4;
    }
}