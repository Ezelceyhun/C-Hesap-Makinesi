using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev_proje_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double toplam;
        double sayi_1,sayi_2;
        int deger = 0;
        string toplam_isaret = "+";
        string cikarma_isaret = "-";
        string bolme_isaret = "/";
        string carpma_isaret = "*";
        private void button_0_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button_0_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void button_toplama_Click(object sender, EventArgs e)
        {
            sayi_1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text;
            label1.Text = label1.Text + toplam_isaret;
            textBox1.Text = "";
            deger = 0;
        }

        private void button_cikarma_Click(object sender, EventArgs e)
        {
            sayi_1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text;
            label1.Text = label1.Text + cikarma_isaret;
            textBox1.Text = "";
            deger = 1;
        }

        private void button_carpma_Click(object sender, EventArgs e)
        {
            sayi_1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text;
            label1.Text = label1.Text + carpma_isaret;
            textBox1.Text = "";
            deger = 2;
        }

        private void button_bolme_Click(object sender, EventArgs e)
        {
            sayi_1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text;
            label1.Text = label1.Text + bolme_isaret;
            textBox1.Text = "";
            deger = 3;
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            label1.Text = "Hesaplama Yap";
            textBox1.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {          
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button_6_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button_virgul_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + ",";
            }
            else
            {
                textBox1.Text = ""; 
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void button_km_m_Click(object sender, EventArgs e)
        {
            sayi_1 = Convert.ToDouble(textBox1.Text);
            toplam = sayi_1 * 1000;
            label1.Text =sayi_1.ToString() + " KM " + toplam.ToString() + " M ";
        }

        private void button_m_cm_Click(object sender, EventArgs e)
        {
            sayi_1 = Convert.ToDouble(textBox1.Text);
            toplam = sayi_1 * 100;
            label1.Text = sayi_1.ToString() + " M " + toplam.ToString() + " CM ";
        }

        private void button_cm_m_Click(object sender, EventArgs e)
        {
            sayi_1 = Convert.ToDouble(textBox1.Text);
            toplam = sayi_1 / 100;
            label1.Text = sayi_1.ToString() + " CM " + toplam.ToString() + " M ";
        }

        private void button_m_km_Click(object sender, EventArgs e)
        {
            sayi_1 = Convert.ToDouble(textBox1.Text);
            toplam = sayi_1 / 1000;
            label1.Text = sayi_1.ToString() + " M " + toplam.ToString() + " KM ";
        }

        private void button_uslu_Click(object sender, EventArgs e)
        {
            sayi_1 = Convert.ToDouble(textBox1.Text);
            label1.Text = sayi_1 + "^";
            label2.Text = sayi_1.ToString();
            textBox1.Text = "";
            deger = 4;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button_gonder_Click(object sender, EventArgs e)
        {
            if(deger == 0)
            {
                sayi_2 = Convert.ToDouble(textBox1.Text);
                toplam = sayi_1 + sayi_2;
                label1.Text = label1.Text + textBox1.Text + " = ";               
                label1.Text = label1.Text + toplam;
                textBox1.Text = toplam.ToString();
            }
            else if(deger == 1)
            {
                sayi_2 = Convert.ToDouble(textBox1.Text);
                toplam = sayi_1 - sayi_2;
                label1.Text = label1.Text + textBox1.Text + " = ";
                label1.Text = label1.Text + toplam;
                textBox1.Text = toplam.ToString();
            }
            else if(deger == 2)
            {
                sayi_2 = Convert.ToDouble(textBox1.Text);
                toplam = sayi_1 * sayi_2;
                label1.Text = label1.Text + textBox1.Text + " = ";
                label1.Text = label1.Text + toplam;
                textBox1.Text = toplam.ToString();
            }
            else if (deger == 3)
            {
                sayi_2 = Convert.ToDouble(textBox1.Text);
                toplam = sayi_1 / sayi_2;
                label1.Text = label1.Text + textBox1.Text + " = ";
                label1.Text = label1.Text + toplam;
                textBox1.Text = toplam.ToString();
            }
            else if(deger == 4)
            {
                sayi_2 = Convert.ToDouble(textBox1.Text);
                label1.Text = sayi_1 + "^" + sayi_2;
                toplam = 1;
                toplam = sayi_1 * sayi_1;
                for (int i = 1; i < sayi_2 - 1; i++)
                {
                    toplam = toplam * sayi_1;
                }
                label1.Text = label1.Text + " = " + toplam;
                textBox1.Text = toplam.ToString();
            }
        }
    }
}
