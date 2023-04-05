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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace kutuphanesotomasyonmsql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static class UserSession
        {
            public static int UserId { get; set; }
        }

        string connectionString = "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;";
        // "Server=.;Database=kutuphanee;User Id=sa;Password=123456; connection timeout=30;"

       
        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txt_kullaniciadi.Text;
            string sifre = txt_sifre.Text;
            string query = "SELECT ID FROM kullanici WHERE isim = @isim AND soyisim = @soyisim";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@isim", kullaniciadi);
                command.Parameters.AddWithValue("@soyisim", sifre);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Kullanıcı kimliğini kaydedin
                    int userId = Convert.ToInt32(reader["ID"]);
                    // Burada kullanıcı kimliğini saklayabilirsiniz
                    // Örneğin, bir static değişken kullanarak
                    UserSession.UserId = userId;
                    yoneticipanel yoneticipanel = new yoneticipanel();
                    yoneticipanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("kullanıcı adı ve parola eşleşmedi.", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }


            //yoneticipanel yoneticipanel = new yoneticipanel();
            //yoneticipanel.Show();
            //this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar='\u25cf';
        }
    }
}
