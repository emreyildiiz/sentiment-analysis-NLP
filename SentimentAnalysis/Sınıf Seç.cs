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
    public partial class Sınıf_Seç : Form
    {
        public string path;
        public List<string> dosyaIsimleri;
        public List<string> metinler;
        public string[] metinClass;
        public int metinIterator;
        public bool sonaGit;
        public Sınıf_Seç(string Path,bool sonaGit)
        {
            dosyaIsimleri = new List<string>();
            metinler = new List<string>();
            this.sonaGit = sonaGit;
            metinIterator = 0;
            InitializeComponent();
            path = Path;
            
        }
        private bool ClassBilgisiMevcutmu()
        {
            bool classBilgisiMevcutmu = false;
            if (metinler[metinIterator].Contains("~~Olumlu~~"))
            {
                classBilgisiMevcutmu = true;
            }
            else if (metinler[metinIterator].Contains("~~Olumsuz~~"))
            {
                classBilgisiMevcutmu = true;
            }
            else if (metinler[metinIterator].Contains("~~Notr~~"))
            {
                classBilgisiMevcutmu = true;
            }
            return classBilgisiMevcutmu;
        }
        private void SınıfBelirle(bool classBilgisi)
        {
            bool classBilgisiMevcutmu = classBilgisi;
            if (olumluRadioButton.Checked == true)
            {
                if(classBilgisiMevcutmu == true)
                {
                    if (metinler[metinIterator].Contains("~~Olumsuz~~"))
                    {
                        metinler[metinIterator] = metinler[metinIterator].Replace("~~Olumsuz~~", "~~Olumlu~~");
                    }
                    else if (metinler[metinIterator].Contains("~~Notr~~"))
                    {
                        metinler[metinIterator] = metinler[metinIterator].Replace("~~Notr~~", "~~Olumlu~~");
                    }
                    File.WriteAllText(path + "\\" + dosyaIsimleri[metinIterator], metinler[metinIterator],Encoding.Default);
                    metinClass[metinIterator] = "Olumlu";
                }
                else
                {
                    File.AppendAllText(path + "\\" + dosyaIsimleri[metinIterator], "\nClass : ~~Olumlu~~");
                    metinler[metinIterator] += "\n Class = ~~Olumlu~~";
                    metinClass[metinIterator] = "Olumlu";
                }
                
                

            }
            else if (notrRadioButton.Checked == true)
            {
                if (classBilgisiMevcutmu == true)
                {
                    if (metinler[metinIterator].Contains("~~Olumsuz~~"))
                    {
                        metinler[metinIterator] = metinler[metinIterator].Replace("~~Olumsuz~~", "~~Notr~~");
                    }
                    else if (metinler[metinIterator].Contains("~~Olumlu~~"))
                    {
                        metinler[metinIterator] = metinler[metinIterator].Replace("~~Olumlu~~", "~~Notr~~");
                    }
                    File.WriteAllText(path + "\\" + dosyaIsimleri[metinIterator], metinler[metinIterator], Encoding.Default);
                    metinClass[metinIterator] = "Notr";
                }
                else
                {
                    File.AppendAllText(path + "\\" + dosyaIsimleri[metinIterator], "\nClass : ~~Notr~~");
                    metinler[metinIterator] += "\n Class = ~~Notr~~";
                    metinClass[metinIterator] = "Notr";
                }
                
                
            }
            else
            {
                if (classBilgisiMevcutmu == true)
                {
                    if (metinler[metinIterator].Contains("~~Olumlu~~"))
                    {
                        metinler[metinIterator] = metinler[metinIterator].Replace("~~Olumlu~~", "~~Olumsuz~~");
                    }
                    else if (metinler[metinIterator].Contains("~~Notr~~"))
                    {
                        metinler[metinIterator] = metinler[metinIterator].Replace("~~Notr~~", "~~Olumsuz~~");
                    }
                    Console.WriteLine(metinler[metinIterator]);
                    File.WriteAllText(path + "\\" + dosyaIsimleri[metinIterator], metinler[metinIterator], Encoding.Default);
                    metinClass[metinIterator] = "Olumsuz";
                }
                else
                {
                    File.AppendAllText(path + "\\" + dosyaIsimleri[metinIterator], "\nClass : ~~Olumsuz~~", Encoding.Default);
                    metinler[metinIterator] += "\n Class = ~~Olumsuz~~";
                    metinClass[metinIterator] = "Olumsuz";
                }
                
                
            }
            metinIterator += 1;
        }
        public void VarsayilanSınıf()
        {
            for (int i = 0; i < metinler.Count; i++)
            {
                if (metinler[i].Contains("~~Olumlu~~"))
                {
                    metinClass[i] = "Olumlu";
                }
                else if (metinler[i].Contains("~~Olumsuz~~"))
                {
                    metinClass[i] = "Olumsuz";
                }
                else if (metinler[i].Contains("~~Notr~~"))
                {
                    metinClass[i] = "Notr";
                }
                else
                {
                    metinClass[i] = "Sınıflanmamış";
                }
            }
        }
        private void Sınıf_Seç_Load(object sender, EventArgs e)
        {
            var txtFiles = Directory.EnumerateFiles(path, "*.txt");
            foreach (string file in txtFiles)
            {
                dosyaIsimleri.Add(file.Substring(path.Length + 1));
                StreamReader reader = new StreamReader(file, Encoding.Default);
                metinler.Add(reader.ReadToEnd());
            }
            metinClass = new string[metinler.Count];
            if (this.sonaGit == false)
            {
                MetinTextBox.Text = metinler[0];
                DosyaIsmi.Text = dosyaIsimleri[0];
            }
            else
            {
                VarsayilanSınıf();
                sonrakiMetinButton.Enabled = false;
                Tahmin.Enabled = true;
                metinTitle.Text = "Sonuclar";
                panel1.Visible = false;
                label1.Visible = false;
                SonucYazdir();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool classBilgisiMevcutmu = ClassBilgisiMevcutmu();
            OncekiMetinButton.Enabled = true;
            SınıfBelirle(classBilgisiMevcutmu);
            MetinTextBox.Clear();
            try
            {
                MetinTextBox.Text = metinler[metinIterator];
                DosyaIsmi.Text = dosyaIsimleri[metinIterator];
            }
            catch (System.ArgumentOutOfRangeException)
            {
                sonrakiMetinButton.Enabled = false;
                bitirButton.Enabled = true;
            } 
        }
        
        private void SonucYazdir()
        {
            int i = 0;
            int olumluSayisi = 0;
            int olumsuzSayisi = 0;
            int notrSayisi = 0;
            int siniflanmamısSayisi = 0;
            MetinTextBox.Clear();
            for (i = 0; i < metinler.Count; i++)
            {
                MetinTextBox.Text += dosyaIsimleri[i] + "-------->" + metinClass[i] + "\n";
            }
            DosyaIsmiLabel.Text = "Sonuclar";
            for (i = 0; i < metinClass.Length; i++)
            {
                if (metinClass[i].Equals("Olumlu"))
                {
                    olumluSayisi += 1;
                }
                else if (metinClass[i].Equals("Olumsuz"))
                {
                    olumsuzSayisi += 1;
                }
                else if (metinClass[i].Equals("Notr"))
                {
                    notrSayisi += 1;
                }
                else
                {
                    siniflanmamısSayisi += 1;
                }
            }
            DosyaIsmi.Text = "Olumlu Sayisi = " + olumluSayisi + "\nOlumsuz Sayisi = " + olumsuzSayisi + "\nNotr Sayisi = " + notrSayisi + "\nSınıflanmamış Sayisi = " + siniflanmamısSayisi;
        }
        private void bitirButton_Click(object sender, EventArgs e)
        {
            SonucYazdir();
            Tahmin.Enabled = true;
        }

        private void OncekiMetinButton_Click(object sender, EventArgs e)
        {
            metinIterator -= 1;
            MetinTextBox.Clear();
            MetinTextBox.Text = metinler[metinIterator];
            DosyaIsmi.Text = dosyaIsimleri[metinIterator];
            if(metinIterator == 0)
            {
                OncekiMetinButton.Enabled = false;
            }
            sonrakiMetinButton.Enabled = true;
            
            
        }

        private void Tahmin_Click(object sender, EventArgs e)
        {
            this.Close();
            TahminForm tahminForm = new TahminForm(metinler,metinClass);
            tahminForm.Show();
            
        
        }
    }
}
