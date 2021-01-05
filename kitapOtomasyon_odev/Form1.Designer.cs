namespace kitapOtomasyon_odev
{
    partial class Form1
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
            this.txt_kitapAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_yazarAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kitapTuru = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_yazarSoyadi = new System.Windows.Forms.TextBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.txt_kayitAra = new System.Windows.Forms.TextBox();
            this.btn_kayitAra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_kitapAdi = new System.Windows.Forms.Label();
            this.lbl_kitapTuru = new System.Windows.Forms.Label();
            this.lbl_yazarAdi = new System.Windows.Forms.Label();
            this.lbl_yazarSoyadi = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_EnBasaDon = new System.Windows.Forms.Button();
            this.btn_EnSonEklenen = new System.Windows.Forms.Button();
            this.btn_birOncekiKayit = new System.Windows.Forms.Button();
            this.btn_birSonrakiKayit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_uyari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_kitapAdi
            // 
            this.txt_kitapAdi.Location = new System.Drawing.Point(126, 45);
            this.txt_kitapAdi.Name = "txt_kitapAdi";
            this.txt_kitapAdi.Size = new System.Drawing.Size(162, 22);
            this.txt_kitapAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazar Adı :";
            // 
            // txt_yazarAdi
            // 
            this.txt_yazarAdi.Location = new System.Drawing.Point(126, 94);
            this.txt_yazarAdi.Name = "txt_yazarAdi";
            this.txt_yazarAdi.Size = new System.Drawing.Size(162, 22);
            this.txt_yazarAdi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kitap Türü :";
            // 
            // txt_kitapTuru
            // 
            this.txt_kitapTuru.Location = new System.Drawing.Point(451, 43);
            this.txt_kitapTuru.Name = "txt_kitapTuru";
            this.txt_kitapTuru.Size = new System.Drawing.Size(162, 22);
            this.txt_kitapTuru.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yazar Soyadı :";
            // 
            // txt_yazarSoyadi
            // 
            this.txt_yazarSoyadi.Location = new System.Drawing.Point(451, 97);
            this.txt_yazarSoyadi.Name = "txt_yazarSoyadi";
            this.txt_yazarSoyadi.Size = new System.Drawing.Size(162, 22);
            this.txt_yazarSoyadi.TabIndex = 3;
            // 
            // btn_kayit
            // 
            this.btn_kayit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayit.Location = new System.Drawing.Point(148, 144);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(391, 46);
            this.btn_kayit.TabIndex = 4;
            this.btn_kayit.Text = "KAYIT ET";
            this.btn_kayit.UseVisualStyleBackColor = false;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // txt_kayitAra
            // 
            this.txt_kayitAra.Location = new System.Drawing.Point(148, 211);
            this.txt_kayitAra.Multiline = true;
            this.txt_kayitAra.Name = "txt_kayitAra";
            this.txt_kayitAra.Size = new System.Drawing.Size(174, 33);
            this.txt_kayitAra.TabIndex = 5;
            // 
            // btn_kayitAra
            // 
            this.btn_kayitAra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_kayitAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitAra.Location = new System.Drawing.Point(344, 211);
            this.btn_kayitAra.Name = "btn_kayitAra";
            this.btn_kayitAra.Size = new System.Drawing.Size(195, 33);
            this.btn_kayitAra.TabIndex = 6;
            this.btn_kayitAra.Text = "KAYIT ARA";
            this.btn_kayitAra.UseVisualStyleBackColor = false;
            this.btn_kayitAra.Click += new System.EventHandler(this.btn_kayitAra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(122, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kitap Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(117, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Yazar Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(111, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kitap Türü :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(88, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Yazar Soyadı :";
            // 
            // lbl_kitapAdi
            // 
            this.lbl_kitapAdi.AutoSize = true;
            this.lbl_kitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kitapAdi.Location = new System.Drawing.Point(248, 326);
            this.lbl_kitapAdi.Name = "lbl_kitapAdi";
            this.lbl_kitapAdi.Size = new System.Drawing.Size(0, 20);
            this.lbl_kitapAdi.TabIndex = 16;
            // 
            // lbl_kitapTuru
            // 
            this.lbl_kitapTuru.AutoSize = true;
            this.lbl_kitapTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kitapTuru.Location = new System.Drawing.Point(248, 364);
            this.lbl_kitapTuru.Name = "lbl_kitapTuru";
            this.lbl_kitapTuru.Size = new System.Drawing.Size(0, 20);
            this.lbl_kitapTuru.TabIndex = 17;
            // 
            // lbl_yazarAdi
            // 
            this.lbl_yazarAdi.AutoSize = true;
            this.lbl_yazarAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazarAdi.Location = new System.Drawing.Point(248, 405);
            this.lbl_yazarAdi.Name = "lbl_yazarAdi";
            this.lbl_yazarAdi.Size = new System.Drawing.Size(0, 20);
            this.lbl_yazarAdi.TabIndex = 18;
            // 
            // lbl_yazarSoyadi
            // 
            this.lbl_yazarSoyadi.AutoSize = true;
            this.lbl_yazarSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazarSoyadi.Location = new System.Drawing.Point(248, 442);
            this.lbl_yazarSoyadi.Name = "lbl_yazarSoyadi";
            this.lbl_yazarSoyadi.Size = new System.Drawing.Size(0, 20);
            this.lbl_yazarSoyadi.TabIndex = 19;
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(453, 506);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(138, 33);
            this.btn_sil.TabIndex = 11;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_EnBasaDon
            // 
            this.btn_EnBasaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_EnBasaDon.Location = new System.Drawing.Point(37, 507);
            this.btn_EnBasaDon.Name = "btn_EnBasaDon";
            this.btn_EnBasaDon.Size = new System.Drawing.Size(75, 30);
            this.btn_EnBasaDon.TabIndex = 7;
            this.btn_EnBasaDon.Text = "| <";
            this.btn_EnBasaDon.UseVisualStyleBackColor = true;
            this.btn_EnBasaDon.Click += new System.EventHandler(this.btn_EnBasaDon_Click);
            // 
            // btn_EnSonEklenen
            // 
            this.btn_EnSonEklenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_EnSonEklenen.Location = new System.Drawing.Point(355, 506);
            this.btn_EnSonEklenen.Name = "btn_EnSonEklenen";
            this.btn_EnSonEklenen.Size = new System.Drawing.Size(75, 30);
            this.btn_EnSonEklenen.TabIndex = 10;
            this.btn_EnSonEklenen.Text = "> |";
            this.btn_EnSonEklenen.UseVisualStyleBackColor = true;
            this.btn_EnSonEklenen.Click += new System.EventHandler(this.btn_EnSonEklenen_Click);
            // 
            // btn_birOncekiKayit
            // 
            this.btn_birOncekiKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_birOncekiKayit.Location = new System.Drawing.Point(143, 506);
            this.btn_birOncekiKayit.Name = "btn_birOncekiKayit";
            this.btn_birOncekiKayit.Size = new System.Drawing.Size(75, 30);
            this.btn_birOncekiKayit.TabIndex = 8;
            this.btn_birOncekiKayit.Text = "<<";
            this.btn_birOncekiKayit.UseVisualStyleBackColor = true;
            this.btn_birOncekiKayit.Click += new System.EventHandler(this.btn_birOncekiKayit_Click);
            // 
            // btn_birSonrakiKayit
            // 
            this.btn_birSonrakiKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_birSonrakiKayit.Location = new System.Drawing.Point(253, 506);
            this.btn_birSonrakiKayit.Name = "btn_birSonrakiKayit";
            this.btn_birSonrakiKayit.Size = new System.Drawing.Size(75, 30);
            this.btn_birSonrakiKayit.TabIndex = 9;
            this.btn_birSonrakiKayit.Text = ">>";
            this.btn_birSonrakiKayit.UseVisualStyleBackColor = true;
            this.btn_birSonrakiKayit.Click += new System.EventHandler(this.btn_birSonrakiKayit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(7, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 34);
            this.label9.TabIndex = 20;
            this.label9.Text = "Aramak İstediğiniz\r\nKitap Adını Giriniz :\r\n";
            // 
            // lbl_uyari
            // 
            this.lbl_uyari.AutoSize = true;
            this.lbl_uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_uyari.Location = new System.Drawing.Point(151, 277);
            this.lbl_uyari.Name = "lbl_uyari";
            this.lbl_uyari.Size = new System.Drawing.Size(0, 20);
            this.lbl_uyari.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 568);
            this.Controls.Add(this.lbl_uyari);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_birSonrakiKayit);
            this.Controls.Add(this.btn_birOncekiKayit);
            this.Controls.Add(this.btn_EnSonEklenen);
            this.Controls.Add(this.btn_EnBasaDon);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.lbl_yazarSoyadi);
            this.Controls.Add(this.lbl_yazarAdi);
            this.Controls.Add(this.lbl_kitapTuru);
            this.Controls.Add(this.lbl_kitapAdi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_kayitAra);
            this.Controls.Add(this.txt_kayitAra);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_yazarSoyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_kitapTuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_yazarAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kitapAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_kitapAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_yazarAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kitapTuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_yazarSoyadi;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.TextBox txt_kayitAra;
        private System.Windows.Forms.Button btn_kayitAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_kitapAdi;
        private System.Windows.Forms.Label lbl_kitapTuru;
        private System.Windows.Forms.Label lbl_yazarAdi;
        private System.Windows.Forms.Label lbl_yazarSoyadi;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_EnBasaDon;
        private System.Windows.Forms.Button btn_EnSonEklenen;
        private System.Windows.Forms.Button btn_birOncekiKayit;
        private System.Windows.Forms.Button btn_birSonrakiKayit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_uyari;
    }
}

