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
            this.kitapsil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ogrkayıt = new System.Windows.Forms.Button();
            this.kitapal = new System.Windows.Forms.Button();
            this.kitapver = new System.Windows.Forms.Button();
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
            this.kitapekle.Location = new System.Drawing.Point(6, 22);
            this.kitapekle.Name = "kitapekle";
            this.kitapekle.Size = new System.Drawing.Size(92, 23);
            this.kitapekle.TabIndex = 0;
            this.kitapekle.Text = "Kitap Ekle";
            this.kitapekle.UseVisualStyleBackColor = true;
            this.kitapekle.Click += new System.EventHandler(this.kitapekle_Click);
            // 
            // kitapsil
            // 
            this.kitapsil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kitapsil.Location = new System.Drawing.Point(6, 51);
            this.kitapsil.Name = "kitapsil";
            this.kitapsil.Size = new System.Drawing.Size(92, 23);
            this.kitapsil.TabIndex = 1;
            this.kitapsil.Text = "Kitap Sil";
            this.kitapsil.UseVisualStyleBackColor = true;
            this.kitapsil.Click += new System.EventHandler(this.kitapsil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ogrkayıt);
            this.groupBox1.Controls.Add(this.kitapal);
            this.groupBox1.Controls.Add(this.kitapver);
            this.groupBox1.Controls.Add(this.kitapkontrol);
            this.groupBox1.Controls.Add(this.kayıtol);
            this.groupBox1.Controls.Add(this.kitapekle);
            this.groupBox1.Controls.Add(this.kitapsil);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 172);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Ana Ekranı";
            // 
            // ogrkayıt
            // 
            this.ogrkayıt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ogrkayıt.Location = new System.Drawing.Point(104, 22);
            this.ogrkayıt.Name = "ogrkayıt";
            this.ogrkayıt.Size = new System.Drawing.Size(93, 40);
            this.ogrkayıt.TabIndex = 5;
            this.ogrkayıt.Text = "Öğrenci Kayıt";
            this.ogrkayıt.UseVisualStyleBackColor = true;
            this.ogrkayıt.Click += new System.EventHandler(this.ogrkayıt_Click);
            // 
            // kitapal
            // 
            this.kitapal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kitapal.Location = new System.Drawing.Point(104, 97);
            this.kitapal.Name = "kitapal";
            this.kitapal.Size = new System.Drawing.Size(93, 23);
            this.kitapal.TabIndex = 4;
            this.kitapal.Text = "Kitap Al";
            this.kitapal.UseVisualStyleBackColor = true;
            this.kitapal.Click += new System.EventHandler(this.kitapal_Click);
            // 
            // kitapver
            // 
            this.kitapver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kitapver.Location = new System.Drawing.Point(104, 68);
            this.kitapver.Name = "kitapver";
            this.kitapver.Size = new System.Drawing.Size(93, 23);
            this.kitapver.TabIndex = 3;
            this.kitapver.Text = "Kitap Ver";
            this.kitapver.UseVisualStyleBackColor = true;
            this.kitapver.Click += new System.EventHandler(this.kitapver_Click);
            // 
            // kitapkontrol
            // 
            this.kitapkontrol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kitapkontrol.Location = new System.Drawing.Point(6, 80);
            this.kitapkontrol.Name = "kitapkontrol";
            this.kitapkontrol.Size = new System.Drawing.Size(92, 40);
            this.kitapkontrol.TabIndex = 2;
            this.kitapkontrol.Text = "Kitap Kontrol";
            this.kitapkontrol.UseVisualStyleBackColor = true;
            this.kitapkontrol.Click += new System.EventHandler(this.kitapkontrol_Click);
            // 
            // kayıtol
            // 
            this.kayıtol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kayıtol.Location = new System.Drawing.Point(6, 126);
            this.kayıtol.Name = "kayıtol";
            this.kayıtol.Size = new System.Drawing.Size(191, 33);
            this.kayıtol.TabIndex = 0;
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
            this.groupBox2.Location = new System.Drawing.Point(13, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 83);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giriş Yap";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(103, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel No";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 23);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Kütüphane_Otomasyonu__bu_son_.Properties.Resources.w_350;
            this.ClientSize = new System.Drawing.Size(230, 284);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button kitapekle;
        private Button kitapsil;
        private GroupBox groupBox1;
        private Button ogrkayıt;
        private Button kitapal;
        private Button kitapver;
        private Button kitapkontrol;
        private Button kayıtol;
        private GroupBox groupBox2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
    }
}