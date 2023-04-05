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
    public partial class kullaniciguncelle : Form
    {
        public kullaniciguncelle()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlCommandBuilder cmdb;
        string kullanici_id;
        string kayit = "SELECT * from  kullanici where isim like @isim or soyisim like @isim";

        SqlConnection Baglanti = new SqlConnection();
        static string conString = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";
        SqlConnection baglanti = new SqlConnection(conString);

        void griddoldur()
        {
            con = new SqlConnection("server=.; Initial Catalog=kutuphanee;Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("Select * from kullanici", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            cmdb = new SqlCommandBuilder(da);
            ds=new DataSet();
            da.Fill(ds, "kullanici");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            con.Close(); // burada bağlantıyı kapatıyoruz.

        }

        private void kullaniciguncelle_Load(object sender, EventArgs e)
        {
            string BaglantiAdresi = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";

            Baglanti.ConnectionString = BaglantiAdresi;
            Baglanti.Open();
            //MessageBox.Show("Bağlantı Açıldı.");
            griddoldur();
            label_id.Visible = false;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "update kullanici set isim=@isim,soyisim=@soyisim,durum=@durum where ID=@ID";
            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@isim", txt_isim.Text);
            komut.Parameters.AddWithValue("@soyisim", txt_soyisim.Text);
            komut.Parameters.AddWithValue("@durum", txt_durum.Text);
            komut.Parameters.AddWithValue("@ID", kullanici_id);


            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
            MessageBox.Show("Kullanıcı Bilgileri Güncellendi.");
            griddoldur();
        }

        private void btn_uyeara_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ara.Text))
            {
                // Eğer metin yoksa veya boşsa bir hata mesajı göster
                MessageBox.Show("Aranacak metin giriniz.");
            }
            else if (txt_ara.Text.Length < 3)
            {
                // Eğer metnin uzunluğu 3 karakterden kısa ise bir hata mesajı göster
                MessageBox.Show("Lütfen en az 3 karakter içeren bir metin giriniz.");
            }
            else
            {
                string kayit = "SELECT * from kullanici where isim like @isim or soyisim like @isim";
                SqlCommand komut = new SqlCommand(kayit, con);

                komut.Parameters.AddWithValue("@isim", "%"+txt_ara.Text+"%");

                SqlDataAdapter da = new SqlDataAdapter(komut);

                DataTable dt = new DataTable();
                da.Fill(dt); // Verileri DataTable'a doldur

                if (dt.Rows.Count == 0)
                {
                    // Eğer veri yoksa bir hata mesajı göster
                    MessageBox.Show("Böyle bir kayıt bulunamadı.");
                }
                else
                {
                    // Eğer veri varsa DataGridView'e verileri yükle
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            griddoldur();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txt_isim.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_durum.Text=dataGridView1.CurrentRow.Cells[3].Value.ToString();

            kullanici_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }

    }
}
