using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayac = 0, kacsatirda = 0;
            foreach (string satir in listBox1.Items)
            {
                if (satir.Contains(textBox2.Text))
                    kacsatirda++;
                foreach (char k in satir)
                {
                    if (k == textBox2.Text[0])
                        sayac++;
                }
            }
            label1.Text = sayac.ToString();
            progressBar1.Value=100/listBox1.Items.Count*kacsatirda;
        }
    }
}
