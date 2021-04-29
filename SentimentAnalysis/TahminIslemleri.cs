using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using net.zemberek.erisim;
using net.zemberek.yapi;
using net.zemberek.tr.yapi;
using System.IO;
using System.Collections;

namespace SentimentAnalysis
{
    public class TahminIslemleri
    {
        public List<string> metinler;
        public string[] metinClasslari;
        public static ArrayList stopWords;
        public List<String[]> tokenizeMetinler;
        public List<List<string>>islenmisKayitlar;
        public List<string> uniqueWords;
        public static void StopWordsInput() //stopwords.txt dosyasındaki kelimeleri alıp stopWords listesine atar.
        {
            stopWords = new ArrayList();
            string currentDirectory = Directory.GetCurrentDirectory();
            string dosyaYolu = System.IO.Path.Combine(currentDirectory, "stopwords.txt");
            StreamReader srr = new StreamReader(dosyaYolu, Encoding.Default);
            var fs = new FileStream(dosyaYolu, FileMode.Open, FileAccess.Read);
            var sr = new StreamReader(fs, Encoding.Default);

            string line = String.Empty;

            while ((line = sr.ReadLine()) != null)
            {
                stopWords.Add(line);
            }
            Console.WriteLine("(Tamamlandı!)");
        }
        public static List<String[]> Tokenizer(List<string> liste)//cümleleri kelimelere böler.
        {
            
            char[] seperator = { ',', ' ', '.', '\'', '\"', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '\\', '=', '-', '_', '#', '%', '*','\n','\r'};
            List<String[]> tokenizeListe = new List<String[]>();
            foreach (string cumle in liste)
            {
                if (cumle != null)
                {
                    string[] kelimeler = cumle.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < kelimeler.Length; i++)
                    {
                        kelimeler[i] = kelimeler[i].ToLower();
                    }
                    tokenizeListe.Add(kelimeler);
                }
            }
            
            return tokenizeListe;
        }
        public static List<List<string>> StopWordsSil(List<String[]> liste)//stopwords listesinde bulunan kelimeleri kayıtlardan siler
        {
            List<List<string>> stopWordsuzList = new List<List<string>>();
            for (int i = 0; i < liste.Count; i++)
            {
                List<string> arrayList = new List<string>();
                for (int j = 0; j < liste[i].Length; j++)
                {
                    if (!stopWords.Contains(liste[i][j]))
                    {
                        arrayList.Add(liste[i][j]);
                    }
                }
                stopWordsuzList.Add(arrayList);
            }
            return stopWordsuzList;
        }
        public static void KoklereAyir(List<List<string>> liste) // kayıtları kelimelere göre köklerine ayırır
        {
            Zemberek zemberek = new Zemberek(new TurkiyeTurkcesi());
            for (int i = 0; i < liste.Count; i++)
            {
                for (int j = 0; j < liste[i].Count - 1; j++)
                {
                    if (zemberek.kelimeDenetle(liste[i][j].ToString()))
                    {
                        liste[i][j] = zemberek.kelimeCozumle(liste[i][j].ToString())[0].kok().icerik();
                    }
                }
            }
        }
        public static List<string> OzellikleriBul(List<List<string>> liste)// Bu metod iki iş yapar kayıtların köklere indirilmiş halini,attributes olarak bir 2d dizinin 0.satirina atar.Ve 3'den az geçen veya 50'den fazla geçen kelimeleri kayıtlardan siler.
        {
            Console.Write("*Attributeslar seçiliyor...");
            List<string> Ozellikler = new List<string>();

            List<string> gecenKelimeler = new List<string>();
            List<int> kelimelerinGecmeSayisi = new List<int>();
            for (int i = 0; i < liste.Count; i++)
            {
                for (int j = 0; j < liste[i].Count; j++)
                {
                    if (!Ozellikler.Contains(liste[i][j]))
                    {
                        Ozellikler.Add(liste[i][j]);
                        gecenKelimeler.Add(liste[i][j]);
                        kelimelerinGecmeSayisi.Add(1);
                    }
                    else
                    {
                        int gecenIndex = gecenKelimeler.IndexOf(liste[i][j]);
                        kelimelerinGecmeSayisi[gecenIndex] += 1;
                    }
                }
            }
            
            Console.WriteLine("(Tamamlandı!)");
            return Ozellikler;
        }
        public string NaiveBayesTahmini(string kelime)
        {
            double olumluKayitSayisi = 0;double olumsuzKayitSayisi = 0; double notrKayitSayisi = 0; 
            
            for (int i = 0; i < this.metinClasslari.Length; i++)
            {
                if (metinClasslari[i].Equals("Olumlu"))
                {
                    olumluKayitSayisi += 1;
                }
                else if (metinClasslari[i].Equals("Olumsuz"))
                {
                    olumsuzKayitSayisi += 1;
                }
                else if (metinClasslari[i].Equals("Notr"))
                {
                    notrKayitSayisi += 1;
                }
            }
            double olumluClassOlasilik = olumluKayitSayisi / Convert.ToDouble(this.metinler.Count);
            double olumsuzClassOlasilik = olumsuzKayitSayisi / Convert.ToDouble(this.metinler.Count);
            double notrClassOlasilik = notrKayitSayisi / Convert.ToDouble(this.metinler.Count);
            double sozcugunOlumludaGecmeSayisi = 0; double sozcugunOlumsuzdaGecmeSayisi = 0; double sozcugunNotrdeGecmeSayisi = 0;
            for(int i = 0; i < this.islenmisKayitlar.Count; i++)
            {
                for (int j = 0; j < this.islenmisKayitlar[i].Count; j++)
                {
                    if (kelime.Equals(this.islenmisKayitlar[i][j]))
                    {
                        if (this.metinClasslari[i].Equals("Olumlu"))
                        {
                            sozcugunOlumludaGecmeSayisi += 1;
                        }
                        else if (this.metinClasslari[i].Equals("Olumsuz"))
                        {
                            sozcugunOlumsuzdaGecmeSayisi += 1;
                        }
                        else if (this.metinClasslari[i].Equals("Notr"))
                        {
                            sozcugunNotrdeGecmeSayisi += 1;
                        }
                        break;
                    }
                }
            }
            double olumluNaiveBayes = olumluClassOlasilik * (sozcugunOlumludaGecmeSayisi + 1) / (olumluKayitSayisi + Convert.ToDouble(this.uniqueWords.Count));
            double olumsuzNaiveBayes = olumsuzClassOlasilik * (sozcugunOlumsuzdaGecmeSayisi + 1) / (olumsuzKayitSayisi + Convert.ToDouble(this.uniqueWords.Count));
            double notrNaiveBayes = notrClassOlasilik * (sozcugunNotrdeGecmeSayisi + 1) / (notrKayitSayisi + Convert.ToDouble(this.uniqueWords.Count));
            if (olumluNaiveBayes > notrNaiveBayes && olumluNaiveBayes > olumsuzNaiveBayes)
            {
                return "Class = Olumlu\n" + "p="+olumluNaiveBayes.ToString();
            }
            else if(olumsuzNaiveBayes > notrNaiveBayes && olumsuzNaiveBayes > olumluNaiveBayes)
            {
                return "Class = Olumsuz\n" + "p="+olumsuzNaiveBayes.ToString();
            }
            else
            {
                return "Class = Notr\n" + "p="+notrNaiveBayes.ToString();
            }
        }
        public TahminIslemleri(List<string>metinler,string[] metinClasslari)
        {
            this.metinClasslari = metinClasslari;
            this.metinler = metinler;
            StopWordsInput();
            tokenizeMetinler = Tokenizer(this.metinler);
            List<List<string>> stopWordssuzKayitlar = StopWordsSil(tokenizeMetinler);
            this.islenmisKayitlar = stopWordssuzKayitlar;
            this.uniqueWords = new List<string>();
            KoklereAyir(this.islenmisKayitlar);
            this.uniqueWords = OzellikleriBul(this.islenmisKayitlar);
            
        }
    }
}
