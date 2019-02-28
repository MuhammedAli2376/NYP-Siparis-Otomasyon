using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace proje
{
    public partial class ÜrünEkle : Form
    {
        public ÜrünEkle()
        {
            InitializeComponent();
        }


        private void ÜrnEkle_Click(object sender, EventArgs e)
        {

            StreamWriter yaz = File.AppendText(@"D:\\uygulamalar\\HAYSİKİM\\yeni\\ürünler2.txt");
            yaz.Write(ÜrnMarka.Text + "-");
            yaz.Write(ÜrnModel.Text + "-");
            yaz.Write(ÜrnFiyat.Text + "-");
            yaz.Write(ÜrnAdet.Text + "-");
            yaz.WriteLine(ÜrnAgırlık.Text);
            yaz.Close();
            MessageBox.Show("Ürün Başarıyla Eklenmiştir");

            ÜrnMarka.Text = "";
            ÜrnModel.Text = "";
            ÜrnFiyat.Text = "";
            ÜrnAdet.Text = "";
            ÜrnAgırlık.Text = "";
        }
    }
}
