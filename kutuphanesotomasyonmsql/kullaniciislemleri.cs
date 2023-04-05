using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphanesotomasyonmsql
{
    public partial class kullaniciislemleri : Form
    {
        public kullaniciislemleri()
        {
            InitializeComponent();
        }

        private void Formgetir(Form form)
        {
          // MdiParent yerine Parent kullanıyoruz
            panel2.Controls.Clear();
            form.MdiParent= this;
            form.FormBorderStyle= FormBorderStyle.None;
            panel2.Controls.Add(form);
            form.Show();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            yoneticipanel yoneticipanel = new yoneticipanel();
            yoneticipanel.Show();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            kullaniciekle kullaniciekle = new kullaniciekle();
            Formgetir(kullaniciekle);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            kullaniciguncelle kullaniciguncelle = new kullaniciguncelle();
            Formgetir(kullaniciguncelle);
        }

        private void kullaniciislemleri_Load(object sender, EventArgs e)
        {
            kullaniciekle kullaniciekle = new kullaniciekle();
            Formgetir(kullaniciekle);
        }
    }
}
