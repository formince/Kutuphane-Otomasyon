using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphanesotomasyonmsql
{
    public partial class yoneticipanel : Form
    {
        public yoneticipanel()
        {
            InitializeComponent();
        }

        private void btn_yoneticikitapislemleri_Click(object sender, EventArgs e)
        {
            yoneticiislemleri yoneticiislemleri = new yoneticiislemleri();
            yoneticiislemleri.Show();
            this.Hide();
        }

        private void btn_yoneticiuyeislemleri_Click(object sender, EventArgs e)
        {
            uyeislempanel uyeislempanel = new uyeislempanel();
            uyeislempanel.Show();
            this.Hide();
        }

        private void yoneticipanel_Load(object sender, EventArgs e)
        {

        }

        private void btn_yoneticikullanıcıislemleri_Click(object sender, EventArgs e)
        {
            kullaniciislemleri kullaniciislemleri = new kullaniciislemleri();
            kullaniciislemleri.Show();
            this.Hide();
        }

        private void btn_oduncislemleri_Click(object sender, EventArgs e)
        {
            kitapodunc kitapodunc = new kitapodunc();
            kitapodunc.Show();
            this.Hide();
        }

        private void btn_oduncListe_Click(object sender, EventArgs e)
        {
            oduncListe oduncListe = new oduncListe();
            oduncListe.Show();
            this.Hide();
        }

        private void btn_teslim_Click(object sender, EventArgs e)
        {
            kitapTeslim kitapTeslim = new kitapTeslim();
            kitapTeslim.Show();
            this.Hide();
        }

        private void btn_sureuzatma_Click(object sender, EventArgs e)
        {
           emanetsuresiuzatma emanetsuresiuzatma = new emanetsuresiuzatma();
            emanetsuresiuzatma.Show();
            this.Hide();
        }

        private void btn_rapor_Click(object sender, EventArgs e)
        {
            rapor rapor = new rapor();
            rapor.Show();
            this.Hide();
        }

        private void btn_uyeninislemleri_Click(object sender, EventArgs e)
        {
            uyeninYaptıgıIslemler uyeninYaptıgıIslemler = new uyeninYaptıgıIslemler();
            uyeninYaptıgıIslemler.Show();
            this.Hide();
        }

        private void btn_kitaprapor_Click(object sender, EventArgs e)
        {
            kitapraporu kitapraporu = new kitapraporu();
            kitapraporu.Show();
            this.Hide();
        }
    }
}
