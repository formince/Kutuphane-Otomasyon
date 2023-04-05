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
    public partial class uyeislempanel : Form
    {
        public uyeislempanel()
        {
            InitializeComponent();
        }
        private void Formgetir(Form form)
        {
            panel2.Controls.Clear();
            form.MdiParent= this;
            form.FormBorderStyle= FormBorderStyle.None;
            panel2.Controls.Add(form);
            form.Show();
        }

        private void btn_uyeekle_Click(object sender, EventArgs e)
        {
            uyeislemleri uyeislemleri = new uyeislemleri();
            Formgetir(uyeislemleri);
            
        }

        private void uyeislempanel_Load(object sender, EventArgs e)
        {
            uyeislemleri uyeislemleri = new uyeislemleri();
            Formgetir(uyeislemleri);
        }

        private void btn_uyebilgiguncelle_Click(object sender, EventArgs e)
        {
            uyeguncelle uyeguncelle = new uyeguncelle();
            Formgetir(uyeguncelle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            yoneticipanel yoneticipanel = new yoneticipanel();
            yoneticipanel.Show();
        }
    }
}
