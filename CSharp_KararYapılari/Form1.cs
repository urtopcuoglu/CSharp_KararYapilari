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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kolay Örnek
            /*if (textBox1.Text=="Umutcan")
            {
                label1.Text = "Merhaba Dünya";
            }
            else
            {
                MessageBox.Show("Yanlış Cevap Verdin ");
                Application.Exit();
            }*/
            /* int sayi=Convert.ToInt32(textBox1.Text);
             if (sayi == 5)
             {
                 label1.Text="Girdiğin sayı sistemdeki ile doğru";
             }
             else
             {
                 MessageBox.Show("Yanlış Sayı girdin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 Application.Exit(); 
             }*/
            //Atama Operatörü İle işlem yapma
            int sayi = Convert.ToInt32(textBox1.Text);
             if (sayi %2 == 0)
             {
                 label1.Text = "Girilen Sayı 2'nin katı";
             }
             else
             {
                 label1.Text = "Yanlış";
             }
            
            /*int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi >=10 && sayi %2==0)
            {
                label1.Text="Bambamleyluuu";
            }
            else
            {
                label1.Text = "DAAAAT";
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}
