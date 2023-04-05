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
using static kutuphanesotomasyonmsql.Form1;

namespace kutuphanesotomasyonmsql
{
    public partial class kitapTeslim : Form
    {
        public kitapTeslim()
        {
            InitializeComponent();
        }

        int adet;
        int ID;
         

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
            da = new SqlDataAdapter("Select oduncKitap.ID, oduncKitap.odunc_alan_kisi_id,kullanici.isim as 'ödünç veren kişi', kitapekle.ID as 'kitap ıd', uye.isim as 'ödünç alan isim',uye.soyisim as 'ödünç alan soyisim' ,kitapekle.kitapismi, oduncKitap.teslim_alinan_tarih, oduncKitap.teslim_edilecek_tarih, oduncKitap.odunc_adet from oduncKitap, kitapekle, uye, kullanici where oduncKitap.odunc_veren_kisi_id=kullanici.ID and oduncKitap.odunc_alan_kisi_id = uye.ID and kitap_id =kitapekle.ID and teslim_edilen_tarih is  null", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            cmdb = new SqlCommandBuilder(da);
            ds=new DataSet();
            da.Fill(ds, "oduncKitap");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            con.Close(); // burada bağlantıyı kapatıyoruz.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label_id.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();

            txt_oduncalankisiid.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();


            txt_id.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text=dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_soyisim.Text=dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_kitapadi.Text=dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_stok.Text=dataGridView1.CurrentRow.Cells[9].Value.ToString();

        }


        private void kitapTeslim_Load(object sender, EventArgs e)
        {
            string BaglantiAdresi = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";
            label_id.Visible=false;
            Baglanti.ConnectionString = BaglantiAdresi;
            Baglanti.Open();
            //MessageBox.Show("Bağlantı Açıldı.");
            griddoldur();
            txt_id.ReadOnly=true; 
            txt_oduncalankisiid.ReadOnly=true;
            txt_isim.ReadOnly=true;
            txt_soyisim.ReadOnly = true;
            txt_kitapadi.ReadOnly=true; 
            txt_stok.ReadOnly=true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_teslimal_Click(object sender, EventArgs e)
        {
            
            DateTime date = DateTime.Now;
            //string kayit = "insert into oduncKitap (odunc_teslim_alan_kisi_id,teslim_edilen_tarih) values (@odunc_teslim_alan_kisi_id,@teslim_edilen_tarih)";
            string kayit = "update oduncKitap  set odunc_teslim_alan_kisi_id=@odunc_teslim_alan_kisi_id, teslim_edilen_tarih=@teslim_edilen_tarih where ID=@ID   "; 
            SqlCommand ekle = new SqlCommand(kayit, Baglanti);
            ekle.Parameters.AddWithValue("odunc_teslim_alan_kisi_id", UserSession.UserId);
            ekle.Parameters.AddWithValue("ID", txt_id.Text);


            ekle.Parameters.AddWithValue("@teslim_edilen_tarih", DateTime.Now);
            ekle.ExecuteNonQuery();
            MessageBox.Show("KİTAP TESLİM ALINMIŞTIR..", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stokekleme();
            //yeniStokAdet();
            griddoldur();
            
        }

        public void yeniStokAdet()
        {
            // Bağlantı dizisi ve SQL sorgusu
            string connectionString = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";
            string sql = "UPDATE oduncKitap SET odunc_adet = odunc_adet - @adet WHERE oduncKitap.ID = @ID";

            // Adet değişkenini textbox'tan al
             adet = int.Parse(txt_stok.Text);
            ID=int.Parse(label_id.Text);
            // Veritabanı bağlantısı aç
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL komutunu hazırla
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@adet", adet);
                    command.Parameters.AddWithValue("@ID", ID); // burada kitapId kaydın benzersiz kimliğini temsil eder

                    // Sorguyu çalıştır
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

        }

        public void stokekleme()
        {
            // Bağlantı dizisi ve SQL sorgusu
            string connectionString = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";
            string sql = "UPDATE kitapekle SET stokadeti = stokadeti + @adet WHERE kitapekle.ID = @ID";

            // Adet değişkenini textbox'tan al
            adet = int.Parse(txt_stok.Text);
            ID=int.Parse(txt_id.Text);
            // Veritabanı bağlantısı aç
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL komutunu hazırla
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@adet", adet);
                    command.Parameters.AddWithValue("@ID", ID); // burada kitapId kaydın benzersiz kimliğini temsil eder

                    // Sorguyu çalıştır
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            yoneticipanel yoneticipanel = new yoneticipanel();
            yoneticipanel.Show();
            this.Hide();
        }

        private void btn_ara_Click(object sender, EventArgs e)
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

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_ara.Text = string.Empty;
            griddoldur();
        }
    }
}
