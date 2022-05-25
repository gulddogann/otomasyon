namespace Kütüphane_Otomasyonu__bu_son_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kitapekle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ogrkayıt = new System.Windows.Forms.Button();
            this.kitapal = new System.Windows.Forms.Button();
            this.kitapkontrol = new System.Windows.Forms.Button();
            this.kayıtol = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kitapekle
            // 
            this.kitapekle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kitapekle.Location = new System.Drawing.Point(7, 29);
            this.kitapekle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitapekle.Name = "kitapekle";
            this.kitapekle.Size = new System.Drawing.Size(105, 69);
            this.kitapekle.TabIndex = 2;
            this.kitapekle.Text = "Kitap Ekle ve Sil";
            this.kitapekle.UseVisualStyleBackColor = true;
            this.kitapekle.Click += new System.EventHandler(this.kitapekle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.ogrkayıt);
            this.groupBox1.Controls.Add(this.kitapal);
            this.groupBox1.Controls.Add(this.kitapkontrol);
            this.groupBox1.Controls.Add(this.kayıtol);
            this.groupBox1.Controls.Add(this.kitapekle);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(232, 272);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Ana Ekranı";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(6, 220);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "Rapor ve İstatistik";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(7, 168);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Kitap Ara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ogrkayıt
            // 
            this.ogrkayıt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ogrkayıt.Location = new System.Drawing.Point(119, 29);
            this.ogrkayıt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrkayıt.Name = "ogrkayıt";
            this.ogrkayıt.Size = new System.Drawing.Size(106, 69);
            this.ogrkayıt.TabIndex = 3;
            this.ogrkayıt.Text = "Öğrenci Kayıt ve Sil";
            this.ogrkayıt.UseVisualStyleBackColor = true;
            this.ogrkayıt.Click += new System.EventHandler(this.ogrkayıt_Click);
            // 
            // kitapal
            // 
            this.kitapal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kitapal.Location = new System.Drawing.Point(119, 107);
            this.kitapal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitapal.Name = "kitapal";
            this.kitapal.Size = new System.Drawing.Size(106, 53);
            this.kitapal.TabIndex = 5;
            this.kitapal.Text = "Kitap Alış-Veriş";
            this.kitapal.UseVisualStyleBackColor = true;
            this.kitapal.Click += new System.EventHandler(this.kitapal_Click);
            // 
            // kitapkontrol
            // 
            this.kitapkontrol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kitapkontrol.Location = new System.Drawing.Point(7, 107);
            this.kitapkontrol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitapkontrol.Name = "kitapkontrol";
            this.kitapkontrol.Size = new System.Drawing.Size(105, 53);
            this.kitapkontrol.TabIndex = 4;
            this.kitapkontrol.Text = "Kitap Kontrol";
            this.kitapkontrol.UseVisualStyleBackColor = true;
            this.kitapkontrol.Click += new System.EventHandler(this.kitapkontrol_Click);
            // 
            // kayıtol
            // 
            this.kayıtol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kayıtol.Location = new System.Drawing.Point(118, 168);
            this.kayıtol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kayıtol.Name = "kayıtol";
            this.kayıtol.Size = new System.Drawing.Size(106, 44);
            this.kayıtol.TabIndex = 7;
            this.kayıtol.Text = "Personel Kayıt";
            this.kayıtol.UseVisualStyleBackColor = true;
            this.kayıtol.Click += new System.EventHandler(this.kayıtol_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(14, 296);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(232, 111);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giriş Yap";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(118, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel No";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 27);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Kütüphane_Otomasyonu__bu_son_.Properties.Resources.w_350;
            this.ClientSize = new System.Drawing.Size(263, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button kitapekle;
        private GroupBox groupBox1;
        private Button ogrkayıt;
        private Button kitapal;
        private Button kitapkontrol;
        private Button kayıtol;
        private GroupBox groupBox2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
    }
}