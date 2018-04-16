using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = "Merhaba " + textBox1.Text + " " + textBox2.Text;
            MessageBox.Show(mesaj);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("label2'ye tıklandı..");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form'a tıklandı...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seçili: " + meyveListesi.SelectedItem+"\n"+"Konum: "+meyveListesi.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            meyveListesi.Items.Add(tbEkle.Text);
            tbEkle.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (meyveListesi.SelectedIndex >= 0)
                meyveListesi.Items.RemoveAt(meyveListesi.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string malzemeler = "Alınacak malzemeler: \n";
            int sira = 1;
            foreach (string malzeme in meyveListesi.Items)
            {
                malzemeler += sira++ +". malzeme: "+malzeme + "\n";
            }
            malzemeler += "Toplam malzeme sayısı: " + meyveListesi.Items.Count;
            MessageBox.Show(malzemeler);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (meyveListesi.Items.Contains(tbVarmi.Text))
                MessageBox.Show(tbVarmi.Text + " var.");
            else
                MessageBox.Show(tbVarmi.Text + " yok.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                MessageBox.Show("Checkbox1 seçili.");
            else
                MessageBox.Show("Checkbox1 seçili değil.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(numericUpDown1.Value.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            progressBar1.Value = (progressBar1.Value + 1) % progressBar1.Maximum;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mevcut tarih: " + dateTimePicker1.Value);
        }
    }
}
