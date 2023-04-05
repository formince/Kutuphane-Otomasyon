namespace kutuphanesotomasyonmsql
{
    partial class kitapodunc
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
            this.txt_uye = new System.Windows.Forms.TextBox();
            this.txt_kitap = new System.Windows.Forms.TextBox();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_al = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_kitapara = new System.Windows.Forms.Button();
            this.btn_uyeara = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_temizleuye = new System.Windows.Forms.Button();
            this.btn_temizlekitap = new System.Windows.Forms.Button();
            this.label_uye = new System.Windows.Forms.Label();
            this.label_kitap = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.lbl_kitap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_uye
            // 
            this.txt_uye.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_uye.Location = new System.Drawing.Point(139, 67);
            this.txt_uye.Name = "txt_uye";
            this.txt_uye.Size = new System.Drawing.Size(182, 22);
            this.txt_uye.TabIndex = 0;
            // 
            // txt_kitap
            // 
            this.txt_kitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitap.Location = new System.Drawing.Point(801, 64);
            this.txt_kitap.Name = "txt_kitap";
            this.txt_kitap.Size = new System.Drawing.Size(146, 22);
            this.txt_kitap.TabIndex = 0;
            // 
            // txt_adet
            // 
            this.txt_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adet.Location = new System.Drawing.Point(1131, 64);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(100, 22);
            this.txt_adet.TabIndex = 0;
            this.txt_adet.Text = "1";
            this.txt_adet.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(606, 345);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(625, 108);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(606, 345);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btn_al
            // 
            this.btn_al.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_al.Location = new System.Drawing.Point(1131, 463);
            this.btn_al.Name = "btn_al";
            this.btn_al.Size = new System.Drawing.Size(100, 44);
            this.btn_al.TabIndex = 3;
            this.btn_al.Text = "ÖDÜNÇ VER";
            this.btn_al.UseVisualStyleBackColor = true;
            this.btn_al.Click += new System.EventHandler(this.btn_al_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "ÜYE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(833, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "KİTAP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1155, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "ADET";
            this.label3.Visible = false;
            // 
            // btn_kitapara
            // 
            this.btn_kitapara.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapara.Location = new System.Drawing.Point(964, 56);
            this.btn_kitapara.Name = "btn_kitapara";
            this.btn_kitapara.Size = new System.Drawing.Size(100, 30);
            this.btn_kitapara.TabIndex = 5;
            this.btn_kitapara.Text = "ARA";
            this.btn_kitapara.UseVisualStyleBackColor = true;
            this.btn_kitapara.Click += new System.EventHandler(this.btn_kitapara_Click);
            // 
            // btn_uyeara
            // 
            this.btn_uyeara.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeara.Location = new System.Drawing.Point(400, 59);
            this.btn_uyeara.Name = "btn_uyeara";
            this.btn_uyeara.Size = new System.Drawing.Size(100, 30);
            this.btn_uyeara.TabIndex = 5;
            this.btn_uyeara.Text = "ARA";
            this.btn_uyeara.UseVisualStyleBackColor = true;
            this.btn_uyeara.Click += new System.EventHandler(this.btn_uyeara_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(0, -1);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(100, 30);
            this.btn_geri.TabIndex = 6;
            this.btn_geri.Text = "GERİ";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_temizleuye
            // 
            this.btn_temizleuye.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizleuye.Location = new System.Drawing.Point(0, 59);
            this.btn_temizleuye.Name = "btn_temizleuye";
            this.btn_temizleuye.Size = new System.Drawing.Size(100, 30);
            this.btn_temizleuye.TabIndex = 7;
            this.btn_temizleuye.Text = "TEMİZLE";
            this.btn_temizleuye.UseVisualStyleBackColor = true;
            this.btn_temizleuye.Click += new System.EventHandler(this.btn_temizleuye_Click);
            // 
            // btn_temizlekitap
            // 
            this.btn_temizlekitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizlekitap.Location = new System.Drawing.Point(689, 62);
            this.btn_temizlekitap.Name = "btn_temizlekitap";
            this.btn_temizlekitap.Size = new System.Drawing.Size(100, 30);
            this.btn_temizlekitap.TabIndex = 7;
            this.btn_temizlekitap.Text = "TEMİZLE";
            this.btn_temizlekitap.UseVisualStyleBackColor = true;
            this.btn_temizlekitap.Click += new System.EventHandler(this.btn_temizlekitap_Click);
            // 
            // label_uye
            // 
            this.label_uye.AutoSize = true;
            this.label_uye.Location = new System.Drawing.Point(108, 11);
            this.label_uye.Name = "label_uye";
            this.label_uye.Size = new System.Drawing.Size(0, 16);
            this.label_uye.TabIndex = 8;
            this.label_uye.Visible = false;
            this.label_uye.Click += new System.EventHandler(this.label_uye_Click);
            // 
            // label_kitap
            // 
            this.label_kitap.AutoSize = true;
            this.label_kitap.Location = new System.Drawing.Point(715, 11);
            this.label_kitap.Name = "label_kitap";
            this.label_kitap.Size = new System.Drawing.Size(0, 16);
            this.label_kitap.TabIndex = 8;
            this.label_kitap.Visible = false;
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isim.Location = new System.Drawing.Point(153, 477);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(0, 16);
            this.lbl_isim.TabIndex = 9;
            // 
            // lbl_kitap
            // 
            this.lbl_kitap.AutoSize = true;
            this.lbl_kitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kitap.Location = new System.Drawing.Point(793, 477);
            this.lbl_kitap.Name = "lbl_kitap";
            this.lbl_kitap.Size = new System.Drawing.Size(0, 16);
            this.lbl_kitap.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "SEÇİLEN ÜYE : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(622, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "SEÇİLEN KİTAP : ";
            // 
            // kitapodunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1234, 513);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_kitap);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.label_kitap);
            this.Controls.Add(this.label_uye);
            this.Controls.Add(this.btn_temizlekitap);
            this.Controls.Add(this.btn_temizleuye);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_uyeara);
            this.Controls.Add(this.btn_kitapara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_al);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_adet);
            this.Controls.Add(this.txt_kitap);
            this.Controls.Add(this.txt_uye);
            this.Name = "kitapodunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖDÜNÇ KİTAP";
            this.Load += new System.EventHandler(this.kitapodunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_uye;
        private System.Windows.Forms.TextBox txt_kitap;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_al;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_kitapara;
        private System.Windows.Forms.Button btn_uyeara;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_temizleuye;
        private System.Windows.Forms.Button btn_temizlekitap;
        private System.Windows.Forms.Label label_uye;
        private System.Windows.Forms.Label label_kitap;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_kitap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}