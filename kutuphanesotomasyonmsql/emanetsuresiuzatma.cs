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
    public partial class emanetsuresiuzatma : Form
    {
        public emanetsuresiuzatma()
        {
            InitializeComponent();
        }


        SqlConnection Baglanti = new SqlConnection();
        static string conString = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";
        SqlConnection baglanti = new SqlConnection(conString);


        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlCommandBuilder cmdb;

        void griddoldur()
        {
            con = new SqlConnection("server=.; Initial Catalog=kutuphanee;Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("Select oduncKitap.ID, kullanici.isim as 'ödünç veren kişi', kitapekle.ID as 'kitap ıd', uye.isim as 'ödünç alan isim',uye.soyisim as 'ödünç alan soyisim' ,kitapekle.kitapismi, oduncKitap.teslim_alinan_tarih, oduncKitap.teslim_edilecek_tarih, oduncKitap.odunc_adet from oduncKitap, kitapekle, uye, kullanici where oduncKitap.odunc_veren_kisi_id=kullanici.ID and oduncKitap.odunc_alan_kisi_id = uye.ID and kitap_id =kitapekle.ID and teslim_edilen_tarih is null", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            cmdb = new SqlCommandBuilder(da);
            ds=new DataSet();
            da.Fill(ds, "oduncKitap");
       
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            con.Close(); // burada bağlantıyı kapatıyoruz.
            

        }



        private void emanetsuresiuzatma_Load(object sender, EventArgs e)
        {
            string BaglantiAdresi = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";

            Baglanti.ConnectionString = BaglantiAdresi;
            Baglanti.Open();
            //MessageBox.Show("Bağlantı Açıldı.");
            griddoldur();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dateTimePicker1.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_kitapıd.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();

            //txt_tarih.Text=dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }


        public void uptade()
        {
            if (string.IsNullOrEmpty(txt_kitapıd.Text) || String.IsNullOrEmpty(txt_tarih.Text))
            {
                //MessageBox.Show("string isnull empty içi boştur demektir");
                MessageBox.Show("hangi kitabın ve ne kadar uzatılacağını belirtiniz.", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

            }
            else
            {
                // Önce MSSQL veritabanına bağlanalım
                string connectionString = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                int kitapId = int.Parse(txt_kitapıd.Text);
                // Teslim edilecek tarih sütunundan verileri seçelim
                string query = "SELECT teslim_edilecek_tarih FROM oduncKitap WHERE oduncKitap.ID = @kitapId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@kitapId", kitapId); // kitap id'si parametre olarak eklendi

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    DateTime teslimTarihi = reader.GetDateTime(0); // Teslim edilecek tarih sütunundan DateTime nesnesi alındı

                    // Kullanıcının girdiği gün sayısı kadar gün ekle
                    int gunSayisi = int.Parse(txt_tarih.Text); // Örnek olarak 7 gün ekleyelim 
                    DateTime yeniTeslimTarihi = teslimTarihi.AddDays(gunSayisi);
                    reader.Close();

                    // Yeni teslim tarihini MSSQL veritabanına kaydet
                    string updateQuery = "UPDATE oduncKitap SET teslim_edilecek_tarih = @yeniTeslimTarihi WHERE ID = @kitapId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@yeniTeslimTarihi", yeniTeslimTarihi);
                    updateCommand.Parameters.AddWithValue("@kitapId", kitapId);
                    updateCommand.ExecuteNonQuery();

                }


                // MSSQL veritabanı bağlantısını kapat
                connection.Close();
                MessageBox.Show("TESLİM SÜRESİ BAŞARIYLA UZATILMIŞTIR", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information); ;


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uptade();
            griddoldur();
            txt_kitapıd.Text=string.Empty;
            txt_tarih.Text=string.Empty;
            
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            yoneticipanel yoneticipanel = new yoneticipanel();
            yoneticipanel.Show();
            this.Hide();
        }

        private void txt_kitap_Click(object sender, EventArgs e)
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
                string kayit = "Select oduncKitap.ID, kullanici.isim as 'ödünç veren kişi', kitapekle.ID as 'kitap ıd', uye.isim as 'ödünç alan isim',uye.soyisim as 'ödünç alan soyisim' ,kitapekle.kitapismi, oduncKitap.teslim_alinan_tarih, oduncKitap.teslim_edilecek_tarih, oduncKitap.odunc_adet from   oduncKitap, kitapekle, uye, kullanici where oduncKitap.odunc_veren_kisi_id=kullanici.ID and oduncKitap.odunc_alan_kisi_id = uye.ID and kitap_id =kitapekle.ID and teslim_edilen_tarih is null and uye.isim like @isim or uye.soyisim like @isim and kitapekle.kitapismi like @isim";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
           txt_ara.Text = string.Empty;
           griddoldur();
        }
    }
}
