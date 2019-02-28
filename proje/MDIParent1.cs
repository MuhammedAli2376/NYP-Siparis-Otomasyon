using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class MDIParent1 : Form
    {
       

        public MDIParent1()
        {
            InitializeComponent();
        }
        ÜrünEkle ÜrünEkle;
        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜrünEkle = new ÜrünEkle();
            ÜrünEkle.MdiParent = this;
            ÜrünEkle.Show();
            if(ÜrünSil!=null)
                ÜrünSil.Hide();
            if (ürünler != null)
                ürünler.Hide();
        }
        ÜrünSil ÜrünSil;
        private void ürünSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜrünSil = new ÜrünSil();
            ÜrünSil.MdiParent = this;
            ÜrünSil.Show();
            if (ürünler != null)
                ürünler.Hide();
            if (ÜrünEkle != null)
                ÜrünEkle.Hide();
        }
        ÜrünDüzenle ürünler;
        private void ürünDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ürünler = new ÜrünDüzenle();
            ürünler.MdiParent = this;
            ürünler.Show();
            if (ÜrünEkle != null)
                ÜrünEkle.Hide();
            if (ÜrünSil != null)
                ÜrünSil.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelEkle a = new PersonelEkle();
            a.MdiParent = this;
            a.Show();
        }
    }
}
