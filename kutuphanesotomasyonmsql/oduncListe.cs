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
    public partial class oduncListe : Form
    {

        SqlConnection Baglanti = new SqlConnection();
        static string conString = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";
        SqlConnection baglanti = new SqlConnection(conString);


        public oduncListe()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlCommandBuilder cmdb;

        void griddoldur()
        {
            con = new SqlConnection("server=.; Initial Catalog=kutuphanee;Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("Select oduncKitap.ID, kullanici.isim as 'ödünç veren kişi', kitapekle.ID as 'kitap ıd', uye.isim as 'ödünç alan isim',uye.soyisim as 'ödünç alan soyisim' ,kitapekle.kitapismi, oduncKitap.teslim_alinan_tarih, oduncKitap.teslim_edilecek_tarih, oduncKitap.odunc_adet from oduncKitap, kitapekle, uye, kullanici where oduncKitap.odunc_veren_kisi_id=kullanici.ID and oduncKitap.odunc_alan_kisi_id = uye.ID and kitap_id =kitapekle.ID and odunc_adet>0", con);
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

        private void oduncListe_Load(object sender, EventArgs e)
        {
            string BaglantiAdresi = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";

            Baglanti.ConnectionString = BaglantiAdresi;
            Baglanti.Open();
            //MessageBox.Show("Bağlantı Açıldı.");
            griddoldur();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            yoneticipanel yoneticipanel = new yoneticipanel();
            yoneticipanel.Show();
            this.Hide();
        }
    }
}
