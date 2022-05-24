namespace Kütüphane_Otomasyonu__bu_son_
{
    partial class Ogrenci_Kayıt
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.kayıt_ol);
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
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Kayıt";
            // 
            // kayıt_ol
            // 
            this.kayıt_ol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kayıt_ol.Location = new System.Drawing.Point(138, 195);
            this.kayıt_ol.Name = "kayıt_ol";
            this.kayıt_ol.Size = new System.Drawing.Size(163, 23);
            this.kayıt_ol.TabIndex = 11;
            this.kayıt_ol.Text = "Kaydet";
            this.kayıt_ol.UseVisualStyleBackColor = true;
            this.kayıt_ol.Click += new System.EventHandler(this.kayıt_ol_Click);
            // 
            // ogrenci_bolum
            // 
            this.ogrenci_bolum.FormattingEnabled = true;
            this.ogrenci_bolum.Items.AddRange(new object[] {
            "Yönetim Bilişim Sistemleri",
            "İşletme",
            "Uluslararası Ticaret"});
            this.ogrenci_bolum.Location = new System.Drawing.Point(138, 166);
            this.ogrenci_bolum.Name = "ogrenci_bolum";
            this.ogrenci_bolum.Size = new System.Drawing.Size(163, 23);
            this.ogrenci_bolum.TabIndex = 7;
            // 
            // ogrenci_telno
            // 
            this.ogrenci_telno.Location = new System.Drawing.Point(138, 137);
            this.ogrenci_telno.Mask = "(999) 000-0000";
            this.ogrenci_telno.Name = "ogrenci_telno";
            this.ogrenci_telno.Size = new System.Drawing.Size(163, 23);
            this.ogrenci_telno.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Öğrenci Bölüm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Öğrenci Tel No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Öğrenci E-posta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Öğrenci Soyad:";
            // 
            // ogrenci_posta
            // 
            this.ogrenci_posta.Location = new System.Drawing.Point(138, 108);
            this.ogrenci_posta.Name = "ogrenci_posta";
            this.ogrenci_posta.Size = new System.Drawing.Size(163, 23);
            this.ogrenci_posta.TabIndex = 2;
            // 
            // ogrenci_soyad
            // 
            this.ogrenci_soyad.Location = new System.Drawing.Point(138, 79);
            this.ogrenci_soyad.Name = "ogrenci_soyad";
            this.ogrenci_soyad.Size = new System.Drawing.Size(163, 23);
            this.ogrenci_soyad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğrenci Ad:";
            // 
            // ogrenci_ad
            // 
            this.ogrenci_ad.Location = new System.Drawing.Point(138, 50);
            this.ogrenci_ad.Name = "ogrenci_ad";
            this.ogrenci_ad.Size = new System.Drawing.Size(163, 23);
            this.ogrenci_ad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci No:";
            // 
            // ogrenci_no
            // 
            this.ogrenci_no.Location = new System.Drawing.Point(138, 21);
            this.ogrenci_no.Name = "ogrenci_no";
            this.ogrenci_no.Size = new System.Drawing.Size(163, 23);
            this.ogrenci_no.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Sil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Öğrenci No";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(138, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ogrenci_Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Kütüphane_Otomasyonu__bu_son_.Properties.Resources.w_350;
            this.ClientSize = new System.Drawing.Size(346, 333);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Ogrenci_Kayıt";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button kayıt_ol;
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
        private GroupBox groupBox2;
        private Label label7;
        private TextBox textBox1;
        private Button button1;
    }
}