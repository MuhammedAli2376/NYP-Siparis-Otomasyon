using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form2 frm2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"D:\toplu\uygulamalar\c#_okul_nesne\HAYSİKİM\yeni\kullanıcı.txt");
            string m_n = lines[0];
            string m_ş = lines[1];
            string müşteri_no = textBox1.Text;
            string müşteri_şifre = textBox2.Text;
            if (m_n == müşteri_no && m_ş == müşteri_şifre)
            {
                MessageBox.Show("giriş dogrulandı");
                Form1.ActiveForm.Hide();
                frm2.Show();
            }
            else
                MessageBox.Show("hatalı giriş");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*StreamReader st = new StreamReader(@"C:\\Users\\asus\\Desktop\\nypodev\\db\\Ürünler.txt");

            int SatırSayac = 0;
            while (st.Read() > 0)
            {
                st.ReadLine();
                SatırSayac++;
            }
            st.Close(); */
            string satır = "a";

            string[] lines = File.ReadAllLines(@"D:\\toplu\\uygulamalar\\c#_okul_nesne\\HAYSİKİM\\yeni\\\personeller.txt");

            //string name = lines[0];
            //string pass = lines[1];
            int sayac = 0;
            while (satır != null)
            {
                satır = lines[sayac];

                string[] parça = satır.Split('-');

                if (TextYetkiliAd.Text == parça[2] && TextYetkiliPass.Text == parça[3])
                {
                    MDIParent1 a = new MDIParent1();
                    a.Show();
                    this.Hide();
                    break;

                }

                if (TextYetkiliAd.Text != parça[2] && TextYetkiliPass.Text != parça[3])
                {
                    sayac++;
                }

                else
                {
                    MessageBox.Show("Hatalı Giriş");
                }


            }
        }
    }
}
