using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static kutuphanesotomasyonmsql.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kutuphanesotomasyonmsql
{
    public partial class kitapodunc : Form
    {

        SqlConnection SqlConnectionaurto= new SqlConnection("");

        public kitapodunc()
        {
            InitializeComponent();
        }



        public static class oduncadet
        {
            public static string OduncAdet { get; set; }
        }

       

        SqlConnection Baglanti = new SqlConnection();
        static string conString = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";
        SqlConnection baglanti = new SqlConnection(conString);
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlCommandBuilder cmdb;
        string kayit = "SELECT * from uye where isim like @isim or soyisim like @isim";

        string kitapID;
        string uyeID;


        void griddoldurkitap()
        {
            con = new SqlConnection("server=.; Initial Catalog=kutuphanee;Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("Select * from kitapekle", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            cmdb = new SqlCommandBuilder(da);
            ds=new DataSet();
            da.Fill(ds, "kitapekle");
            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.Columns[0].Visible = false;
            con.Close(); // burada bağlantıyı kapatıyoruz.

        }

        void griddolduruye()
        {
            con = new SqlConnection("server=.; Initial Catalog=kutuphanee;Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("Select * from uye", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            cmdb = new SqlCommandBuilder(da);
            ds=new DataSet();
            da.Fill(ds, "uye");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            con.Close(); // burada bağlantıyı kapatıyoruz.

        }


        private void kitapodunc_Load(object sender, EventArgs e)
        {
            string BaglantiAdresi = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";
            txt_adet.ReadOnly = true;

            Baglanti.ConnectionString = BaglantiAdresi;
            Baglanti.Open();
            //MessageBox.Show("Bağlantı Açıldı.");
            


            griddoldurkitap();
            griddolduruye();
           
        }

        private void btn_uyeara_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_uye.Text))
            {
                // Eğer metin yoksa veya boşsa bir hata mesajı göster
                MessageBox.Show("Aranacak metin giriniz.");
            }
            else if (txt_uye.Text.Length < 3)
            {
                // Eğer metnin uzunluğu 3 karakterden kısa ise bir hata mesajı göster
                MessageBox.Show("Lütfen en az 3 karakter içeren bir metin giriniz.");
            }
            else
            {
                string kayit = "SELECT * from uye where isim like @isim or soyisim like @isim";
                SqlCommand komut = new SqlCommand(kayit, con);

                komut.Parameters.AddWithValue("@isim", "%"+txt_uye.Text+"%");

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

        private void btn_kitapara_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_kitap.Text))
            {
                // Eğer metin yoksa veya boşsa bir hata mesajı göster
                MessageBox.Show("Aranacak metin giriniz.");
            }
            else if (txt_kitap.Text.Length < 3)
            {
                // Eğer metnin uzunluğu 3 karakterden kısa ise bir hata mesajı göster
                MessageBox.Show("Lütfen en az 3 karakter içeren bir metin giriniz.");
            }
            else
            {
                string kayit = "SELECT * from kitapekle where kitapismi like @kitapismi or kitapyayinadi like @kitapismi";
                SqlCommand komut = new SqlCommand(kayit, con);

                komut.Parameters.AddWithValue("@kitapismi", "%"+txt_kitap.Text+"%");

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
                    dataGridView2.DataSource = dt;
                }
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            yoneticipanel yoneticipanel = new yoneticipanel();
            yoneticipanel.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label_kitap.Text=dataGridView2.CurrentRow.Cells[0].Value.ToString();
            kitapID=label_kitap.Text;
            lbl_kitap.Text=dataGridView2.CurrentRow.Cells[1].Value.ToString();

        }

        private void btn_temizleuye_Click(object sender, EventArgs e)
        {
            griddolduruye();
        }

        private void btn_temizlekitap_Click(object sender, EventArgs e)
        {
            griddoldurkitap();
        }

        private void label_uye_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label_uye.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            uyeID = label_uye.Text;
            lbl_isim.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void btn_al_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(label_uye.Text) || string.IsNullOrEmpty(label_kitap.Text) || string.IsNullOrEmpty(txt_adet.Text) )
            {
                MessageBox.Show("KİTAP ÖDÜNÇ VEREN KİŞİ, KİTAP ID SEÇİLMEMİŞTİR VEYA STOK ADETİ GİRİLMEMİŞTİR ","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
               if(Convert.ToInt32(txt_adet.Text)    > 0)
                {
                    string queryone = "SELECT stokadeti FROM kitapekle where ID=@kitapID";
                    SqlCommand cmd = new SqlCommand(queryone, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@kitapID", kitapID);
                    int stokAdeti = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    string istenilenstok = txt_adet.Text;
                    if (int.Parse(istenilenstok) > stokAdeti)
                    {
                        MessageBox.Show("istenilen kadar stok bulunmamaktadır.", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {

                        DateTime date = DateTime.Now;
                        TimeSpan ts = new TimeSpan(10, 0, 0, 0);
                        DateTime newDate = date.Add(ts);
                        string kayit = "insert into oduncKitap (odunc_veren_kisi_id, odunc_alan_kisi_id, kitap_id, teslim_alinan_tarih, teslim_edilecek_tarih, odunc_adet) values (@odunc_veren_kisi_id, @odunc_alan_kisi_id, @kitap_id, @teslim_alinan_tarih, @teslim_edilecek_tarih, @odunc_adet)";
                        SqlCommand ekle = new SqlCommand(kayit, Baglanti);
                        ekle.Parameters.AddWithValue("@odunc_veren_kisi_id", UserSession.UserId);
                        ekle.Parameters.AddWithValue("@odunc_alan_kisi_id", uyeID);
                        ekle.Parameters.AddWithValue("@kitap_id", kitapID);
                        ekle.Parameters.AddWithValue("@teslim_alinan_tarih", DateTime.Now);
                        ekle.Parameters.AddWithValue("@teslim_edilecek_tarih", newDate);
                        ekle.Parameters.AddWithValue("@odunc_adet", txt_adet.Text);
                        ekle.ExecuteNonQuery();
                        MessageBox.Show(newDate + "bu tarihte geri getirilmesi gerekiyor", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        yeniStokAdet();
                        griddolduruye();
                        griddoldurkitap();

                    }
                }
               else
                {
                    MessageBox.Show("ödünç adeti 0 dan büyük olmalıdır","bilgilendirme",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Asterisk);
                }
            }

        }

        public void yeniStokAdet()
        {
            // Bağlantı dizisi ve SQL sorgusu
            string connectionString = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";
            string sql = "UPDATE kitapekle SET stokadeti = stokadeti - @adet WHERE ID = @id";

            // Adet değişkenini textbox'tan al
            int adet = int.Parse(txt_adet.Text);

            // Veritabanı bağlantısı aç
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL komutunu hazırla
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@adet", adet);
                    command.Parameters.AddWithValue("@id", kitapID); // burada kitapId kaydın benzersiz kimliğini temsil eder

                    // Sorguyu çalıştır
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

        }


        public void oduncAdetGoruntule()
        {
           
        }

    }
}
