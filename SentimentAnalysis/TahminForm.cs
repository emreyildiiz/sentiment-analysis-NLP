using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentimentAnalysis
{
    public partial class TahminForm : Form
    {
        public List<string> metinler;
        public string[] metinClasslari;
        int kacinciTahmin;
        public TahminForm(List<string>metinler,string[] metinClasslari)
        {
            InitializeComponent();
            this.metinler = metinler;
            this.metinClasslari = metinClasslari;
            kacinciTahmin = 1;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains(" "))
            {
                MessageBox.Show("Sadece Tek Bir Sözcük Girin");
                textBox1.Text = "";
            }
        }
        void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TahminEtButton_Click(object sender, EventArgs e)
        {
            
            TahminIslemleri tahminIslemleri = new TahminIslemleri(metinler, metinClasslari);
            richTextBox1.Text += "\n"+kacinciTahmin + ")" + "Girilen Kelime:"+textBox1.Text + "\nTahmin Sonuclari: \n"+tahminIslemleri.NaiveBayesTahmini(textBox1.Text)+"\n";
            kacinciTahmin += 1;
        }
    }
}
