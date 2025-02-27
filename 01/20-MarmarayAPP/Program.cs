using Newtonsoft.Json;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace _20_MarmarayAPP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
        }

        static Dictionary<string, dynamic> YolcuBilgileri = new Dictionary<string, dynamic>();
         
        private static void Menu()
        {
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");
            Console.WriteLine("1- Kişi Listele");
            Console.WriteLine("2- Kişi Ekle");
            Console.WriteLine("3- Biniş İşlemi");
            Console.WriteLine("4- İniş İşlemi"); // iade
            Console.WriteLine("5- Z Raporu");
            Console.WriteLine("6- Çıkış");
            Console.WriteLine("*********");

            int gelenDeger = int.Parse(Console.ReadLine());

            switch (gelenDeger)
            {
                case 1: KisiListele(); break;
                case 2: KisiEkle(); break;
                case 3: BinisIslemi(); break;
                case 4: InisIslemi(); break;
                case 5: ZRaporu(); break;
                case 6: Environment.Exit(0); break;

                default:
                    Console.WriteLine("Menu dışı seçim yaptınız");
                    break;
            }
        }

        private static void ZRaporu()
        {
            List<YolcuBilgi> yolcuListesi = JsonDosyadanVerileriGetir();

            double toplam = 0;
            foreach (var yolcu in yolcuListesi)
            {
                Console.WriteLine($"{yolcu.Tarih} {yolcu.KisiId} {yolcu.AdSoyad} {marmarayDuraklari[yolcu.BinisDurakId]} {marmarayDuraklari[yolcu.InisDurakId]} {yolcu.Ucret}");

                toplam += yolcu.Ucret;
            }

            Console.WriteLine($"Toplam Yolcu Sayısı: {yolcuListesi.Count}\nToplam Ücret: {toplam}");
        }

        private static List<YolcuBilgi> JsonDosyadanVerileriGetir()
        {
            string json = File.ReadAllText("yolcu_kayitlari.json");
            List<YolcuBilgi> yolcuListesi = JsonConvert.DeserializeObject<List<YolcuBilgi>>(json);
            return yolcuListesi;
        }

        private static void InisIslemi()
        {
            // Kisiyi seç
            KisiListele();
            int secilenKisiId = int.Parse(Console.ReadLine());
            // Durak Seç
            DurakListesi();
            int secilenDurakId = int.Parse(Console.ReadLine());

            // İade Alacak mısın?
            Console.WriteLine("İade İşlemi Yapmak İstiyor musunuz? E/H");
            bool iadeEdilecekMi = Console.ReadLine().ToLower() == "e";

            double ucret = Hesapla(secilenKisiId, secilenDurakId, iadeEdilecekMi);

            // Json ile dosyaya ekle
            //Tarih, KisiId, AdSoyad, BindigiDurak, IndigiDurak, Ucret
            DosyayaKaydet(secilenKisiId, secilenDurakId, ucret);

            // Kişiyi binenlerListesi'nden sil
            binenlerListesi.Remove(secilenKisiId);
            // Todo: Bakiye güncelle

        }

        private static void DosyayaKaydet(int secilenKisiId, int inisDurakId, double ucret)
        {
            List<YolcuBilgi> yolcuListesi = JsonDosyadanVerileriGetir();

            YolcuBilgi yolcuBilgi = new YolcuBilgi()
            {
                Tarih = DateTime.Now,
                KisiId = secilenKisiId,
                AdSoyad = kisiListesi[secilenKisiId],
                BinisDurakId = binenlerListesi[secilenKisiId],
                InisDurakId = inisDurakId,
                Ucret = ucret
            };
            yolcuListesi.Add(yolcuBilgi);

            string json = JsonConvert.SerializeObject(yolcuListesi, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("yolcu_kayitlari.json", json);
        }

        static List<double> ucretler = new List<double> { 27, 34.72, 40.08, 46.22, 53.99, 59.76 };

        private static double Hesapla(int kisiId, int inisDurakId, bool iadeEdilecekMi)
        {
            double ucret = ucretler[ucretler.Count - 1];

            if (iadeEdilecekMi)
            {
                binenlerListesi.TryGetValue(kisiId, out int binisDurakId);
                //int binisDurakId = binenlerListesi[secilenKisiId];

                int durakSayisi = Math.Abs(binisDurakId - inisDurakId);

                if (durakSayisi >= 1 && durakSayisi <= 7)
                    ucret = ucretler[0];
                else if (durakSayisi >= 8 && durakSayisi <= 14)
                    ucret = ucretler[1];
                else if (durakSayisi >= 15 && durakSayisi <= 21)
                    ucret = ucretler[2];
                else if (durakSayisi >= 22 && durakSayisi <= 28)
                    ucret = ucretler[3];
                else if (durakSayisi >= 29 && durakSayisi <= 35)
                    ucret = ucretler[4];
                else
                    ucret = ucretler[5];
            }
            // Kurallar
            /*
                 Marmaray Ücretlendirme
                Durak Arası	        Tam Bilet	Öğrenci	Sosyal	Akbil
                1 – 7 İstasyon	    ₺27,00	    ₺13,18	₺19,33	1
                8 – 14 İstasyon	    ₺34,72	    ₺16,23	₺23,53	2
                15 – 21 İstasyon	₺40,08	    ₺19,33	₺28,16	2
                22 – 28 İstasyon	₺46,22	    ₺21,98	₺32,78	3
                29 – 35 İstasyon	₺53,99	    ₺25,84	₺38,57	3
                36 – 43 İstasyon	₺59,76	    ₺27,00	₺41,66	4

                 */

            return ucret;
        }

        private static void KisiEkle()
        {
            Console.WriteLine("Eklemek istediğiniz kişinin Kart ID'sini giriniz:");
            int kartId = int.Parse(Console.ReadLine());
            Console.WriteLine("Eklemek istediğiniz kişinin Adını Soyadını giriniz:");
            string adSoyad = Console.ReadLine();

            kisiListesi.Add(kartId, adSoyad);

            // Todo: Kisiyi KisilerListesi ismindeki json uzantılı dosyaya ekleyebilirsiniz.
        }

        // kisiId, BindigiDurakId
        static Dictionary<int, int> binenlerListesi = new Dictionary<int, int>();
        static Dictionary<int, string> kisiListesi = new Dictionary<int, string>();

        static List<string> marmarayDuraklari = new List<string>
        {
            "Gebze", "Darıca", "Osmangazi", "Fatih", "Çayırova", "Tuzla", "İçmeler", "Aydıntepe", "Güzelyalı",
            "Tersane", "Kaynarca", "Pendik", "Yunus", "Kartal", "Başak", "Atalar", "Cevizli", "Maltepe",
            "Süreyya Plajı", "İdealtepe", "Küçükyalı", "Bostancı", "Suadiye", "Erenköy", "Göztepe", "Feneryolu",
            "Söğütlüçeşme", "Ayrılık Çeşmesi", "Üsküdar", "Sirkeci", "Yenikapı", "Kazlıçeşme", "Zeytinburnu",
            "Yenimahalle", "Bakırköy", "Ataköy", "Yeşilyurt", "Yeşilköy", "Florya Akvaryum", "Florya",
            "Küçükçekmece", "Mustafa Kemal", "Halkalı"
        };

        private static void BinisIslemi()
        {
            // Kisileri Listele
            KisiListele();
            // Kisi Seç
            int secilenKisiId = int.Parse(Console.ReadLine());
            // İnmemiş Kişiyi seçme
            bool kisiVarMi = binenlerListesi.ContainsKey(secilenKisiId);

            // DurakSeç
            DurakListesi();

            int secilenDurakId = int.Parse(Console.ReadLine());

            // Binenler Listesine Ekle
            if (!kisiVarMi)
            {
                binenlerListesi.Add(secilenKisiId, secilenDurakId);
            }

            // ToDo: Bakiye kontrolü

        }

        private static void DurakListesi()
        {
            Console.WriteLine("Durakların Listesi");

            for (int i = 0; i < marmarayDuraklari.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {marmarayDuraklari[i]}");
            }
        }


        private static void KisiListele()
        {
            Console.WriteLine("Kişiler Listesi");
            foreach (var kisi in kisiListesi)
            {
                Console.WriteLine($"{kisi.Key} - {kisi.Value}");
            }
        }
    }
}

