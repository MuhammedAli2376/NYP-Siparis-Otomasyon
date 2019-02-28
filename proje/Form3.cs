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
    public partial class Form3 : Form
    {
        
        
        public Form3()
        {
            InitializeComponent();
            label4.AutoSize = false;
            label4.Width = 4;
            label4.Height = 420;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label5.AutoSize = false;
            label5.Width = 4;
            label5.Height = 420;
            label5.BorderStyle = BorderStyle.Fixed3D;
            string[] oku = File.ReadAllLines(@"D:\toplu\uygulamalar\c#_okul_nesne\HAYSİKİM\yeni\ürünler.txt");
         
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"D:\\toplu\\uygulamalar\\c#_okul_nesne\\HAYSİKİM\\yeni\\Ürünler2.txt");
            Listele();
        }
        public ürün ürn = new ürün();
        public sipariş siparis = new sipariş();
        public kredi_kartı k_kart = new kredi_kartı();
  
      //  public Form6 frm6 = new Form6();
        
        public int toplam_F = 0;

       
        private void button1_Click(object sender, EventArgs e)
        {
            string[] a = new string[5];
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int cell = 0;
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                for (int i = 0; i < item.Cells.Count; i++)
                {
                    a[i]= item.Cells[cell].Value.ToString() + "  ";
                    cell++;

                }

            }

            
            for (int i = 0; i < a.Length; i++)
            {
                if (ürn.marka == null)
                {
                    ürn.marka = a[i];
                    continue;
                }         
                if (ürn.model==null)
                {
                    ürn.model = a[i];
                    continue;
                }
               
                
                if (ürn.fiyat==null)
                {
                    ürn.fiyat = a[i];
                    continue;
                }
                
                
                if (ürn.stok==null)
                {
                    ürn.stok = a[i];
                    continue;
                }
                
                if (ürn.kargo_agırlık == null)
                {
                    ürn.kargo_agırlık = a[i];
                    break;
                   
                }
               
            }
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            Form6 frm = (Form6)Application.OpenForms["Form6"];
            int vergi_F = 0;
            int kargo_F = 0;
            kargo_F += siparis.toplam_agırlık_H(Convert.ToInt32(ürn.kargo_agırlık));
            vergi_F += siparis.vergi_H(Convert.ToInt32(ürn.fiyat));
            toplam_F += siparis.toplam_Fiyat_H(kargo_F, vergi_F,Convert.ToInt32(ürn.fiyat));
            ürn.ürün_ekle(ürn);
            frm.listBox1.Items.Add(ürn.ürün_listele());
            this.Hide();
            k_kart.tutar = toplam_F;
            frm1.frm2.Show();
            Form7 frm7 = (Form7)Application.OpenForms["Form7"];
            frm7.label4.Text = toplam_F.ToString();
            ürn.marka = null;
            ürn.model = null;
            ürn.fiyat = null;
            ürn.stok = null;

        }

        void Listele()
        {
            StreamReader st = new StreamReader(@"D:\\toplu\\uygulamalar\\c#_okul_nesne\\HAYSİKİM\\yeni\\Ürünler2.txt");

            int SatırSayac = 0;
            while (st.Read() > 0)
            {
                st.ReadLine();
                SatırSayac++;
                
            }
            st.Close();
            string satır = "a";
            int row = 0;// int cell = 0;
            string[] lines = File.ReadAllLines(@"D:\\toplu\\uygulamalar\\c#_okul_nesne\\HAYSİKİM\\yeni\\Ürünler2.txt");
            int sayac = 0; int i = 0;

            while (sayac != SatırSayac)
            {
                satır = lines[sayac];
                dataGridView1.Rows.Add();

                string[] parça = satır.Split('-');

                for (i = 0; i < 5; i++)
                {
                    dataGridView1.Rows[row].Cells[i].Value = parça[i];
                }

                sayac++; row++;
            }
        }

       
    }
}
