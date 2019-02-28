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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

      

        private void Kaydet_Click(object sender, EventArgs e)
        {
            StreamWriter kayıt = File.AppendText("D:\\uygulamalar\\HAYSİKİM\\yeni\\personeller.txt");
            kayıt.Write(isimtxtb.Text + "-");
            kayıt.Write(soyisimtxtb.Text + "-");
            kayıt.Write(kuladıtxtb.Text + "-");
            kayıt.WriteLine(şifretxtb.Text);
            kayıt.Close();
            MessageBox.Show("Personel Kaydedildi");

        }

        private void AnaSayfa_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();

        }
    }
}
