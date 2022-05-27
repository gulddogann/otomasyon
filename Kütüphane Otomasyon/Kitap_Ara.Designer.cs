namespace Kütüphane_Otomasyonu__bu_son_
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
            this.Kitapsayfasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kitapara
            // 
            this.kitapara.ForeColor = System.Drawing.SystemColors.Desktop;
            this.kitapara.Location = new System.Drawing.Point(93, 88);
            this.kitapara.Name = "kitapara";
            this.kitapara.Size = new System.Drawing.Size(100, 23);
            this.kitapara.TabIndex = 0;
            this.kitapara.Text = "Kitap Ara";
            this.kitapara.UseVisualStyleBackColor = true;
            this.kitapara.Click += new System.EventHandler(this.kitapara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı";
            // 
            // Kitapadi
            // 
            this.Kitapadi.Location = new System.Drawing.Point(93, 30);
            this.Kitapadi.Name = "Kitapadi";
            this.Kitapadi.Size = new System.Drawing.Size(100, 23);
            this.Kitapadi.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.kitapara);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(260, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(242, 191);
            this.dataGridView1.TabIndex = 11;
            // 
            // Kitap_Ara
            // 
            this.AcceptButton = this.kitapara;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Kütüphane_Otomasyonu__bu_son_.Properties.Resources.w_350;
            this.ClientSize = new System.Drawing.Size(514, 216);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Kitap_Ara";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Kitap_Ara_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button kitapara;
        private Label label1;
        private TextBox Kitapadi;
        private GroupBox groupBox1;
        private TextBox Kitapsayfasi;
        private Label label2;
        private DataGridView dataGridView1;
    }
}