namespace Kütüphane_Otomasyon
{
    partial class Kitap_Ara
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
            this.kitapara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Kitapadi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yazaradi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Kitapkategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Kitapsayfasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kitapsütunno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kitaprafno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kitapkimde = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kitapdurum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kitapara
            // 
            this.kitapara.ForeColor = System.Drawing.SystemColors.Desktop;
            this.kitapara.Location = new System.Drawing.Point(93, 150);
            this.kitapara.Name = "kitapara";
            this.kitapara.Size = new System.Drawing.Size(100, 23);
            this.kitapara.TabIndex = 0;
            this.kitapara.Text = "Kitap Ara";
            this.kitapara.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Kitapadi
            // 
            this.Kitapadi.Location = new System.Drawing.Point(93, 30);
            this.Kitapadi.Name = "Kitapadi";
            this.Kitapadi.Size = new System.Drawing.Size(100, 23);
            this.Kitapadi.TabIndex = 2;
            this.Kitapadi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.yazaradi);
            this.groupBox1.Controls.Add(this.kitapara);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Kitapkategori);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Kitapsayfasi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Kitapadi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 191);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bu Özelliklere göre Arayın";
            // 
            // yazaradi
            // 
            this.yazaradi.Location = new System.Drawing.Point(93, 121);
            this.yazaradi.Name = "yazaradi";
            this.yazaradi.Size = new System.Drawing.Size(100, 23);
            this.yazaradi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yazar Adı";
            // 
            // Kitapkategori
            // 
            this.Kitapkategori.Location = new System.Drawing.Point(93, 92);
            this.Kitapkategori.Name = "Kitapkategori";
            this.Kitapkategori.Size = new System.Drawing.Size(100, 23);
            this.Kitapkategori.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kitap Kategori";
            // 
            // Kitapsayfasi
            // 
            this.Kitapsayfasi.Location = new System.Drawing.Point(93, 59);
            this.Kitapsayfasi.Name = "Kitapsayfasi";
            this.Kitapsayfasi.Size = new System.Drawing.Size(100, 23);
            this.Kitapsayfasi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Sayfası";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox2.Controls.Add(this.kitapsütunno);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.kitaprafno);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.kitapkimde);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.kitapdurum);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(260, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 191);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aranan Özellikler";
            // 
            // kitapsütunno
            // 
            this.kitapsütunno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kitapsütunno.Location = new System.Drawing.Point(110, 121);
            this.kitapsütunno.Name = "kitapsütunno";
            this.kitapsütunno.ReadOnly = true;
            this.kitapsütunno.Size = new System.Drawing.Size(100, 23);
            this.kitapsütunno.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kitap Sütun no";
            // 
            // kitaprafno
            // 
            this.kitaprafno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kitaprafno.Location = new System.Drawing.Point(110, 92);
            this.kitaprafno.Name = "kitaprafno";
            this.kitaprafno.ReadOnly = true;
            this.kitaprafno.Size = new System.Drawing.Size(100, 23);
            this.kitaprafno.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kitap Raf no";
            // 
            // kitapkimde
            // 
            this.kitapkimde.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kitapkimde.Location = new System.Drawing.Point(110, 59);
            this.kitapkimde.Name = "kitapkimde";
            this.kitapkimde.ReadOnly = true;
            this.kitapkimde.Size = new System.Drawing.Size(100, 23);
            this.kitapkimde.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Kitap Kimde?";
            // 
            // kitapdurum
            // 
            this.kitapdurum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kitapdurum.Location = new System.Drawing.Point(110, 30);
            this.kitapdurum.Name = "kitapdurum";
            this.kitapdurum.ReadOnly = true;
            this.kitapdurum.Size = new System.Drawing.Size(100, 23);
            this.kitapdurum.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Kitap Durum";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(12, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 186);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilgilendirme";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Aranan Özellikler kısmına metin girilemez.";
            // 
            // Kitap_Ara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(514, 407);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Kitap_Ara";
            this.ShowIcon = false;
            this.Text = "Kitap Ara Ekranı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button kitapara;
        private Label label1;
        private TextBox Kitapadi;
        private GroupBox groupBox1;
        private TextBox Kitapsayfasi;
        private Label label2;
        private TextBox Kitapkategori;
        private Label label3;
        private TextBox yazaradi;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox kitapsütunno;
        private Label label5;
        private TextBox kitaprafno;
        private Label label6;
        private TextBox kitapkimde;
        private Label label7;
        private TextBox kitapdurum;
        private Label label8;
        private GroupBox groupBox3;
        private Label label9;
    }
}