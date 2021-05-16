namespace KutuphaneOtomasyonu
{
    partial class KitapOduncIade
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
            this.Btn_KitapIslemlerineDon2 = new System.Windows.Forms.Button();
            this.Btn_Odunc = new System.Windows.Forms.Button();
            this.Btn_Iade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_KitapIslemlerineDon2
            // 
            this.Btn_KitapIslemlerineDon2.BackColor = System.Drawing.Color.Salmon;
            this.Btn_KitapIslemlerineDon2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_KitapIslemlerineDon2.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold);
            this.Btn_KitapIslemlerineDon2.Location = new System.Drawing.Point(490, 568);
            this.Btn_KitapIslemlerineDon2.Name = "Btn_KitapIslemlerineDon2";
            this.Btn_KitapIslemlerineDon2.Size = new System.Drawing.Size(250, 75);
            this.Btn_KitapIslemlerineDon2.TabIndex = 1;
            this.Btn_KitapIslemlerineDon2.Text = "Kitap İşlemlerine Dön";
            this.Btn_KitapIslemlerineDon2.UseVisualStyleBackColor = false;
            this.Btn_KitapIslemlerineDon2.Click += new System.EventHandler(this.Btn_KitapIslemlerineDon2_Click);
            // 
            // Btn_Odunc
            // 
            this.Btn_Odunc.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Odunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Odunc.Font = new System.Drawing.Font("Arial Unicode MS", 24F, System.Drawing.FontStyle.Bold);
            this.Btn_Odunc.Location = new System.Drawing.Point(250, 164);
            this.Btn_Odunc.Name = "Btn_Odunc";
            this.Btn_Odunc.Size = new System.Drawing.Size(300, 300);
            this.Btn_Odunc.TabIndex = 8;
            this.Btn_Odunc.Text = "ÖDÜNÇ ALMAK İSTİYORUM";
            this.Btn_Odunc.UseVisualStyleBackColor = false;
            this.Btn_Odunc.Click += new System.EventHandler(this.Btn_Odunc_Click);
            // 
            // Btn_Iade
            // 
            this.Btn_Iade.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Iade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Iade.Font = new System.Drawing.Font("Arial Unicode MS", 24F, System.Drawing.FontStyle.Bold);
            this.Btn_Iade.Location = new System.Drawing.Point(683, 164);
            this.Btn_Iade.Name = "Btn_Iade";
            this.Btn_Iade.Size = new System.Drawing.Size(300, 300);
            this.Btn_Iade.TabIndex = 9;
            this.Btn_Iade.Text = "İADE ETMEK İSTİYORUM";
            this.Btn_Iade.UseVisualStyleBackColor = false;
            this.Btn_Iade.Click += new System.EventHandler(this.Btn_Iade_Click);
            // 
            // KitapOduncIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.library2_1;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.Btn_Iade);
            this.Controls.Add(this.Btn_Odunc);
            this.Controls.Add(this.Btn_KitapIslemlerineDon2);
            this.Name = "KitapOduncIade";
            this.Text = "Kitap / Ödünç - İade";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KitapOdunc_FormClosed);
            this.Load += new System.EventHandler(this.KitapOdunc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_KitapIslemlerineDon2;
        private System.Windows.Forms.Button Btn_Odunc;
        private System.Windows.Forms.Button Btn_Iade;
    }
}