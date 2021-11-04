using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        void sayilaritopla(int s1, int s2)
        {
            int toplam = s1 + s2;
            MessageBox.Show(toplam.ToString());
        }
        
        private void button_toplama_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox_topla_sayi1.Text);
            int sayi2 = Convert.ToInt32(textBox_topla_sayi2.Text);
            sayilaritopla(sayi1,sayi2);
        }


        void sayilaricikart(int s1, int s2)
        {
            int toplam = s1 - s2;
            MessageBox.Show(toplam.ToString());
        }
        private void button_cıkart_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox_cıkart_sayi1.Text);
            int sayi2 = Convert.ToInt32(textBox_cıkart_sayi2.Text);
            sayilaricikart(sayi1, sayi2);
        }


        void sayilaricarp(int s1, int s2)
        {
            int toplam = s1 * s2;
            MessageBox.Show(toplam.ToString());
        }
        private void button_carpma_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox_carpma_sayi1.Text);
            int sayi2 = Convert.ToInt32(textBox_carpma_sayi2.Text);
            sayilaricarp(sayi1, sayi2);
        }

        void sayilaribol(int s1, int s2)
        {
            int toplam = s1 / s2;
            MessageBox.Show(toplam.ToString());
        }
        private void button_bolme_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox_bolme_sayi1.Text);
            int sayi2 = Convert.ToInt32(textBox_bolme_sayi2.Text);
            sayilaribol(sayi1, sayi2);
        }
    }
}
