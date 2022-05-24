namespace Kütüphane_Otomasyonu__bu_son_
{
    partial class Personel_Kayıt
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
            this.kayıtol = new System.Windows.Forms.Button();
            this.pertelno = new System.Windows.Forms.MaskedTextBox();
            this.perposta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.persoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.perad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.perno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.kayıtol);
            this.groupBox1.Controls.Add(this.pertelno);
            this.groupBox1.Controls.Add(this.perposta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.persoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.perad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.perno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Ol";
            // 
            // kayıtol
            // 
            this.kayıtol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kayıtol.Location = new System.Drawing.Point(107, 161);
            this.kayıtol.Name = "kayıtol";
            this.kayıtol.Size = new System.Drawing.Size(139, 23);
            this.kayıtol.TabIndex = 6;
            this.kayıtol.Text = "Kayıt Ol";
            this.kayıtol.UseVisualStyleBackColor = true;
            this.kayıtol.Click += new System.EventHandler(this.kayıtol_Click);
            // 
            // pertelno
            // 
            this.pertelno.Location = new System.Drawing.Point(107, 103);
            this.pertelno.Mask = "(999) 000-0000";
            this.pertelno.Name = "pertelno";
            this.pertelno.Size = new System.Drawing.Size(139, 23);
            this.pertelno.TabIndex = 4;
            // 
            // perposta
            // 
            this.perposta.Location = new System.Drawing.Point(107, 132);
            this.perposta.Name = "perposta";
            this.perposta.Size = new System.Drawing.Size(139, 23);
            this.perposta.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Personel E-posta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Personel Tel No";
            // 
            // persoyad
            // 
            this.persoyad.Location = new System.Drawing.Point(107, 74);
            this.persoyad.Name = "persoyad";
            this.persoyad.Size = new System.Drawing.Size(139, 23);
            this.persoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Soyad";
            // 
            // perad
            // 
            this.perad.Location = new System.Drawing.Point(107, 45);
            this.perad.Name = "perad";
            this.perad.Size = new System.Drawing.Size(139, 23);
            this.perad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Ad";
            // 
            // perno
            // 
            this.perno.Location = new System.Drawing.Point(107, 16);
            this.perno.Name = "perno";
            this.perno.Size = new System.Drawing.Size(139, 23);
            this.perno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel No";
            // 
            // Personel_Kayıt
            // 
            this.AcceptButton = this.kayıtol;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Kütüphane_Otomasyonu__bu_son_.Properties.Resources.w_350;
            this.ClientSize = new System.Drawing.Size(289, 226);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Personel_Kayıt";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button kayıtol;
        private MaskedTextBox pertelno;
        private TextBox perposta;
        private Label label5;
        private Label label4;
        private TextBox persoyad;
        private Label label3;
        private TextBox perad;
        private Label label2;
        private TextBox perno;
        private Label label1;
    }
}