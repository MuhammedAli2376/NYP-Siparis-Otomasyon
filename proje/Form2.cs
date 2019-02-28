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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
       
        public void Form2_Load(object sender, EventArgs e)
        {

            label3.Text = lines[2];
            label4.Text = lines[3];
            label6.Text = lines[4];
            
            

        }

        public string[] lines = File.ReadAllLines(@"D:\toplu\uygulamalar\c#_okul_nesne\HAYSİKİM\yeni\kullanıcı.txt");
        public Form2 frm2;
        /*
        public void form2()
        {
            
        }*/
        Form3 frm3;
        public void form3 ()
        {
            frm3 = new Form3();
            frm3.Show();
            this.Hide();

        }
        public static Form6 frm6;// static burda hata vemedi olduguna bak
        
        public void form6()
        {
            frm6 = new Form6();
            frm6.Show();
            frm6.Hide();
        }
        public Form7 frm7;
        public void form7()
        {
            frm7 = new Form7();
            frm7.Show();
            frm7.Hide();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (frm3 != null)
                frm3.Show();this.Hide();
            if (frm3 == null )
            {
                form3();
            }
            if (frm6 == null )
            {
                form6();
            }
            if (frm7 == null)
            {
                form7();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = (Form3)Application.OpenForms["Form3"];
            if(frm3==null)
            {
                MessageBox.Show("sipariş detayı yoktur");
            }
            else
            MessageBox.Show("ürün tutarı:"+frm3.toplam_F.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
            Form6 frm = (Form6)Application.OpenForms["Form6"];
            if (frm==null)
            {
                MessageBox.Show("sepetiniz boştur");
            }
            else
            {
                frm.Show();
                this.Hide();
            }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            Form7 frm7 = (Form7)Application.OpenForms["Form7"];
            if (frm7==null)
            {
                MessageBox.Show("satın alınmış ürün yoktur");
            }
            else
            {
                frm7.Show();
                this.Hide();
            }
                
        }

       
    }
}
