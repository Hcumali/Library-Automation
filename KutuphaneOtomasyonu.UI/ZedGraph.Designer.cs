using ZedGraph;

namespace KutuphaneOtomasyonu
{
    partial class ZedGraph
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
            this.Btn_KitapIslemlerineDon_Zed = new System.Windows.Forms.Button();
            this.zedGraphControl = new ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_KitapIslemlerineDon_Zed
            // 
            this.Btn_KitapIslemlerineDon_Zed.BackColor = System.Drawing.Color.Salmon;
            this.Btn_KitapIslemlerineDon_Zed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_KitapIslemlerineDon_Zed.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold);
            this.Btn_KitapIslemlerineDon_Zed.Location = new System.Drawing.Point(970, 616);
            this.Btn_KitapIslemlerineDon_Zed.Name = "Btn_KitapIslemlerineDon_Zed";
            this.Btn_KitapIslemlerineDon_Zed.Size = new System.Drawing.Size(250, 75);
            this.Btn_KitapIslemlerineDon_Zed.TabIndex = 1;
            this.Btn_KitapIslemlerineDon_Zed.Text = "Kitap İşlemlerine Dön";
            this.Btn_KitapIslemlerineDon_Zed.UseVisualStyleBackColor = false;
            this.Btn_KitapIslemlerineDon_Zed.Click += new System.EventHandler(this.Btn_KitapIslemlerineDon_Zed_Click);
            // 
            // zedGraphControl
            // 
            this.zedGraphControl.Location = new System.Drawing.Point(13, 13);
            this.zedGraphControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl.Name = "zedGraphControl";
            this.zedGraphControl.ScrollGrace = 0D;
            this.zedGraphControl.ScrollMaxX = 0D;
            this.zedGraphControl.ScrollMaxY = 0D;
            this.zedGraphControl.ScrollMaxY2 = 0D;
            this.zedGraphControl.ScrollMinX = 0D;
            this.zedGraphControl.ScrollMinY = 0D;
            this.zedGraphControl.ScrollMinY2 = 0D;
            this.zedGraphControl.Size = new System.Drawing.Size(1206, 576);
            this.zedGraphControl.TabIndex = 2;
            this.zedGraphControl.UseExtendedPrintDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(9, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mause tekerleğini kullanarak grafiği yakınlaştırıp, uzaklaştırabilirsiniz.";
            // 
            // ZedGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedGraphControl);
            this.Controls.Add(this.Btn_KitapIslemlerineDon_Zed);
            this.Name = "ZedGraph";
            this.Text = "ZedGraph \\ Mevcut Kitapların Grafikleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ZedGraph_FormClosed);
            this.Load += new System.EventHandler(this.ZedGraph_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_KitapIslemlerineDon_Zed;
        private ZedGraphControl zedGraphControl;
        private System.Windows.Forms.Label label1;
    }
}