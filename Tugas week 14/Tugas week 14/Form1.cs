using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_week_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kal = textBox1.Text;
            int n = kal.Length;
            int asc = 0;  
            string huf = textBox2.Text;
            int aschuf;
            aschuf = (int)huf[0];
            string jadi = textBox3.Text;
            int ascjadi;
            ascjadi = (int)jadi[0]; 
            label5.Text = " ";
            int c = 0;
            while (aschuf != ascjadi)
            {
                aschuf++;
                c++;
            }
           
            for (int i = 0; i < n; i++)
            {
                asc = (int)kal[i] + c;
                label5.Text += Char.ConvertFromUtf32(asc).ToUpper();
            }
           


        }
    }
}