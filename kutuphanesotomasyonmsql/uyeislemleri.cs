using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace kutuphanesotomasyonmsql
{
    public partial class uyeislemleri : Form
    {
        public uyeislemleri()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection();


        private void uyeislemleri_Load(object sender, EventArgs e)
        {

            string BaglantiAdresi = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";

            Baglanti.ConnectionString = BaglantiAdresi;
            Baglanti.Open();
            //MessageBox.Show("Bağlantı Açıldı.");
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_isim.Text) || string.IsNullOrEmpty(txt_soyisim.Text) || !checkBox_aktif.Checked && !checkBox_pasif.Checked)
            {
                MessageBox.Show("lütfen isim soyisim ve durum alanlarını doldrunuz.", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ( checkBox_aktif.Checked && checkBox_pasif.Checked)
            {
                MessageBox.Show("Sadece bir seçim yapabilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkBox_aktif.Checked==true)
                {
                    string kayit = "insert into uye (isim, soyisim, durum) values (@isim, @soyisim, @durum)";
                    SqlCommand ekle = new SqlCommand(kayit, Baglanti);
                    ekle.Parameters.AddWithValue("@isim", txt_isim.Text);
                    ekle.Parameters.AddWithValue("@soyisim", txt_soyisim.Text);
                    ekle.Parameters.AddWithValue("@durum", 1);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("üye kaydı başarıyla yapılmıştır.", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (checkBox_pasif.Checked==true)
                {
                    string kayit = "insert into uye (isim, soyisim, durum) values (@isim, @soyisim, @durum)";
                    SqlCommand ekle = new SqlCommand(kayit, Baglanti);
                    ekle.Parameters.AddWithValue("@isim", txt_isim.Text);
                    ekle.Parameters.AddWithValue("@soyisim", txt_soyisim.Text);
                    ekle.Parameters.AddWithValue("@durum", 0);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("üye kaydı başarıyla yapılmıştır.", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void checkBox_aktif_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
