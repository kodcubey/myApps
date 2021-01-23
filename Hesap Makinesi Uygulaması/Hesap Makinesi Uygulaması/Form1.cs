using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi_Uygulaması
{
    public partial class Form1 : Form
    {
        char islem;
        double toplam;

        public Form1()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        // esittir.
        private void button10_Click(object sender, EventArgs e)
        {
            if(islem == '+')
            {
                toplam += Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                textBox1.Text = toplam.ToString();
            }
            else if(islem == '-')
            {
                toplam = toplam * -1;
                toplam -= Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                textBox1.Text = toplam.ToString();
            }
            else if (islem == '*')
            {
                toplam *= Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                textBox1.Text = toplam.ToString();
            }
            else if(islem == '/')
            {
                    toplam = toplam / Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    textBox1.Text = toplam.ToString();
            }
            toplam = 0;
            
        }
       
        // + butonu
        private void button12_Click(object sender, EventArgs e)
        {
            islem = '+';
            toplam += Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        // - butonu 
        private void button13_Click(object sender, EventArgs e)
        {
            toplam = 0;
            islem = '-';
            toplam -= Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }
        // * butonu
        private void button14_Click(object sender, EventArgs e)
        {
            toplam = 1;
            islem = '*';
            toplam *= Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }
        // / butonu
        private void button15_Click(object sender, EventArgs e)
        {
            toplam = Convert.ToDouble(textBox1.Text);
            islem = '/';
            toplam /= 1;
            textBox1.Text = "";
        }
        // silme butonu
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

    }
}
