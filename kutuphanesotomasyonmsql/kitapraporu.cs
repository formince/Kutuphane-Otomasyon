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
    public partial class kitapraporu : Form
    {
        public kitapraporu()
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

        int kitapid;

        void griddoldurkitap()
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

        private void kitapraporu_Load(object sender, EventArgs e)
        {
            griddoldurkitap();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_id.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            kitapid=int.Parse(lbl_id.Text);
            kitaprapor();
        }

        public void kitaprapor()
        {
            //int uyeID = 18; // veya uyeID değişkenine değer atanabilir
            SqlConnection conn = new SqlConnection("Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;");

            string sqlQuery = "select uye.isim,uye.soyisim,kitapekle.kitapismi,kitapekle.kitapyayinadi,oduncKitap.teslim_alinan_tarih,oduncKitap.teslim_edilecek_tarih,oduncKitap.teslim_edilen_tarih,oduncKitap.odunc_adet from kitapekle,uye,oduncKitap where  kitapekle.ID=oduncKitap.kitap_id    and uye.ID=oduncKitap.odunc_alan_kisi_id  and kitapekle.ID=@kitapid";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            cmd.Parameters.AddWithValue("@kitapid", kitapid);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
            dataGridView2.Columns[7].Visible = false;

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            yoneticipanel yoneticipanel = new yoneticipanel();
            yoneticipanel.Show();
            this.Hide();
        }
    }
}
