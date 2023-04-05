namespace kutuphanesotomasyonmsql
{
    partial class uyeislempanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_uyebilgiguncelle = new System.Windows.Forms.Button();
            this.btn_uyeekle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_uyebilgiguncelle);
            this.panel1.Controls.Add(this.btn_uyeekle);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 450);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(3, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 43);
            this.button3.TabIndex = 0;
            this.button3.Text = "GERİ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_uyebilgiguncelle
            // 
            this.btn_uyebilgiguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyebilgiguncelle.Location = new System.Drawing.Point(3, 290);
            this.btn_uyebilgiguncelle.Name = "btn_uyebilgiguncelle";
            this.btn_uyebilgiguncelle.Size = new System.Drawing.Size(128, 44);
            this.btn_uyebilgiguncelle.TabIndex = 0;
            this.btn_uyebilgiguncelle.Text = "GÜNCELLE";
            this.btn_uyebilgiguncelle.UseVisualStyleBackColor = true;
            this.btn_uyebilgiguncelle.Click += new System.EventHandler(this.btn_uyebilgiguncelle_Click);
            // 
            // btn_uyeekle
            // 
            this.btn_uyeekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeekle.Location = new System.Drawing.Point(3, 181);
            this.btn_uyeekle.Name = "btn_uyeekle";
            this.btn_uyeekle.Size = new System.Drawing.Size(128, 43);
            this.btn_uyeekle.TabIndex = 0;
            this.btn_uyeekle.Text = "ÜYE EKLE";
            this.btn_uyeekle.UseVisualStyleBackColor = true;
            this.btn_uyeekle.Click += new System.EventHandler(this.btn_uyeekle_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.Location = new System.Drawing.Point(137, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 449);
            this.panel2.TabIndex = 2;
            // 
            // uyeislempanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "uyeislempanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜYE İŞLEMLERİ";
            this.Load += new System.EventHandler(this.uyeislempanel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_uyebilgiguncelle;
        private System.Windows.Forms.Button btn_uyeekle;
        private System.Windows.Forms.Panel panel2;
    }
}