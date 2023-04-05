using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace kutuphanesotomasyonmsql
{
    public partial class uyeninYaptıgıIslemler : Form
    {
        public uyeninYaptıgıIslemler()
        {
            InitializeComponent();
        }

        int uyeID;


        SqlConnection Baglanti = new SqlConnection();
        static string conString = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";
        SqlConnection baglanti = new SqlConnection(conString);

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlCommandBuilder cmdb;
        string kayit = "SELECT * from uye where isim like @isim or soyisim like @isim";
        private void button1_Click(object sender, EventArgs e)
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
                    dataGridView2.DataSource = dt;
                }
            }
        }

        public void yapilanislem()
        {
        

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
            dataGridView2.DataSource = ds.Tables[0];
            con.Close(); // burada bağlantıyı kapatıyoruz.
            dataGridView2.Columns[0].Visible = false;

        }

        private void uyeninYaptıgıIslemler_Load(object sender, EventArgs e)
        {
            

            griddolduruye();
            uyeninyaptigiislemler();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label_uye.Text=dataGridView2.CurrentRow.Cells[0].Value.ToString();
            uyeID = int.Parse(label_uye.Text);
            uyeninyaptigiislemler();
        }

        public void uyeninyaptigiislemler()
        {
            //int uyeID = 18; // veya uyeID değişkenine değer atanabilir
            SqlConnection conn = new SqlConnection("Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;");

            string sqlQuery = "select uye.isim,uye.soyisim,oduncKitap.teslim_edilen_tarih,oduncKitap.teslim_alinan_tarih,oduncKitap.teslim_edilecek_tarih,kitapekle.kitapismi,kitapekle.kitapyayinadi,oduncKitap.odunc_adet from oduncKitap,uye,kitapekle where   oduncKitap.odunc_alan_kisi_id=uye.ID and oduncKitap.kitap_id=kitapekle.ID  and odunc_alan_kisi_id=@uyeID";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            cmd.Parameters.AddWithValue("@uyeID", uyeID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[7].Visible = false;

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            griddolduruye();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            yoneticipanel yoneticipanel = new yoneticipanel();
            yoneticipanel.Show();
            this.Hide();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            
        }

        private void label_uye_Click(object sender, EventArgs e)
        {

        }
    }
}
