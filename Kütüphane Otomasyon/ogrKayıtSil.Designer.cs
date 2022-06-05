namespace Kütüphane_Otomasyon
{
    partial class ogrKayıtSil
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
            this.adTxt = new System.Windows.Forms.TextBox();
            this.ogrSilTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrNoTxt = new System.Windows.Forms.MaskedTextBox();
            this.eposbir = new System.Windows.Forms.TextBox();
            this.eposiki = new System.Windows.Forms.ComboBox();
            this.bolumadTxt = new System.Windows.Forms.ComboBox();
            this.telefonTxt = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(154, 63);
            this.adTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(121, 23);
            this.adTxt.TabIndex = 12;
            this.adTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adTxt_KeyPress);
            // 
            // ogrSilTxt
            // 
            this.ogrSilTxt.Location = new System.Drawing.Point(154, 18);
            this.ogrSilTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ogrSilTxt.Name = "ogrSilTxt";
            this.ogrSilTxt.Size = new System.Drawing.Size(122, 23);
            this.ogrSilTxt.TabIndex = 17;
            this.ogrSilTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ogrSilTxt_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 45);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 31);
            this.button3.TabIndex = 20;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(154, 100);
            this.soyadTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(121, 23);
            this.soyadTxt.TabIndex = 23;
            this.soyadTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyadTxt_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(542, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(449, 395);
            this.dataGridView1.TabIndex = 27;
            // 
            // ogrNoTxt
            // 
            this.ogrNoTxt.Location = new System.Drawing.Point(154, 27);
            this.ogrNoTxt.Name = "ogrNoTxt";
            this.ogrNoTxt.Size = new System.Drawing.Size(121, 23);
            this.ogrNoTxt.TabIndex = 28;
            this.ogrNoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ogrNoTxt_KeyPress);
            // 
            // eposbir
            // 
            this.eposbir.Location = new System.Drawing.Point(154, 130);
            this.eposbir.Name = "eposbir";
            this.eposbir.Size = new System.Drawing.Size(120, 23);
            this.eposbir.TabIndex = 29;
            // 
            // eposiki
            // 
            this.eposiki.FormattingEnabled = true;
            this.eposiki.Items.AddRange(new object[] {
            "@outlook.com",
            "@gmail.com",
            "@ogr.uludag.edu.tr",
            "@ogr.uludag.tr"});
            this.eposiki.Location = new System.Drawing.Point(274, 130);
            this.eposiki.Name = "eposiki";
            this.eposiki.Size = new System.Drawing.Size(121, 23);
            this.eposiki.TabIndex = 30;
            // 
            // bolumadTxt
            // 
            this.bolumadTxt.FormattingEnabled = true;
            this.bolumadTxt.Items.AddRange(new object[] {
            "YBS",
            "İŞLETME",
            "UAT",
            "UTİ"});
            this.bolumadTxt.Location = new System.Drawing.Point(155, 219);
            this.bolumadTxt.Name = "bolumadTxt";
            this.bolumadTxt.Size = new System.Drawing.Size(121, 23);
            this.bolumadTxt.TabIndex = 31;
            this.bolumadTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bolumadTxt_KeyPress);
            // 
            // telefonTxt
            // 
            this.telefonTxt.Location = new System.Drawing.Point(155, 188);
            this.telefonTxt.Mask = "(999) 000-0000";
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Size = new System.Drawing.Size(121, 23);
            this.telefonTxt.TabIndex = 32;
            this.telefonTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonTxt_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Öğrenci",
            "Akademisyen",
            "Personel"});
            this.comboBox1.Location = new System.Drawing.Point(154, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 23);
            this.comboBox1.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.adTxt);
            this.groupBox1.Controls.Add(this.soyadTxt);
            this.groupBox1.Controls.Add(this.ogrNoTxt);
            this.groupBox1.Controls.Add(this.telefonTxt);
            this.groupBox1.Controls.Add(this.eposiki);
            this.groupBox1.Controls.Add(this.bolumadTxt);
            this.groupBox1.Controls.Add(this.eposbir);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 314);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Kaydediniz";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(345, 262);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(30, 15);
            this.linkLabel2.TabIndex = 43;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "İptal";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(282, 262);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(46, 15);
            this.linkLabel1.TabIndex = 42;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Temizle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kütüphane_Otomasyon.Properties.Resources.indir__1_;
            this.pictureBox1.Location = new System.Drawing.Point(401, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 15);
            this.label14.TabIndex = 40;
            this.label14.Text = "Öğrenci Bölüm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 15);
            this.label13.TabIndex = 39;
            this.label13.Text = "Üye Telefon";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 38;
            this.label12.Text = "Üye Meslek";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Üye Eposta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Üye Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Üye Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Üye ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(542, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Üyeler";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ogrSilTxt);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(12, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 102);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Üye Siliniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Üye ID";
            // 
            // ogrKayıtSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1003, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ogrKayıtSil";
            this.Load += new System.EventHandler(this.ogrKayıtSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox adTxt;
        private TextBox ogrSilTxt;
        private Button button1;
        private Button button3;
        private TextBox soyadTxt;
        private DataGridView dataGridView1;
        private MaskedTextBox ogrNoTxt;
        private TextBox eposbir;
        private ComboBox eposiki;
        private ComboBox bolumadTxt;
        private MaskedTextBox telefonTxt;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
    }
}