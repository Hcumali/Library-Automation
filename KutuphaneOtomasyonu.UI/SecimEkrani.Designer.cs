namespace KutuphaneOtomasyonu
{
    partial class SecimEkrani
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
            this.label_welcome_username = new System.Windows.Forms.Label();
            this.Btn_SecimEkrani_cikis = new System.Windows.Forms.Button();
            this.Btn_Kitap = new System.Windows.Forms.Button();
            this.Btn_Ogrenci = new System.Windows.Forms.Button();
            this.label_ogrenci_borc = new System.Windows.Forms.Label();
            this.dataGridView_borc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_borc)).BeginInit();
            this.SuspendLayout();
            // 
            // label_welcome_username
            // 
            this.label_welcome_username.AutoSize = true;
            this.label_welcome_username.BackColor = System.Drawing.Color.Peru;
            this.label_welcome_username.Font = new System.Drawing.Font("Arial Unicode MS", 20F, System.Drawing.FontStyle.Bold);
            this.label_welcome_username.Location = new System.Drawing.Point(411, 37);
            this.label_welcome_username.Name = "label_welcome_username";
            this.label_welcome_username.Size = new System.Drawing.Size(0, 45);
            this.label_welcome_username.TabIndex = 10;
            // 
            // Btn_SecimEkrani_cikis
            // 
            this.Btn_SecimEkrani_cikis.BackColor = System.Drawing.Color.Salmon;
            this.Btn_SecimEkrani_cikis.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.Btn_SecimEkrani_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_SecimEkrani_cikis.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_SecimEkrani_cikis.Location = new System.Drawing.Point(475, 533);
            this.Btn_SecimEkrani_cikis.Name = "Btn_SecimEkrani_cikis";
            this.Btn_SecimEkrani_cikis.Size = new System.Drawing.Size(294, 76);
            this.Btn_SecimEkrani_cikis.TabIndex = 9;
            this.Btn_SecimEkrani_cikis.Text = "ÇIKIŞ";
            this.Btn_SecimEkrani_cikis.UseVisualStyleBackColor = false;
            this.Btn_SecimEkrani_cikis.Click += new System.EventHandler(this.Btn_SecimEkrani_cikis_Click);
            // 
            // Btn_Kitap
            // 
            this.Btn_Kitap.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Kitap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Kitap.FlatAppearance.BorderSize = 3;
            this.Btn_Kitap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Btn_Kitap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.Btn_Kitap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Kitap.Font = new System.Drawing.Font("Arial Unicode MS", 40F, System.Drawing.FontStyle.Bold);
            this.Btn_Kitap.Location = new System.Drawing.Point(680, 197);
            this.Btn_Kitap.Name = "Btn_Kitap";
            this.Btn_Kitap.Size = new System.Drawing.Size(400, 250);
            this.Btn_Kitap.TabIndex = 8;
            this.Btn_Kitap.Text = "Kitap İşlemleri";
            this.Btn_Kitap.UseVisualStyleBackColor = false;
            this.Btn_Kitap.Click += new System.EventHandler(this.Btn_Kitap_Click);
            // 
            // Btn_Ogrenci
            // 
            this.Btn_Ogrenci.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Ogrenci.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Ogrenci.FlatAppearance.BorderSize = 3;
            this.Btn_Ogrenci.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Btn_Ogrenci.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.Btn_Ogrenci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ogrenci.Font = new System.Drawing.Font("Arial Unicode MS", 40F, System.Drawing.FontStyle.Bold);
            this.Btn_Ogrenci.Location = new System.Drawing.Point(144, 197);
            this.Btn_Ogrenci.Name = "Btn_Ogrenci";
            this.Btn_Ogrenci.Size = new System.Drawing.Size(400, 250);
            this.Btn_Ogrenci.TabIndex = 7;
            this.Btn_Ogrenci.Text = "Öğrenci İşlemleri";
            this.Btn_Ogrenci.UseVisualStyleBackColor = false;
            this.Btn_Ogrenci.Click += new System.EventHandler(this.Btn_Ogrenci_Click);
            // 
            // label_ogrenci_borc
            // 
            this.label_ogrenci_borc.AutoSize = true;
            this.label_ogrenci_borc.BackColor = System.Drawing.Color.PowderBlue;
            this.label_ogrenci_borc.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold);
            this.label_ogrenci_borc.Location = new System.Drawing.Point(377, 110);
            this.label_ogrenci_borc.Name = "label_ogrenci_borc";
            this.label_ogrenci_borc.Size = new System.Drawing.Size(0, 26);
            this.label_ogrenci_borc.TabIndex = 11;
            // 
            // dataGridView_borc
            // 
            this.dataGridView_borc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_borc.Location = new System.Drawing.Point(891, 484);
            this.dataGridView_borc.Name = "dataGridView_borc";
            this.dataGridView_borc.RowHeadersWidth = 51;
            this.dataGridView_borc.RowTemplate.Height = 24;
            this.dataGridView_borc.Size = new System.Drawing.Size(0, 0);
            this.dataGridView_borc.TabIndex = 12;
            // 
            // SecimEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.library;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.dataGridView_borc);
            this.Controls.Add(this.label_ogrenci_borc);
            this.Controls.Add(this.label_welcome_username);
            this.Controls.Add(this.Btn_SecimEkrani_cikis);
            this.Controls.Add(this.Btn_Kitap);
            this.Controls.Add(this.Btn_Ogrenci);
            this.Name = "SecimEkrani";
            this.Text = "Seçim Ekranı";
            this.Load += new System.EventHandler(this.SecimEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_borc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome_username;
        private System.Windows.Forms.Button Btn_SecimEkrani_cikis;
        private System.Windows.Forms.Button Btn_Kitap;
        private System.Windows.Forms.Button Btn_Ogrenci;
        private System.Windows.Forms.Label label_ogrenci_borc;
        private System.Windows.Forms.DataGridView dataGridView_borc;
    }
}