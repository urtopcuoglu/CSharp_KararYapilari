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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            BackColor = Color.BlueViolet;
            ForeColor = Color.White;
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;
            kitapadet = Convert.ToInt16(textBox1.Text);
            if (kitapadet >= 0 && kitapadet <=20)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.20);
                lblsonuc.Text = toplam + " TL";
            }
            if (kitapadet >= 21 && kitapadet <= 40)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.40);
                lblsonuc.Text = toplam + " TL";
            }
            if (kitapadet >= 41)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.60);
                lblsonuc.Text = toplam + " TL";
            }
        }
    }
}
