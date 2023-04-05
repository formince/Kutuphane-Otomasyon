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

namespace kutuphanesotomasyonmsql
{
    public partial class kitapekle : Form
    {
        public kitapekle()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlCommandBuilder cmdb;
        SqlConnection Baglanti = new SqlConnection();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kitapekle_Load(object sender, EventArgs e)
        {
            string BaglantiAdresi = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";

            Baglanti.ConnectionString = BaglantiAdresi;
            Baglanti.Open();
            //MessageBox.Show("Bağlantı Açıldı.");
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (checkBox_aktif.Checked == true)
            {
                if (string.IsNullOrEmpty(txt_kitapadi.Text) || string.IsNullOrEmpty(txt_kitapyayinevi.Text) || string.IsNullOrEmpty(txt_kitapstok.Text))
                {
                    MessageBox.Show("Lütfen kitap adı  yayınevi ve stok adet alanlarını boş bırakmayın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (checkBox_aktif.Checked && checkBox_pasif.Checked)
                {
                    MessageBox.Show("Sadece bir seçim yapabilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string kayit = "insert into kitapekle (kitapismi, kitapyayinadi,stokadeti,durum) values (@kitapismi, @kitapyayinadi, @stokadeti, @durum)";
                    SqlCommand ekle = new SqlCommand(kayit, Baglanti);
                    ekle.Parameters.AddWithValue("@kitapismi", txt_kitapadi.Text);
                    ekle.Parameters.AddWithValue("@kitapyayinadi", txt_kitapyayinevi.Text);
                    ekle.Parameters.AddWithValue("@stokadeti", txt_kitapstok.Text);
                    ekle.Parameters.AddWithValue("@durum", 1);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("kitap kaydı başarıyla yapılmıştır.", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           else if (checkBox_pasif.Checked == true)
            {
                if (string.IsNullOrEmpty(txt_kitapadi.Text) || string.IsNullOrEmpty(txt_kitapyayinevi.Text) || string.IsNullOrEmpty(txt_kitapstok.Text))
                {
                    MessageBox.Show("Lütfen kitap adı  yayınevi ve stok adet alanlarını boş bırakmayın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string kayit = "insert into kitapekle (kitapismi, kitapyayinadi,stokadeti,durum) values (@kitapismi, @kitapyayinadi, @stokadeti, @durum)";
                    SqlCommand ekle = new SqlCommand(kayit, Baglanti);
                    ekle.Parameters.AddWithValue("@kitapismi", txt_kitapadi.Text);
                    ekle.Parameters.AddWithValue("@kitapyayinadi", txt_kitapyayinevi.Text);
                    ekle.Parameters.AddWithValue("@stokadeti", txt_kitapstok.Text);
                    ekle.Parameters.AddWithValue("@durum", 1);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("kitap kaydı başarıyla yapılmıştır.", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("lütfen durumunu giriniz");
            }
        }

        private void radioButton_aktif_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_aktif_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
