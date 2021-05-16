namespace KutuphaneOtomasyonu
{
    partial class KullaniciEkrani
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
            this.Btn_Kullanici_Anasayfa = new System.Windows.Forms.Button();
            this.dataGridView_KullaniciListesi = new System.Windows.Forms.DataGridView();
            this.label_guncelle = new System.Windows.Forms.Label();
            this.textBox_Tcno = new System.Windows.Forms.TextBox();
            this.textBox_Ad = new System.Windows.Forms.TextBox();
            this.textBox_Soyad = new System.Windows.Forms.TextBox();
            this.textBox_Telno = new System.Windows.Forms.TextBox();
            this.textBox_Meslek = new System.Windows.Forms.TextBox();
            this.Btn_Ogrenci_Guncelle = new System.Windows.Forms.Button();
            this.Btn_Ogrenci_Sil = new System.Windows.Forms.Button();
            this.label_Tcno = new System.Windows.Forms.Label();
            this.label_Ad = new System.Windows.Forms.Label();
            this.label_Soyad = new System.Windows.Forms.Label();
            this.label_Telno = new System.Windows.Forms.Label();
            this.label_Meslek = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KullaniciListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Kullanici_Anasayfa
            // 
            this.Btn_Kullanici_Anasayfa.BackColor = System.Drawing.Color.Salmon;
            this.Btn_Kullanici_Anasayfa.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.Btn_Kullanici_Anasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Kullanici_Anasayfa.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold);
            this.Btn_Kullanici_Anasayfa.Location = new System.Drawing.Point(947, 635);
            this.Btn_Kullanici_Anasayfa.Name = "Btn_Kullanici_Anasayfa";
            this.Btn_Kullanici_Anasayfa.Size = new System.Drawing.Size(273, 56);
            this.Btn_Kullanici_Anasayfa.TabIndex = 9;
            this.Btn_Kullanici_Anasayfa.Text = "ANA SAYFAYA DÖN";
            this.Btn_Kullanici_Anasayfa.UseVisualStyleBackColor = false;
            this.Btn_Kullanici_Anasayfa.Click += new System.EventHandler(this.Btn_Kullanici_Anasayfa_Click);
            // 
            // dataGridView_KullaniciListesi
            // 
            this.dataGridView_KullaniciListesi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_KullaniciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KullaniciListesi.Location = new System.Drawing.Point(337, 12);
            this.dataGridView_KullaniciListesi.Name = "dataGridView_KullaniciListesi";
            this.dataGridView_KullaniciListesi.RowHeadersWidth = 51;
            this.dataGridView_KullaniciListesi.RowTemplate.Height = 24;
            this.dataGridView_KullaniciListesi.Size = new System.Drawing.Size(883, 543);
            this.dataGridView_KullaniciListesi.TabIndex = 8;
            this.dataGridView_KullaniciListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KullaniciListesi_CellClick);
            // 
            // label_guncelle
            // 
            this.label_guncelle.AutoSize = true;
            this.label_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_guncelle.Location = new System.Drawing.Point(44, 50);
            this.label_guncelle.Name = "label_guncelle";
            this.label_guncelle.Size = new System.Drawing.Size(118, 24);
            this.label_guncelle.TabIndex = 10;
            this.label_guncelle.Text = "GÜNCELLE";
            // 
            // textBox_Tcno
            // 
            this.textBox_Tcno.Location = new System.Drawing.Point(49, 130);
            this.textBox_Tcno.Name = "textBox_Tcno";
            this.textBox_Tcno.Size = new System.Drawing.Size(114, 22);
            this.textBox_Tcno.TabIndex = 11;
            this.textBox_Tcno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Ad
            // 
            this.textBox_Ad.Location = new System.Drawing.Point(49, 189);
            this.textBox_Ad.Name = "textBox_Ad";
            this.textBox_Ad.Size = new System.Drawing.Size(114, 22);
            this.textBox_Ad.TabIndex = 12;
            this.textBox_Ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Soyad
            // 
            this.textBox_Soyad.Location = new System.Drawing.Point(49, 250);
            this.textBox_Soyad.Name = "textBox_Soyad";
            this.textBox_Soyad.Size = new System.Drawing.Size(114, 22);
            this.textBox_Soyad.TabIndex = 13;
            this.textBox_Soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Telno
            // 
            this.textBox_Telno.Location = new System.Drawing.Point(49, 312);
            this.textBox_Telno.Name = "textBox_Telno";
            this.textBox_Telno.Size = new System.Drawing.Size(114, 22);
            this.textBox_Telno.TabIndex = 14;
            this.textBox_Telno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Meslek
            // 
            this.textBox_Meslek.Location = new System.Drawing.Point(49, 377);
            this.textBox_Meslek.Name = "textBox_Meslek";
            this.textBox_Meslek.Size = new System.Drawing.Size(114, 22);
            this.textBox_Meslek.TabIndex = 15;
            this.textBox_Meslek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_Ogrenci_Guncelle
            // 
            this.Btn_Ogrenci_Guncelle.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_Ogrenci_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Ogrenci_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Ogrenci_Guncelle.Location = new System.Drawing.Point(48, 426);
            this.Btn_Ogrenci_Guncelle.Name = "Btn_Ogrenci_Guncelle";
            this.Btn_Ogrenci_Guncelle.Size = new System.Drawing.Size(115, 45);
            this.Btn_Ogrenci_Guncelle.TabIndex = 16;
            this.Btn_Ogrenci_Guncelle.Text = "GÜNCELLE";
            this.Btn_Ogrenci_Guncelle.UseVisualStyleBackColor = false;
            this.Btn_Ogrenci_Guncelle.Click += new System.EventHandler(this.Btn_Ogrenci_Guncelle_Click);
            // 
            // Btn_Ogrenci_Sil
            // 
            this.Btn_Ogrenci_Sil.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Ogrenci_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Ogrenci_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_Ogrenci_Sil.Location = new System.Drawing.Point(187, 426);
            this.Btn_Ogrenci_Sil.Name = "Btn_Ogrenci_Sil";
            this.Btn_Ogrenci_Sil.Size = new System.Drawing.Size(115, 45);
            this.Btn_Ogrenci_Sil.TabIndex = 17;
            this.Btn_Ogrenci_Sil.Text = "SİL";
            this.Btn_Ogrenci_Sil.UseVisualStyleBackColor = false;
            this.Btn_Ogrenci_Sil.Click += new System.EventHandler(this.Btn_Ogrenci_Sil_Click);
            // 
            // label_Tcno
            // 
            this.label_Tcno.AutoSize = true;
            this.label_Tcno.Location = new System.Drawing.Point(77, 110);
            this.label_Tcno.Name = "label_Tcno";
            this.label_Tcno.Size = new System.Drawing.Size(51, 17);
            this.label_Tcno.TabIndex = 18;
            this.label_Tcno.Text = "TC NO";
            // 
            // label_Ad
            // 
            this.label_Ad.AutoSize = true;
            this.label_Ad.Location = new System.Drawing.Point(87, 169);
            this.label_Ad.Name = "label_Ad";
            this.label_Ad.Size = new System.Drawing.Size(27, 17);
            this.label_Ad.TabIndex = 19;
            this.label_Ad.Text = "AD";
            // 
            // label_Soyad
            // 
            this.label_Soyad.AutoSize = true;
            this.label_Soyad.Location = new System.Drawing.Point(77, 230);
            this.label_Soyad.Name = "label_Soyad";
            this.label_Soyad.Size = new System.Drawing.Size(56, 17);
            this.label_Soyad.TabIndex = 20;
            this.label_Soyad.Text = "SOYAD";
            // 
            // label_Telno
            // 
            this.label_Telno.AutoSize = true;
            this.label_Telno.Location = new System.Drawing.Point(77, 292);
            this.label_Telno.Name = "label_Telno";
            this.label_Telno.Size = new System.Drawing.Size(59, 17);
            this.label_Telno.TabIndex = 21;
            this.label_Telno.Text = "TEL NO";
            // 
            // label_Meslek
            // 
            this.label_Meslek.AutoSize = true;
            this.label_Meslek.Location = new System.Drawing.Point(73, 357);
            this.label_Meslek.Name = "label_Meslek";
            this.label_Meslek.Size = new System.Drawing.Size(63, 17);
            this.label_Meslek.TabIndex = 22;
            this.label_Meslek.Text = "MESLEK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 674);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "NOT: Güncellemek veya silmek istediğiniz öğrencinin üstüne bir kez tıklayınız.";
            // 
            // KullaniciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Meslek);
            this.Controls.Add(this.label_Telno);
            this.Controls.Add(this.label_Soyad);
            this.Controls.Add(this.label_Ad);
            this.Controls.Add(this.label_Tcno);
            this.Controls.Add(this.Btn_Ogrenci_Sil);
            this.Controls.Add(this.Btn_Ogrenci_Guncelle);
            this.Controls.Add(this.textBox_Meslek);
            this.Controls.Add(this.textBox_Telno);
            this.Controls.Add(this.textBox_Soyad);
            this.Controls.Add(this.textBox_Ad);
            this.Controls.Add(this.textBox_Tcno);
            this.Controls.Add(this.label_guncelle);
            this.Controls.Add(this.Btn_Kullanici_Anasayfa);
            this.Controls.Add(this.dataGridView_KullaniciListesi);
            this.Name = "KullaniciEkrani";
            this.Text = "Öğrenci İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KullaniciEkrani_FormClosed);
            this.Load += new System.EventHandler(this.KullaniciEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KullaniciListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Kullanici_Anasayfa;
        private System.Windows.Forms.DataGridView dataGridView_KullaniciListesi;
        private System.Windows.Forms.Label label_guncelle;
        private System.Windows.Forms.TextBox textBox_Tcno;
        private System.Windows.Forms.TextBox textBox_Ad;
        private System.Windows.Forms.TextBox textBox_Soyad;
        private System.Windows.Forms.TextBox textBox_Telno;
        private System.Windows.Forms.TextBox textBox_Meslek;
        private System.Windows.Forms.Button Btn_Ogrenci_Guncelle;
        private System.Windows.Forms.Button Btn_Ogrenci_Sil;
        private System.Windows.Forms.Label label_Tcno;
        private System.Windows.Forms.Label label_Ad;
        private System.Windows.Forms.Label label_Soyad;
        private System.Windows.Forms.Label label_Telno;
        private System.Windows.Forms.Label label_Meslek;
        private System.Windows.Forms.Label label1;
    }
}