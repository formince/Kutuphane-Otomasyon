namespace kutuphanesotomasyonmsql
{
    partial class yoneticiislemleri
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
            this.btn_kitapekle = new System.Windows.Forms.Button();
            this.btn_kitapstok = new System.Windows.Forms.Button();
            this.GERİ = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kitapekle
            // 
            this.btn_kitapekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapekle.Location = new System.Drawing.Point(0, 230);
            this.btn_kitapekle.Name = "btn_kitapekle";
            this.btn_kitapekle.Size = new System.Drawing.Size(133, 40);
            this.btn_kitapekle.TabIndex = 0;
            this.btn_kitapekle.Text = "KİTAP EKLE";
            this.btn_kitapekle.UseVisualStyleBackColor = true;
            this.btn_kitapekle.Click += new System.EventHandler(this.btn_kitapekle_Click);
            // 
            // btn_kitapstok
            // 
            this.btn_kitapstok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapstok.Location = new System.Drawing.Point(-1, 134);
            this.btn_kitapstok.Name = "btn_kitapstok";
            this.btn_kitapstok.Size = new System.Drawing.Size(134, 40);
            this.btn_kitapstok.TabIndex = 0;
            this.btn_kitapstok.Text = "KİTAP GÜNCELLE";
            this.btn_kitapstok.UseVisualStyleBackColor = true;
            this.btn_kitapstok.Click += new System.EventHandler(this.btn_kitapstok_Click);
            // 
            // GERİ
            // 
            this.GERİ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GERİ.Location = new System.Drawing.Point(0, 42);
            this.GERİ.Name = "GERİ";
            this.GERİ.Size = new System.Drawing.Size(133, 40);
            this.GERİ.TabIndex = 0;
            this.GERİ.Text = "GERİ";
            this.GERİ.UseVisualStyleBackColor = true;
            this.GERİ.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Location = new System.Drawing.Point(133, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 447);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.Controls.Add(this.btn_kitapekle);
            this.panel2.Controls.Add(this.btn_kitapstok);
            this.panel2.Controls.Add(this.GERİ);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 447);
            this.panel2.TabIndex = 0;
            // 
            // yoneticiislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "yoneticiislemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KİTAP İŞLEMLERİ";
            this.Load += new System.EventHandler(this.yoneticiislemleri_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kitapekle;
        private System.Windows.Forms.Button btn_kitapstok;
        private System.Windows.Forms.Button GERİ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}