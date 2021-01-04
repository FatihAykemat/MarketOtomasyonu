using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdev
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {

           InitializeComponent();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
       
        private void button1_Click(object sender, EventArgs e)
          {
             Form1 form1 = new Form1();
            
            if (kullaniciAdi.Text == "admin" && sifreText.Text == "1234")
            {
                form1.panel2.Visible = false;
                form1.panel4.Visible = false;
               
            }
            else if (kullaniciAdi.Text == "müdür" && sifreText.Text == "1234")
            {
                form1.panel2.Visible = true;
                form1.panel4.Visible = true;

            }
            form1.login = kullaniciAdi.Text;
            form1.Show();
            this.Hide();

        }

       
    }
}


