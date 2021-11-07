using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_hesaplam_programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sinav1 = Convert.ToInt32(textBox1.Text);
            int sinav2 = Convert.ToInt32(textBox2.Text);
            int per1 = Convert.ToInt32(textBox3.Text);
            int per2 = Convert.ToInt32(textBox4.Text);
            int islem = (sinav1+sinav2+per1+per2)/4;
            label9.Text = islem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sinav1 = Convert.ToInt32(textBoxmats1.Text);
            int sinav2 = Convert.ToInt32(textBoxmats2.Text);
            int per1 = Convert.ToInt32(textBoxmatp1.Text);
            int per2 = Convert.ToInt32(textBoxmatp2.Text);
            int ortalama = (sinav1 + sinav2 + per1 + per2) / 4;
            label13.Text = ortalama.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sinav1 = Convert.ToInt32(textBoxings1.Text);
            int sinav2 = Convert.ToInt32(textBoxingS2.Text);
            int per1 = Convert.ToInt32(textBoxingp1.Text);
            int per2 = Convert.ToInt32(textBoxingP2.Text);
            int ortalama = (sinav1 + sinav2 + per1 + per2) / 4;
            label2.Text = ortalama.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sinav1 = Convert.ToInt32(textBoxdinS1.Text);
            int sinav2 = Convert.ToInt32(textBoxDinS2.Text);
            int per1 = Convert.ToInt32(textBoxDinP1.Text);
            int per2 = Convert.ToInt32(textBoxDİnP2.Text);
            int ortalama = (sinav1 + sinav2 + per1 + per2) / 4;
            label19.Text = ortalama.ToString();
        }
    }
}
