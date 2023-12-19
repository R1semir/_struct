using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2struct2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct bilgi
        {
            public string Sehir;
            public int Plaka;
            public string Unlu;
            public string Rengi;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bilgi blg = new bilgi();
            blg.Sehir = textBox1.Text;
            blg.Plaka = Convert.ToInt16(textBox2.Text);
            blg.Unlu = textBox3.Text;
            blg.Rengi = textBox4.Text;

            MessageBox.Show("Şehir: " + blg.Sehir + "\nPlaka: " + blg.Plaka + "\nÜnlü Noktası: " + blg.Unlu + "\nŞehri Temsil Eden Renk: " + blg.Rengi) ;


        }
    }
}
