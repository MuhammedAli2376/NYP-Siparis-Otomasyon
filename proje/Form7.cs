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
    public partial class Form7 : Form
    {   public kredi_kartı k_kart = new kredi_kartı();
       
        
        public string[] lines = File.ReadAllLines(@"D:\toplu\uygulamalar\c#_okul_nesne\HAYSİKİM\yeni\kullanıcı.txt");
        public Form7()
        {
            InitializeComponent();  
            label6.AutoSize = false;
            label6.Width = 920;
            label6.Height = 4;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label14.AutoSize = false;
            label14.Width = 920;
            label14.Height = 4;
            label14.BorderStyle = BorderStyle.Fixed3D;
            label7.AutoSize = false;
            label7.Width = 4;
            label7.Height = 420;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label8.AutoSize = false;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Width = 4;
            label8.Height = 420;
            label3.Text = lines[4];
        }

        //Form2 frm2 = new Form2();
        Form2 frm = (Form2)Application.OpenForms["Form2"];

        private void button1_Click(object sender, EventArgs e)
        {
             if(Convert.ToInt32(label3.Text)<Convert.ToInt32(label4.Text))
             {
                 MessageBox.Show("bakiye yetersiz");
                frm.Show();
                this.Hide();
             }
            if (checkBox1.Checked == true)
            {
                textBox1.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                comboBox1.Visible = true;
                textBox4.Visible = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form7_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Form6 frm6 = (Form6)Application.OpenForms["Form6"];
            frm6.listBox1.Items.Clear();
            //frm3.siparis.durum= "yolda";
            //MessageBox.Show(frm3.siparis.durum);
            //sp.durum = 
            if (textBox1.Text==""||comboBox1.Text==""||textBox4.Text=="" )
            {
                MessageBox.Show("bilgileriniz eksiktir");
                this.Hide();
                frm.Show();
                        
            }
            if (textBox1.Text != "" && comboBox1.Text != "" && textBox4.Text != "")
            {
                
                k_kart.no = Convert.ToInt32(textBox1.Text);
                k_kart.tip = comboBox1.Text;
                k_kart.son_kullanma_T = Convert.ToInt32(textBox4.Text);
                
                if (k_kart.yetkili(k_kart.no, k_kart.tip, k_kart.son_kullanma_T)=="olumlu")
                {
                    MessageBox.Show("ödeme tamamlanmıştır");
                    int fark = (Convert.ToInt32(label3.Text) - Convert.ToInt32(label4.Text));
                    label3.Text = fark.ToString();
                    frm.Show();
                    this.Hide();
                    frm.label6.Text = fark.ToString();
                }
               
            }
        }
    }
}
