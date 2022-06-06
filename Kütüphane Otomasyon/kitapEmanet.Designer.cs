namespace Kütüphane_Otomasyon
{
    partial class kitapEmanet
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.yayinTxt = new System.Windows.Forms.TextBox();
            this.sayfaTxt = new System.Windows.Forms.TextBox();
            this.durumTxt = new System.Windows.Forms.TextBox();
            this.katTxt = new System.Windows.Forms.TextBox();
            this.dilTxt = new System.Windows.Forms.TextBox();
            this.yazarTxt = new System.Windows.Forms.TextBox();
            this.cevirmenTxt = new System.Windows.Forms.TextBox();
            this.editorTxt = new System.Windows.Forms.TextBox();
            this.rafTxt = new System.Windows.Forms.TextBox();
            this.sutunTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eklentarTxt = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(519, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(269, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 378);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(683, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 52);
            this.button2.TabIndex = 20;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(133, 25);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(125, 27);
            this.idTxt.TabIndex = 21;
            this.idTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kitap Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(41, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Yayın Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(25, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Sayfa Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(18, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Kütüphane Eklenme Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(18, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Kitap Durum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(45, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Kategori";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Orange;
            this.label8.Location = new System.Drawing.Point(442, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Dil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(442, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Yazar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Orange;
            this.label10.Location = new System.Drawing.Point(442, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Çevirmen";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Orange;
            this.label11.Location = new System.Drawing.Point(442, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Editör";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Orange;
            this.label12.Location = new System.Drawing.Point(442, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 33;
            this.label12.Text = "Raf no";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Orange;
            this.label13.Location = new System.Drawing.Point(442, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Sütun";
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(133, 71);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(125, 27);
            this.adTxt.TabIndex = 35;
            // 
            // yayinTxt
            // 
            this.yayinTxt.Location = new System.Drawing.Point(133, 117);
            this.yayinTxt.Name = "yayinTxt";
            this.yayinTxt.Size = new System.Drawing.Size(125, 27);
            this.yayinTxt.TabIndex = 36;
            // 
            // sayfaTxt
            // 
            this.sayfaTxt.Location = new System.Drawing.Point(133, 163);
            this.sayfaTxt.Name = "sayfaTxt";
            this.sayfaTxt.Size = new System.Drawing.Size(125, 27);
            this.sayfaTxt.TabIndex = 37;
            // 
            // durumTxt
            // 
            this.durumTxt.Location = new System.Drawing.Point(133, 209);
            this.durumTxt.Name = "durumTxt";
            this.durumTxt.Size = new System.Drawing.Size(125, 27);
            this.durumTxt.TabIndex = 39;
            // 
            // katTxt
            // 
            this.katTxt.Location = new System.Drawing.Point(133, 255);
            this.katTxt.Name = "katTxt";
            this.katTxt.Size = new System.Drawing.Size(125, 27);
            this.katTxt.TabIndex = 40;
            // 
            // dilTxt
            // 
            this.dilTxt.Location = new System.Drawing.Point(291, 25);
            this.dilTxt.Name = "dilTxt";
            this.dilTxt.Size = new System.Drawing.Size(125, 27);
            this.dilTxt.TabIndex = 41;
            // 
            // yazarTxt
            // 
            this.yazarTxt.Location = new System.Drawing.Point(291, 72);
            this.yazarTxt.Name = "yazarTxt";
            this.yazarTxt.Size = new System.Drawing.Size(125, 27);
            this.yazarTxt.TabIndex = 42;
            // 
            // cevirmenTxt
            // 
            this.cevirmenTxt.Location = new System.Drawing.Point(291, 119);
            this.cevirmenTxt.Name = "cevirmenTxt";
            this.cevirmenTxt.Size = new System.Drawing.Size(125, 27);
            this.cevirmenTxt.TabIndex = 43;
            // 
            // editorTxt
            // 
            this.editorTxt.Location = new System.Drawing.Point(291, 166);
            this.editorTxt.Name = "editorTxt";
            this.editorTxt.Size = new System.Drawing.Size(125, 27);
            this.editorTxt.TabIndex = 44;
            // 
            // rafTxt
            // 
            this.rafTxt.Location = new System.Drawing.Point(291, 213);
            this.rafTxt.Name = "rafTxt";
            this.rafTxt.Size = new System.Drawing.Size(125, 27);
            this.rafTxt.TabIndex = 45;
            // 
            // sutunTxt
            // 
            this.sutunTxt.Location = new System.Drawing.Point(291, 260);
            this.sutunTxt.Name = "sutunTxt";
            this.sutunTxt.Size = new System.Drawing.Size(125, 27);
            this.sutunTxt.TabIndex = 46;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // eklentarTxt
            // 
            this.eklentarTxt.Location = new System.Drawing.Point(220, 317);
            this.eklentarTxt.Name = "eklentarTxt";
            this.eklentarTxt.Size = new System.Drawing.Size(266, 27);
            this.eklentarTxt.TabIndex = 48;
            // 
            // kitapEmanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.eklentarTxt);
            this.Controls.Add(this.sutunTxt);
            this.Controls.Add(this.rafTxt);
            this.Controls.Add(this.editorTxt);
            this.Controls.Add(this.cevirmenTxt);
            this.Controls.Add(this.yazarTxt);
            this.Controls.Add(this.dilTxt);
            this.Controls.Add(this.katTxt);
            this.Controls.Add(this.durumTxt);
            this.Controls.Add(this.sayfaTxt);
            this.Controls.Add(this.yayinTxt);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "kitapEmanet";
            this.Text = "kitapEmanet";
            this.Load += new System.EventHandler(this.kitapEmanet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private TextBox idTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox adTxt;
        private TextBox yayinTxt;
        private TextBox sayfaTxt;
        private TextBox durumTxt;
        private TextBox katTxt;
        private TextBox dilTxt;
        private TextBox yazarTxt;
        private TextBox cevirmenTxt;
        private TextBox editorTxt;
        private TextBox rafTxt;
        private TextBox sutunTxt;
        private ContextMenuStrip contextMenuStrip1;
        private DateTimePicker eklentarTxt;
    }
}