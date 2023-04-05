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
    public partial class yoneticiislemleri : Form
    {
        public yoneticiislemleri()
        {
            InitializeComponent();
        }

        private void kitapStokOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Formgetir(Form form)
        {
            panel1.Controls.Clear();
            form.MdiParent= this;
            form.FormBorderStyle= FormBorderStyle.None;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            kitapekle kitapekle = new kitapekle();
            Formgetir(kitapekle);
        }

        private void btn_kitapstok_Click(object sender, EventArgs e)
        {
            kitapstokguncelle kitapstokguncelle = new kitapstokguncelle();
            Formgetir(kitapstokguncelle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            yoneticipanel yoneticipanel = new yoneticipanel();
            yoneticipanel.Show();
            
        }

        private void yoneticiislemleri_Load(object sender, EventArgs e)
        {
            kitapekle kitapekle = new kitapekle();
            Formgetir(kitapekle);
        }
    }
}
