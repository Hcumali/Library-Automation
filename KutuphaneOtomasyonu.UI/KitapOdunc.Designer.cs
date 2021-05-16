namespace KutuphaneOtomasyonu
{
    partial class KitapOdunc
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
            this.Btn_AltMenu1 = new System.Windows.Forms.Button();
            this.dataGridView_OduncKitapListesi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SeriNo = new System.Windows.Forms.TextBox();
            this.textBox_KitapIsim = new System.Windows.Forms.TextBox();
            this.textBox_KacGunOduncAlindi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Kitap_OduncAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OduncKitapListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_AltMenu1
            // 
            this.Btn_AltMenu1.BackColor = System.Drawing.Color.Salmon;
            this.Btn_AltMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_AltMenu1.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold);
            this.Btn_AltMenu1.Location = new System.Drawing.Point(970, 616);
            this.Btn_AltMenu1.Name = "Btn_AltMenu1";
            this.Btn_AltMenu1.Size = new System.Drawing.Size(250, 75);
            this.Btn_AltMenu1.TabIndex = 2;
            this.Btn_AltMenu1.Text = "Alt Menüye Dön";
            this.Btn_AltMenu1.UseVisualStyleBackColor = false;
            this.Btn_AltMenu1.Click += new System.EventHandler(this.Btn_AltMenu1_Click);
            // 
            // dataGridView_OduncKitapListesi
            // 
            this.dataGridView_OduncKitapListesi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_OduncKitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OduncKitapListesi.Location = new System.Drawing.Point(355, 12);
            this.dataGridView_OduncKitapListesi.Name = "dataGridView_OduncKitapListesi";
            this.dataGridView_OduncKitapListesi.RowHeadersWidth = 51;
            this.dataGridView_OduncKitapListesi.RowTemplate.Height = 24;
            this.dataGridView_OduncKitapListesi.Size = new System.Drawing.Size(865, 500);
            this.dataGridView_OduncKitapListesi.TabIndex = 3;
            this.dataGridView_OduncKitapListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_OduncKitapListesi_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(81, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ödünç Kitap Al";
            // 
            // textBox_SeriNo
            // 
            this.textBox_SeriNo.Location = new System.Drawing.Point(86, 161);
            this.textBox_SeriNo.Name = "textBox_SeriNo";
            this.textBox_SeriNo.Size = new System.Drawing.Size(139, 22);
            this.textBox_SeriNo.TabIndex = 5;
            this.textBox_SeriNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_KitapIsim
            // 
            this.textBox_KitapIsim.Location = new System.Drawing.Point(86, 238);
            this.textBox_KitapIsim.Name = "textBox_KitapIsim";
            this.textBox_KitapIsim.Size = new System.Drawing.Size(139, 22);
            this.textBox_KitapIsim.TabIndex = 7;
            this.textBox_KitapIsim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_KacGunOduncAlindi
            // 
            this.textBox_KacGunOduncAlindi.Location = new System.Drawing.Point(86, 359);
            this.textBox_KacGunOduncAlindi.Name = "textBox_KacGunOduncAlindi";
            this.textBox_KacGunOduncAlindi.Size = new System.Drawing.Size(139, 22);
            this.textBox_KacGunOduncAlindi.TabIndex = 8;
            this.textBox_KacGunOduncAlindi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(12, 653);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(761, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "NOT: Almak istediğiniz kitabın üstüne bir kez tıklayınız ve kaç gün almak istediğ" +
    "inizi yazınız.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(128, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seri No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(118, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kitap İsmi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(35, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 12;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Kitap_OduncAl
            // 
            this.Btn_Kitap_OduncAl.BackColor = System.Drawing.Color.Turquoise;
            this.Btn_Kitap_OduncAl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Kitap_OduncAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Kitap_OduncAl.Location = new System.Drawing.Point(86, 429);
            this.Btn_Kitap_OduncAl.Name = "Btn_Kitap_OduncAl";
            this.Btn_Kitap_OduncAl.Size = new System.Drawing.Size(139, 45);
            this.Btn_Kitap_OduncAl.TabIndex = 43;
            this.Btn_Kitap_OduncAl.Text = "Ödünç Al";
            this.Btn_Kitap_OduncAl.UseVisualStyleBackColor = false;
            this.Btn_Kitap_OduncAl.Click += new System.EventHandler(this.Btn_Kitap_OduncAl_Click);
            // 
            // KitapOdunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.Btn_Kitap_OduncAl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_KacGunOduncAlindi);
            this.Controls.Add(this.textBox_KitapIsim);
            this.Controls.Add(this.textBox_SeriNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_OduncKitapListesi);
            this.Controls.Add(this.Btn_AltMenu1);
            this.Name = "KitapOdunc";
            this.Text = "Kitap Ödünç Alma Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KitapOdunc_FormClosed);
            this.Load += new System.EventHandler(this.KitapOdunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OduncKitapListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_AltMenu1;
        private System.Windows.Forms.DataGridView dataGridView_OduncKitapListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SeriNo;
        private System.Windows.Forms.TextBox textBox_KitapIsim;
        private System.Windows.Forms.TextBox textBox_KacGunOduncAlindi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Kitap_OduncAl;
    }
}