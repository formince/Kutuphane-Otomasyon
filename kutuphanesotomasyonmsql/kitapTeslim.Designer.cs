namespace kutuphanesotomasyonmsql
{
    partial class kitapTeslim
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.txt_kitapadi = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.btn_teslimal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.lbl_oduncalankisiid = new System.Windows.Forms.Label();
            this.txt_oduncalankisiid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(897, 337);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.Location = new System.Drawing.Point(13, 382);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 24);
            this.label.TabIndex = 2;
            this.label.Text = "ID : ";
            this.label.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "İSİM : ";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(263, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYİSİM : ";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(263, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "KİTAP ADI : ";
            this.label4.Visible = false;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_id.Location = new System.Drawing.Point(128, 377);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 28);
            this.txt_id.TabIndex = 3;
            this.txt_id.Visible = false;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyisim.Location = new System.Drawing.Point(390, 384);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(100, 28);
            this.txt_soyisim.TabIndex = 3;
            this.txt_soyisim.Visible = false;
            // 
            // txt_kitapadi
            // 
            this.txt_kitapadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapadi.Location = new System.Drawing.Point(390, 443);
            this.txt_kitapadi.Name = "txt_kitapadi";
            this.txt_kitapadi.Size = new System.Drawing.Size(100, 28);
            this.txt_kitapadi.TabIndex = 3;
            this.txt_kitapadi.Visible = false;
            // 
            // txt_isim
            // 
            this.txt_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_isim.Location = new System.Drawing.Point(128, 444);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 28);
            this.txt_isim.TabIndex = 3;
            this.txt_isim.Visible = false;
            // 
            // btn_teslimal
            // 
            this.btn_teslimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_teslimal.Location = new System.Drawing.Point(787, 414);
            this.btn_teslimal.Name = "btn_teslimal";
            this.btn_teslimal.Size = new System.Drawing.Size(96, 55);
            this.btn_teslimal.TabIndex = 4;
            this.btn_teslimal.Text = "TESLİM AL";
            this.btn_teslimal.UseVisualStyleBackColor = true;
            this.btn_teslimal.Click += new System.EventHandler(this.btn_teslimal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(512, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "STOK : ";
            this.label1.Visible = false;
            // 
            // txt_stok
            // 
            this.txt_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_stok.Location = new System.Drawing.Point(648, 384);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(100, 28);
            this.txt_stok.TabIndex = 3;
            this.txt_stok.Visible = false;
            // 
            // btn_geri
            // 
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(0, 0);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(96, 36);
            this.btn_geri.TabIndex = 5;
            this.btn_geri.Text = "GERİ";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(839, 10);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(44, 16);
            this.label_id.TabIndex = 6;
            this.label_id.Text = "label5";
            this.label_id.Visible = false;
            // 
            // lbl_oduncalankisiid
            // 
            this.lbl_oduncalankisiid.AutoSize = true;
            this.lbl_oduncalankisiid.Location = new System.Drawing.Point(784, 9);
            this.lbl_oduncalankisiid.Name = "lbl_oduncalankisiid";
            this.lbl_oduncalankisiid.Size = new System.Drawing.Size(44, 16);
            this.lbl_oduncalankisiid.TabIndex = 7;
            this.lbl_oduncalankisiid.Text = "label5";
            this.lbl_oduncalankisiid.Visible = false;
            // 
            // txt_oduncalankisiid
            // 
            this.txt_oduncalankisiid.Location = new System.Drawing.Point(648, 447);
            this.txt_oduncalankisiid.Name = "txt_oduncalankisiid";
            this.txt_oduncalankisiid.Size = new System.Drawing.Size(100, 22);
            this.txt_oduncalankisiid.TabIndex = 8;
            this.txt_oduncalankisiid.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(512, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "ALAN KİŞİ ID";
            this.label5.Visible = false;
            // 
            // txt_ara
            // 
            this.txt_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ara.Location = new System.Drawing.Point(390, 7);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(100, 22);
            this.txt_ara.TabIndex = 9;
            // 
            // btn_ara
            // 
            this.btn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.Location = new System.Drawing.Point(553, 0);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(96, 34);
            this.btn_ara.TabIndex = 10;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(251, -1);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(96, 34);
            this.btn_temizle.TabIndex = 11;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // kitapTeslim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(895, 482);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.txt_oduncalankisiid);
            this.Controls.Add(this.lbl_oduncalankisiid);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_teslimal);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.txt_kitapadi);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kitapTeslim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KİTAP TESLİM";
            this.Load += new System.EventHandler(this.kitapTeslim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.TextBox txt_kitapadi;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Button btn_teslimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label lbl_oduncalankisiid;
        private System.Windows.Forms.TextBox txt_oduncalankisiid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_temizle;
    }
}