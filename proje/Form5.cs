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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            label9.AutoSize = false;

            label9.Width = 4;

            label9.Height = 420;

            label9.BorderStyle = BorderStyle.Fixed3D;
            label10.AutoSize = false;

            label10.Width = 4;

            label10.Height = 420;

            label10.BorderStyle = BorderStyle.Fixed3D;
        }
        public ürün ürn = new ürün();
        private void button1_Click(object sender, EventArgs e)
        {
            /*StreamReader oku = File.OpenText("D:\\deneme.txt");
            string satır = oku.ReadLine();
            while(satır!=null)
            {
                string[] parça = satır.Split('-');
                if (textBox1.Text == parça[0] && textBox2.Text == parça[3])
                {
                    Form3 frm3 = new Form3();
                    frm3.ShowDialog();D:\uygulamalar\HAYSİKİM\yeni
                    this.Hide();
                    break;
                    StreamWriter dosya = File.AppendText("D:\\deneme.txt");
            dosya.Write(textBox1.Text+"-");
            dosya.Write(textBox2.Text+"-");
            dosya.Write(comboBox1.Text+"-");
            dosya.WriteLine(textBox3.Text);
            dosya.Close();
            MessageBox.Show("kayıt başarılı");
            foreach(Control nesne in this.Controls)
            {
                if(nesne is TextBox)//is as in anlamlarını bilmiyorum internetten bak
                {
                    (nesne as TextBox).Clear();
                }
            }
            textBox1.Focus();// imleci textbox1 1 alır
            
            ürn.adı = textBox1.Text;
            ürn.kargo_agırlık = Convert.ToInt32(textBox3.Text);
            ürn.ürün_ekle(ürn);*/
            StreamWriter yaz = File.AppendText(@"D:\\uygulamalar\HAYSİKİM\yeni\ürünler.txt");
            yaz.WriteLine(textBox1.Text);
            yaz.WriteLine(textBox3.Text);
            yaz.WriteLine(textBox2.Text);
            yaz.Close();
            MessageBox.Show("ürün başarıyla eklenmiştir");
            
            
            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

            /*
            foreach (ürün ara in ürn.ürünler)
            {
                if (ara.adı == textBox6.Text)
                {// çalışanlar.RemoveAt(çalışanlar.IndexOf(çalışanobje));
                    ürn.ürünler.Remove(ürn);
                    MessageBox.Show("ürün silinmiştir");
                    break;
                }
                else
                    MessageBox.Show("ürün bulunamamıştır");
            }
            MessageBox.Show(ürn.adı);*/

            /*
            
             StreamReader oku = new StreamReader(@"D:\\uygulamalar\HAYSİKİM\yeni\ürünler.txt");
            StreamWriter yaz = new StreamWriter(@"D:\\uygulamalar\HAYSİKİM\yeni\yedek.txt");
            string silinecek_satır = textBox6.Text;
            string satır = null;
            while((satır=oku.ReadLine())!=null)
            {
                MessageBox.Show("girdi");
                if (string.Compare(satır, silinecek_satır) == 0)
                    continue;
                yaz.WriteLine(satır);
                if (satır == null)
                    MessageBox.Show("hatalı");
            }
             
             string[] lines = File.ReadAllLines(@"D:\uygulamalar\HAYSİKİM\yeni\kullanıcı.txt");
            label3.Text= lines[2];
            label4.Text = lines[3];
             
             
             
             
            
            */

            string satir = null;
            string silinecek_satir = textBox6.Text;
            

            using (StreamReader reader = new StreamReader(@"D:\\uygulamalar\HAYSİKİM\yeni\ürünler.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"D:\\uygulamalar\HAYSİKİM\yeni\yedek.txt"))
                {
                    int sayaç = Convert.ToInt32(null);
                    while ((satir = reader.ReadLine()) != null)
                    {
                        if (String.Compare(satir, silinecek_satir) == 0)
                        {
                            MessageBox.Show("başarıyla silinmişitir");
                            continue;
                        }
                        writer.WriteLine(satir);

                    }
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
