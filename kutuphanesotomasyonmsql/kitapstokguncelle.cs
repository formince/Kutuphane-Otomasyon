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
using static System.Net.Mime.MediaTypeNames;

namespace kutuphanesotomasyonmsql
{
    public partial class kitapstokguncelle : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlCommandBuilder cmdb;
        void griddoldur()
        {
            con = new SqlConnection("server=.; Initial Catalog=kutuphanee;Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("Select * from kitapekle", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            cmdb = new SqlCommandBuilder(da);
            ds=new DataSet();
            da.Fill(ds, "kitapekle");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            con.Close(); // burada bağlantıyı kapatıyoruz.

        }
        public kitapstokguncelle()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection();
        static string conString = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";
        SqlConnection baglanti = new SqlConnection(conString);
       

        private void kitapstokguncelle_Load(object sender, EventArgs e)
        {
            string BaglantiAdresi = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";

            Baglanti.ConnectionString = BaglantiAdresi;
            Baglanti.Open();
            //MessageBox.Show("Bağlantı Açıldı.");
            griddoldur();


        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            
            string kayit = "SELECT * from kitapekle where kitapismi='@kitapismi'";

            //musterino parametresine bağlı olarak müşteri bilgilerini çeken sql kodu
            SqlCommand komut = new SqlCommand("SELECT * from kitapekle where kitapismi=@kitapismi", baglanti);
            komut.Parameters.AddWithValue("@kitapismi", txt_ara.Text);
           
            //musterino parametremize textbox'dan girilen değeri aktarıyoruz.
           // SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            
            if (dr.Read()) //Sadece tek bir kayıt döndürüleceği için while kullanmadım.
            {
                txt_kitapismi.Text = dr["kitapismi"].ToString();
                txt_kitapyayinadi.Text = dr["kitapyayinadi"].ToString();
                txt_stokadeti.Text = dr["stokadeti"].ToString();
                txt_durum.Text = dr["durum"].ToString();

                //Datareader ile okunan verileri form kontrollerine aktardık.
            }
            else
                MessageBox.Show("kitap Bulunamadı.");
            baglanti.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "update kitapekle set kitapismi=@kitapismi,kitapyayinadi=@kitapyayinadi,stokadeti=@stokadeti,durum=@durum where kitapismi=@kitapismi";
            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@kitapismi", txt_kitapismi.Text);
            komut.Parameters.AddWithValue("@kitapyayinadi", txt_kitapyayinadi.Text);
            komut.Parameters.AddWithValue("@stokadeti", txt_stokadeti.Text);
            komut.Parameters.AddWithValue("@durum", txt_stokadeti.Text);
      
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
            MessageBox.Show("Kitap bilgileri Güncellendi.");
            griddoldur();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapismi.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_kitapyayinadi.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_stokadeti.Text=dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_durum.Text=dataGridView1.CurrentRow.Cells[4].Value.ToString();




        }

        private void btn_kitapara_Click(object sender, EventArgs e)
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
                string kayit = "SELECT * from kitapekle where kitapismi like @kitapismi or kitapyayinadi like @kitapismi";
                SqlCommand komut = new SqlCommand(kayit, con);

                komut.Parameters.AddWithValue("@kitapismi", "%"+txt_ara.Text+"%");

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
    }
}
