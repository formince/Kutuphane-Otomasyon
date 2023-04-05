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
    public partial class rapor : Form
    {
        public rapor()
        {
            InitializeComponent();
        }

        SqlConnection Baglanti = new SqlConnection();
        static string conString = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";
        SqlConnection baglanti = new SqlConnection(conString);





        private void btn_geri_Click(object sender, EventArgs e)
        {
            yoneticipanel yoneticipanel = new yoneticipanel();
            yoneticipanel.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rapor_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;");
            
            string sqlQuery = "SELECT uye.isim, uye.soyisim,oduncKitap.* FROM oduncKitap,uye WHERE teslim_edilecek_tarih < GETDATE() and odunc_alan_kisi_id=uye.ID and odunc_adet>0";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[10].Visible = false;
        }

    }
}
