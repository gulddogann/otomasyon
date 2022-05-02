namespace Kütüphane_Otomasyon
{
    partial class Öğrenci_KayıtOl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kayıt_ol = new System.Windows.Forms.Button();
            this.ogrenci_tarih = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ogrenci_bolum = new System.Windows.Forms.ComboBox();
            this.ogrenci_telno = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ogrenci_posta = new System.Windows.Forms.TextBox();
            this.ogrenci_soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ogrenci_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ogrenci_no = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.kayıt_ol);
            this.groupBox1.Controls.Add(this.ogrenci_tarih);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ogrenci_bolum);
            this.groupBox1.Controls.Add(this.ogrenci_telno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ogrenci_posta);
            this.groupBox1.Controls.Add(this.ogrenci_soyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ogrenci_ad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ogrenci_no);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // kayıt_ol
            // 
            this.kayıt_ol.Location = new System.Drawing.Point(162, 225);
            this.kayıt_ol.Name = "kayıt_ol";
            this.kayıt_ol.Size = new System.Drawing.Size(163, 23);
            this.kayıt_ol.TabIndex = 11;
            this.kayıt_ol.Text = "Kayıt Ol";
            this.kayıt_ol.UseVisualStyleBackColor = true;
            // 
            // ogrenci_tarih
            // 
            this.ogrenci_tarih.Location = new System.Drawing.Point(162, 196);
            this.ogrenci_tarih.Mask = "00/00/0000";
            this.ogrenci_tarih.Name = "ogrenci_tarih";
            this.ogrenci_tarih.Size = new System.Drawing.Size(163, 23);
            this.ogrenci_tarih.TabIndex = 10;
            this.ogrenci_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Öğrenci Doğum Tarihi:";
            // 
            // ogrenci_bolum
            // 
            this.ogrenci_bolum.FormattingEnabled = true;
            this.ogrenci_bolum.Items.AddRange(new object[] {
            "Yönetim Bilişim Sistemleri",
            "İşletme",
            "Uluslararası Ticaret"});
            this.ogrenci_bolum.Location = new System.Drawing.Point(162, 167);
            this.ogrenci_bolum.Name = "ogrenci_bolum";
            this.ogrenci_bolum.Size = new System.Drawing.Size(163, 23);
            this.ogrenci_bolum.TabIndex = 7;
            // 
            // ogrenci_telno
            // 
            this.ogrenci_telno.Location = new System.Drawing.Point(162, 138);
            this.ogrenci_telno.Mask = "(999) 000-0000";
            this.ogrenci_telno.Name = "ogrenci_telno";
            this.ogrenci_telno.Size = new System.Drawing.Size(163, 23);
            this.ogrenci_telno.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Öğrenci Bölüm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Öğrenci Tel No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Öğrenci E-posta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Öğrenci Soyad:";
            // 
            // ogrenci_posta
            // 
            this.ogrenci_posta.Location = new System.Drawing.Point(162, 109);
            this.ogrenci_posta.Name = "ogrenci_posta";
            this.ogrenci_posta.Size = new System.Drawing.Size(163, 23);
            this.ogrenci_posta.TabIndex = 2;
            // 
            // ogrenci_soyad
            // 
            this.ogrenci_soyad.Location = new System.Drawing.Point(162, 80);
            this.ogrenci_soyad.Name = "ogrenci_soyad";
            this.ogrenci_soyad.Size = new System.Drawing.Size(163, 23);
            this.ogrenci_soyad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğrenci Ad:";
            // 
            // ogrenci_ad
            // 
            this.ogrenci_ad.Location = new System.Drawing.Point(162, 51);
            this.ogrenci_ad.Name = "ogrenci_ad";
            this.ogrenci_ad.Size = new System.Drawing.Size(163, 23);
            this.ogrenci_ad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci No:";
            // 
            // ogrenci_no
            // 
            this.ogrenci_no.Location = new System.Drawing.Point(162, 22);
            this.ogrenci_no.Name = "ogrenci_no";
            this.ogrenci_no.Size = new System.Drawing.Size(163, 23);
            this.ogrenci_no.TabIndex = 0;
            // 
            // Öğrenci_KayıtOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Öğrenci_KayıtOl";
            this.Text = "Kayıt Ol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button kayıt_ol;
        private MaskedTextBox ogrenci_tarih;
        private Label label7;
        private ComboBox ogrenci_bolum;
        private MaskedTextBox ogrenci_telno;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox ogrenci_posta;
        private TextBox ogrenci_soyad;
        private Label label2;
        private TextBox ogrenci_ad;
        private Label label1;
        private TextBox ogrenci_no;
    }
}