namespace KutuphaneOtomasyonu
{
    partial class OgrenciKitapProfilEkrani
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
            this.Btn_KitapIslemlerineDon4 = new System.Windows.Forms.Button();
            this.dataGridView_OgrenciKitapProfili = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OgrenciKitapProfili)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_KitapIslemlerineDon4
            // 
            this.Btn_KitapIslemlerineDon4.BackColor = System.Drawing.Color.Salmon;
            this.Btn_KitapIslemlerineDon4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_KitapIslemlerineDon4.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold);
            this.Btn_KitapIslemlerineDon4.Location = new System.Drawing.Point(970, 616);
            this.Btn_KitapIslemlerineDon4.Name = "Btn_KitapIslemlerineDon4";
            this.Btn_KitapIslemlerineDon4.Size = new System.Drawing.Size(250, 75);
            this.Btn_KitapIslemlerineDon4.TabIndex = 5;
            this.Btn_KitapIslemlerineDon4.Text = "Kitap İşlemlerine Dön";
            this.Btn_KitapIslemlerineDon4.UseVisualStyleBackColor = false;
            this.Btn_KitapIslemlerineDon4.Click += new System.EventHandler(this.Btn_KitapIslemlerineDon4_Click);
            // 
            // dataGridView_OgrenciKitapProfili
            // 
            this.dataGridView_OgrenciKitapProfili.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_OgrenciKitapProfili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OgrenciKitapProfili.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_OgrenciKitapProfili.Name = "dataGridView_OgrenciKitapProfili";
            this.dataGridView_OgrenciKitapProfili.RowHeadersWidth = 51;
            this.dataGridView_OgrenciKitapProfili.RowTemplate.Height = 24;
            this.dataGridView_OgrenciKitapProfili.Size = new System.Drawing.Size(1208, 580);
            this.dataGridView_OgrenciKitapProfili.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yeşil Renk: Teslim Edilmiş Kitap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(325, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sarı Renk: Teslim Tarihine 2 Gün Kalmış Kitap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 666);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kırmızı Renk: Teslim Tarihi Geçmiş Kitap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(402, 666);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Beyaz Renk: Teslim Tarihi Geçmemiş Kitap";
            // 
            // OgrenciKitapProfilEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_OgrenciKitapProfili);
            this.Controls.Add(this.Btn_KitapIslemlerineDon4);
            this.Name = "OgrenciKitapProfilEkrani";
            this.Text = "Öğrenci - Kitap Profili Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OgrenciKitapProfilEkrani_FormClosed);
            this.Load += new System.EventHandler(this.OgrenciKitapProfilEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OgrenciKitapProfili)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_KitapIslemlerineDon4;
        private System.Windows.Forms.DataGridView dataGridView_OgrenciKitapProfili;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}