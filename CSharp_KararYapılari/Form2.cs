using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_KararYapılari
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double s1, s2, proje, performans, ort;
            string durum;
            s1= Convert.ToDouble(textBox1.Text);
            s2= Convert.ToDouble(textBox2.Text);    
            proje= Convert.ToDouble(textBox3.Text); 
            performans= Convert.ToDouble(textBox4.Text);

            ort = (s1+s2+proje+performans) / 4;
            if (ort>=50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }
            lbldurum.Text = ort.ToString("0.00") +" "+ durum;  
        }
    }
}
