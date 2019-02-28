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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            label2.AutoSize = false;
            label2.Width = 620;
            label2.Height = 4;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label3.AutoSize = false;
            label3.Width = 620;
            label3.Height = 4;
            label3.BorderStyle = BorderStyle.Fixed3D;
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            //  public Form2 frm2 = new Form2();
            Form2 frm = (Form2)Application.OpenForms["Form2"];
            frm.Show();
            this.Hide();
        }
    }
}
