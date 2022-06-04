namespace Kütüphane_Otomasyon
{
    partial class SifremiUnuttum
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
            this.perid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.eposbir = new System.Windows.Forms.TextBox();
            this.eposiki = new System.Windows.Forms.ComboBox();
            this.telno = new System.Windows.Forms.MaskedTextBox();
            this.persoyad = new System.Windows.Forms.TextBox();
            this.perad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // perid
            // 
            this.perid.Location = new System.Drawing.Point(124, 22);
            this.perid.Name = "perid";
            this.perid.Size = new System.Drawing.Size(100, 23);
            this.perid.TabIndex = 1;
            this.perid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.perid_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Personel ID";
            // 
            // eposbir
            // 
            this.eposbir.Location = new System.Drawing.Point(124, 138);
            this.eposbir.Name = "eposbir";
            this.eposbir.Size = new System.Drawing.Size(100, 23);
            this.eposbir.TabIndex = 5;
            // 
            // eposiki
            // 
            this.eposiki.FormattingEnabled = true;
            this.eposiki.Items.AddRange(new object[] {
            "@outlook.com",
            "@gmail.com",
            "@ogr.uludag.edu.tr",
            "@ogr.uludag.tr"});
            this.eposiki.Location = new System.Drawing.Point(225, 138);
            this.eposiki.Name = "eposiki";
            this.eposiki.Size = new System.Drawing.Size(121, 23);
            this.eposiki.TabIndex = 6;
            // 
            // telno
            // 
            this.telno.Location = new System.Drawing.Point(124, 109);
            this.telno.Mask = "(999) 000-0000";
            this.telno.Name = "telno";
            this.telno.Size = new System.Drawing.Size(100, 23);
            this.telno.TabIndex = 4;
            this.telno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telno_KeyPress);
            // 
            // persoyad
            // 
            this.persoyad.Location = new System.Drawing.Point(124, 80);
            this.persoyad.Name = "persoyad";
            this.persoyad.Size = new System.Drawing.Size(100, 23);
            this.persoyad.TabIndex = 3;
            this.persoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.persoyad_KeyPress);
            // 
            // perad
            // 
            this.perad.Location = new System.Drawing.Point(124, 51);
            this.perad.Name = "perad";
            this.perad.Size = new System.Drawing.Size(100, 23);
            this.perad.TabIndex = 2;
            this.perad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.perad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Personel E-Posta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Personel Tel No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Personel Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Personel Ad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(94, 25);
            this.sifre.Name = "sifre";
            this.sifre.ReadOnly = true;
            this.sifre.Size = new System.Drawing.Size(100, 23);
            this.sifre.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Personel Şifre";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.perid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.perad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.persoyad);
            this.groupBox1.Controls.Add(this.eposbir);
            this.groupBox1.Controls.Add(this.telno);
            this.groupBox1.Controls.Add(this.eposiki);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 276);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tüm Bilgileri Yazınız";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(230, 171);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(30, 15);
            this.linkLabel1.TabIndex = 40;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "İptal";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.sifre);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(24, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 74);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifreniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kütüphane_Otomasyon.Properties.Resources.indir__1_;
            this.pictureBox1.Location = new System.Drawing.Point(361, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // SifremiUnuttum
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(761, 300);
            this.Controls.Add(this.groupBox1);
            this.Name = "SifremiUnuttum";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox perid;
        private Label label8;
        private TextBox eposbir;
        private ComboBox eposiki;
        private MaskedTextBox telno;
        private TextBox persoyad;
        private TextBox perad;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox sifre;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
    }
}