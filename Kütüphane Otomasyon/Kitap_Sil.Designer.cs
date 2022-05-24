namespace Kütüphane_Otomasyonu__bu_son_
{
    partial class Kitap_Sil
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kitapsil = new System.Windows.Forms.Button();
            this.barkod_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.kitapsil);
            this.groupBox2.Controls.Add(this.barkod_no);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Sil";
            // 
            // kitapsil
            // 
            this.kitapsil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kitapsil.Location = new System.Drawing.Point(66, 57);
            this.kitapsil.Name = "kitapsil";
            this.kitapsil.Size = new System.Drawing.Size(104, 23);
            this.kitapsil.TabIndex = 6;
            this.kitapsil.Text = "Kitap Sil";
            this.kitapsil.UseVisualStyleBackColor = true;
            this.kitapsil.Click += new System.EventHandler(this.kitapsil_Click);
            // 
            // barkod_no
            // 
            this.barkod_no.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.barkod_no.Location = new System.Drawing.Point(66, 28);
            this.barkod_no.Name = "barkod_no";
            this.barkod_no.Size = new System.Drawing.Size(305, 23);
            this.barkod_no.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap no:";
            // 
            // Kitap_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Kütüphane_Otomasyonu__bu_son_.Properties.Resources.w_350;
            this.ClientSize = new System.Drawing.Size(407, 120);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kitap_Sil";
            this.ShowIcon = false;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox2;
        private Button kitapsil;
        private TextBox barkod_no;
        private Label label3;
    }
}