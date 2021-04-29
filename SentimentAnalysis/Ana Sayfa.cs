using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SentimentAnalysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FileDialogButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                SecilenPath.Text = folderBrowser.SelectedPath;
                devamButton.Enabled = true;
            }
        }

        private void devamButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Varsayılan Sınıflarla Devam Edilsin Mi?", "Sınıf", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Sınıf_Seç sınıf_Seç = new Sınıf_Seç(SecilenPath.Text,true);
                sınıf_Seç.Show();
            }
            else
            {
                Sınıf_Seç sınıf_Seç = new Sınıf_Seç(SecilenPath.Text,false);
                sınıf_Seç.Show();
            }


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "1)Program ve ödev hakkında bilgiler:" +
                "\n-Bu program 'Binary Multinomial Naive Bayes' yöntemiyle, Sentiment Analysis yapar." +
                "\n-Ödev için benim yolladığım ,hazırlanmış metin belgesini seçmelisiniz. Aksi takdirde en başta manuel sınıflama formu başlar." +
                "\n-Devam et butonundan sonra lütfen Varsayılanlarla devam et kısmında evete basınız.(Aksi takdirde manuel sınıflama formu başlar.)" +
                "\n-Manuel Sınıflama formu, benim işimi kolaylaştırmak için yazıldı ama dilerseniz metinlerin sınıflarını kendiniz değiştirebilirsiniz." +
                "\n-Ödev için gerekli olan kısım Sonuç Göster butonunda bulunuyor.Sonrasında tahmin et butonuyla tahmin yapabilirsiniz." +
                "\n\n\n2)Yapılan metin işlemleri:" + "\n-Metinlerin classlari manuel yolla belirlendi. " + "\n-Metinler tokenize edildi." +
                "\n-Stop-wordsler silindi." + "\n-Zemberek uygulamasıyla kelimeler kökleriyle değiştirildi(Bazı kelimelerde Zemberek işe yaramıyor.)" +
                "\n-Kelimelerin kaç çeşit olduğu bulundu, eşsiz kaç kelime var hesaplandı." +
                "\n-TahminIslemleri classinda Naive Bayes için gerekli hesaplamalar yapıldı." + "\n-Tahmin edilen sınıf yazdirildi.";
            MessageBox.Show(s, "Yardim");















        }
    }
}
