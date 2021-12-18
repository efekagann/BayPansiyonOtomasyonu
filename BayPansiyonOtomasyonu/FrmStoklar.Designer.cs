namespace BayPansiyonOtomasyonu
{
    partial class FrmStoklar
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtTemizlikTutar = new System.Windows.Forms.TextBox();
            this.TxtİcecekTutar = new System.Windows.Forms.TextBox();
            this.TxtGidaTutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKaydet2 = new System.Windows.Forms.Button();
            this.TxtDogalgaz = new System.Windows.Forms.TextBox();
            this.TxtSu = new System.Windows.Forms.TextBox();
            this.TxtElektrik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.TxtTemizlikTutar);
            this.groupBox1.Controls.Add(this.TxtİcecekTutar);
            this.groupBox1.Controls.Add(this.TxtGidaTutar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 621);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mutfak";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Controls.Add(this.BtnKaydet2);
            this.groupBox2.Controls.Add(this.TxtDogalgaz);
            this.groupBox2.Controls.Add(this.TxtSu);
            this.groupBox2.Controls.Add(this.TxtElektrik);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(730, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 621);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faturalar";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 394);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(663, 199);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gıdalar";
            this.columnHeader1.Width = 192;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçecekler";
            this.columnHeader2.Width = 232;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Temizlik Malzemeleri";
            this.columnHeader3.Width = 234;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.White;
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.ForeColor = System.Drawing.Color.Black;
            this.BtnKaydet.Location = new System.Drawing.Point(376, 294);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(125, 40);
            this.BtnKaydet.TabIndex = 14;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            // 
            // TxtTemizlikTutar
            // 
            this.TxtTemizlikTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTemizlikTutar.Location = new System.Drawing.Point(329, 238);
            this.TxtTemizlikTutar.Name = "TxtTemizlikTutar";
            this.TxtTemizlikTutar.Size = new System.Drawing.Size(224, 30);
            this.TxtTemizlikTutar.TabIndex = 13;
            // 
            // TxtİcecekTutar
            // 
            this.TxtİcecekTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtİcecekTutar.Location = new System.Drawing.Point(329, 131);
            this.TxtİcecekTutar.Name = "TxtİcecekTutar";
            this.TxtİcecekTutar.Size = new System.Drawing.Size(224, 30);
            this.TxtİcecekTutar.TabIndex = 12;
            // 
            // TxtGidaTutar
            // 
            this.TxtGidaTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGidaTutar.Location = new System.Drawing.Point(329, 27);
            this.TxtGidaTutar.Name = "TxtGidaTutar";
            this.TxtGidaTutar.Size = new System.Drawing.Size(224, 30);
            this.TxtGidaTutar.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Temizlik Malzemeleri Tutarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(172, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "İçecek Tutarı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(187, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gıda Tutarı:";
            // 
            // BtnKaydet2
            // 
            this.BtnKaydet2.BackColor = System.Drawing.Color.White;
            this.BtnKaydet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet2.ForeColor = System.Drawing.Color.Black;
            this.BtnKaydet2.Location = new System.Drawing.Point(299, 306);
            this.BtnKaydet2.Name = "BtnKaydet2";
            this.BtnKaydet2.Size = new System.Drawing.Size(125, 40);
            this.BtnKaydet2.TabIndex = 21;
            this.BtnKaydet2.Text = "Kaydet";
            this.BtnKaydet2.UseVisualStyleBackColor = false;
            this.BtnKaydet2.Click += new System.EventHandler(this.BtnKaydet2_Click);
            // 
            // TxtDogalgaz
            // 
            this.TxtDogalgaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDogalgaz.Location = new System.Drawing.Point(242, 251);
            this.TxtDogalgaz.Name = "TxtDogalgaz";
            this.TxtDogalgaz.Size = new System.Drawing.Size(224, 30);
            this.TxtDogalgaz.TabIndex = 20;
            // 
            // TxtSu
            // 
            this.TxtSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSu.Location = new System.Drawing.Point(242, 144);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Size = new System.Drawing.Size(224, 30);
            this.TxtSu.TabIndex = 19;
            // 
            // TxtElektrik
            // 
            this.TxtElektrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtElektrik.Location = new System.Drawing.Point(242, 40);
            this.TxtElektrik.Name = "TxtElektrik";
            this.TxtElektrik.Size = new System.Drawing.Size(224, 30);
            this.TxtElektrik.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(100, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Doğalgaz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(172, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Su:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(119, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Elektrik:";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(16, 394);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(626, 199);
            this.listView2.TabIndex = 16;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Elektrik";
            this.columnHeader4.Width = 192;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Su";
            this.columnHeader5.Width = 232;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Doğalgaz";
            this.columnHeader6.Width = 234;
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1410, 645);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStoklar";
            this.Text = "FrmStoklar";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtTemizlikTutar;
        private System.Windows.Forms.TextBox TxtİcecekTutar;
        private System.Windows.Forms.TextBox TxtGidaTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button BtnKaydet2;
        private System.Windows.Forms.TextBox TxtDogalgaz;
        private System.Windows.Forms.TextBox TxtSu;
        private System.Windows.Forms.TextBox TxtElektrik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}