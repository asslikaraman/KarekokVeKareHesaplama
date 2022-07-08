using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarekokVeKareHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1;
            double sayi2;
            double sonuc;
            sayi1=Convert.ToInt32(textBox1.Text);
            sayi2=Convert.ToInt32(textBox2.Text);
            sonuc=Math.Pow(sayi1,sayi2);
            label1.Text=sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi3;
            double sonuc2;
            sayi3= Convert.ToInt32(textBox3.Text);
            sonuc2=Math.Sqrt(sayi3);
            label7.Text=sonuc2.ToString();
        }
    }
}
