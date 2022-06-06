namespace Kütüphane_Otomasyon
{
    partial class PersonelKayıt
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.perad = new System.Windows.Forms.TextBox();
            this.persoyad = new System.Windows.Forms.TextBox();
            this.persifre = new System.Windows.Forms.TextBox();
            this.telno = new System.Windows.Forms.MaskedTextBox();
            this.eposbir = new System.Windows.Forms.TextBox();
            this.eposiki = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Personel Tel No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Personel e-Posta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Personel Şifre";
            // 
            // perad
            // 
            this.perad.Location = new System.Drawing.Point(168, 68);
            this.perad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.perad.Name = "perad";
            this.perad.Size = new System.Drawing.Size(114, 27);
            this.perad.TabIndex = 6;
            this.perad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.perad_KeyPress);
            // 
            // persoyad
            // 
            this.persoyad.Location = new System.Drawing.Point(168, 108);
            this.persoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.persoyad.Name = "persoyad";
            this.persoyad.Size = new System.Drawing.Size(114, 27);
            this.persoyad.TabIndex = 7;
            this.persoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.persoyad_KeyPress);
            // 
            // persifre
            // 
            this.persifre.Location = new System.Drawing.Point(168, 224);
            this.persifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.persifre.Name = "persifre";
            this.persifre.PasswordChar = '*';
            this.persifre.Size = new System.Drawing.Size(114, 27);
            this.persifre.TabIndex = 10;
            // 
            // telno
            // 
            this.telno.Location = new System.Drawing.Point(168, 147);
            this.telno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.telno.Mask = "(999) 000-0000";
            this.telno.Name = "telno";
            this.telno.Size = new System.Drawing.Size(114, 27);
            this.telno.TabIndex = 11;
            this.telno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telno_KeyPress);
            // 
            // eposbir
            // 
            this.eposbir.Location = new System.Drawing.Point(168, 185);
            this.eposbir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eposbir.Name = "eposbir";
            this.eposbir.Size = new System.Drawing.Size(114, 27);
            this.eposbir.TabIndex = 12;
            // 
            // eposiki
            // 
            this.eposiki.FormattingEnabled = true;
            this.eposiki.Items.AddRange(new object[] {
            "@outlook.com",
            "@gmail.com",
            "@ogr.uludag.edu.tr",
            "@ogr.uludag.tr"});
            this.eposiki.Location = new System.Drawing.Point(283, 185);
            this.eposiki.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eposiki.Name = "eposiki";
            this.eposiki.Size = new System.Drawing.Size(138, 28);
            this.eposiki.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 27);
            this.textBox1.TabIndex = 18;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Personel ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.perad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.persoyad);
            this.groupBox1.Controls.Add(this.telno);
            this.groupBox1.Controls.Add(this.persifre);
            this.groupBox1.Controls.Add(this.eposiki);
            this.groupBox1.Controls.Add(this.eposbir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(570, 347);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Olunuz";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(353, 268);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(36, 20);
            this.linkLabel2.TabIndex = 23;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Geri";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(289, 268);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 20);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Temizle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kütüphane_Otomasyon.Properties.Resources.indir__1_;
            this.pictureBox1.Location = new System.Drawing.Point(426, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // PersonelKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(870, 379);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PersonelKayıt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox perad;
        private TextBox persoyad;
        private TextBox persifre;
        private MaskedTextBox telno;
        private TextBox eposbir;
        private ComboBox eposiki;
        private TextBox textBox1;
        private Label label8;
        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel2;
    }
}