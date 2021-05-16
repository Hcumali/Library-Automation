namespace KutuphaneOtomasyonu
{
    partial class KitapIade
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
            this.Btn_AltMenu2 = new System.Windows.Forms.Button();
            this.dataGridView_IadeKitapListesi = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Iade_KitapIsim = new System.Windows.Forms.TextBox();
            this.textBox_Iade_SeriNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Kitap_iadeEt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_IadeKitapListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_AltMenu2
            // 
            this.Btn_AltMenu2.BackColor = System.Drawing.Color.Salmon;
            this.Btn_AltMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_AltMenu2.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold);
            this.Btn_AltMenu2.Location = new System.Drawing.Point(970, 616);
            this.Btn_AltMenu2.Name = "Btn_AltMenu2";
            this.Btn_AltMenu2.Size = new System.Drawing.Size(250, 75);
            this.Btn_AltMenu2.TabIndex = 3;
            this.Btn_AltMenu2.Text = "Alt Menüye Dön";
            this.Btn_AltMenu2.UseVisualStyleBackColor = false;
            this.Btn_AltMenu2.Click += new System.EventHandler(this.Btn_AltMenu2_Click);
            // 
            // dataGridView_IadeKitapListesi
            // 
            this.dataGridView_IadeKitapListesi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_IadeKitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_IadeKitapListesi.Location = new System.Drawing.Point(355, 12);
            this.dataGridView_IadeKitapListesi.Name = "dataGridView_IadeKitapListesi";
            this.dataGridView_IadeKitapListesi.RowHeadersWidth = 90;
            this.dataGridView_IadeKitapListesi.RowTemplate.Height = 24;
            this.dataGridView_IadeKitapListesi.Size = new System.Drawing.Size(865, 500);
            this.dataGridView_IadeKitapListesi.TabIndex = 4;
            this.dataGridView_IadeKitapListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_IadeKitapListesi_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(126, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kitap İsmi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(136, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Seri No";
            // 
            // textBox_Iade_KitapIsim
            // 
            this.textBox_Iade_KitapIsim.Location = new System.Drawing.Point(94, 234);
            this.textBox_Iade_KitapIsim.Name = "textBox_Iade_KitapIsim";
            this.textBox_Iade_KitapIsim.Size = new System.Drawing.Size(139, 22);
            this.textBox_Iade_KitapIsim.TabIndex = 14;
            this.textBox_Iade_KitapIsim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Iade_SeriNo
            // 
            this.textBox_Iade_SeriNo.Location = new System.Drawing.Point(94, 153);
            this.textBox_Iade_SeriNo.Name = "textBox_Iade_SeriNo";
            this.textBox_Iade_SeriNo.Size = new System.Drawing.Size(139, 22);
            this.textBox_Iade_SeriNo.TabIndex = 13;
            this.textBox_Iade_SeriNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(98, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kitap İade Et";
            // 
            // Btn_Kitap_iadeEt
            // 
            this.Btn_Kitap_iadeEt.BackColor = System.Drawing.Color.Turquoise;
            this.Btn_Kitap_iadeEt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Kitap_iadeEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Kitap_iadeEt.Location = new System.Drawing.Point(94, 307);
            this.Btn_Kitap_iadeEt.Name = "Btn_Kitap_iadeEt";
            this.Btn_Kitap_iadeEt.Size = new System.Drawing.Size(139, 45);
            this.Btn_Kitap_iadeEt.TabIndex = 44;
            this.Btn_Kitap_iadeEt.Text = "İade Et";
            this.Btn_Kitap_iadeEt.UseVisualStyleBackColor = false;
            this.Btn_Kitap_iadeEt.Click += new System.EventHandler(this.Btn_Kitap_iadeEt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(12, 667);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(649, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "NOT: İade etmek istediğiniz kitabın üstüne bir kez tıklayınız ve butona basınız.";
            // 
            // KitapIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Kitap_iadeEt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Iade_KitapIsim);
            this.Controls.Add(this.textBox_Iade_SeriNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_IadeKitapListesi);
            this.Controls.Add(this.Btn_AltMenu2);
            this.Name = "KitapIade";
            this.Text = "Kitap İade Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KitapIade_FormClosed);
            this.Load += new System.EventHandler(this.KitapIade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_IadeKitapListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_AltMenu2;
        private System.Windows.Forms.DataGridView dataGridView_IadeKitapListesi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Iade_KitapIsim;
        private System.Windows.Forms.TextBox textBox_Iade_SeriNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Kitap_iadeEt;
        private System.Windows.Forms.Label label2;
    }
}