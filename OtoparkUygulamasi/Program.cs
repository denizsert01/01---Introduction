
using System.Text.Json;


namespace OtoparkUygulamasi
{
    internal class Program

    {

        static List<ParkKayitlari> parkKayitlari = new List<ParkKayitlari>();
        static string dosyaYolu = "parkKayitlari.json";

        static void Main(string[] args)
        {
            while (true)
            {
                DosyadanOku();
                Giris();
            }

        }

        private static void Giris()
        {
            Console.WriteLine("***********");
            Console.WriteLine("Hangi işlemi yapacaksınız?");
            Console.WriteLine("1- Araç girişi");
            Console.WriteLine("2- Araç çıkışı");
            Console.WriteLine("3- Otoparktaki araçlar");
            Console.WriteLine("4- Rapor getir");
            Console.WriteLine("5- Çıkış");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    AracGirisi();
                    break;
                case "2":
                    AracCikisi();
                    break;
                case "3":
                    OtoparktakiAraclar();
                    break;
                case "4":
                    RaporGetir();
                    break;
                case "5":
                    DosyayiKaydet();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız.");
                    break;
            }

        }

        private static void DosyayiKaydet()
        {
            File.WriteAllText(dosyaYolu, JsonSerializer.Serialize(parkKayitlari));
        }

        private static void DosyadanOku()
        {
            if (File.Exists(dosyaYolu))
            {
                string jsonData = File.ReadAllText(dosyaYolu);
                parkKayitlari = JsonSerializer.Deserialize<List<ParkKayitlari>>(jsonData) ?? new List<ParkKayitlari>();
            }
        }

        private static void OtoparktakiAraclar()
        {
            var otoparktakiAraclar = parkKayitlari.FindAll(a => a.CikisTarihi == DateTime.MinValue || a.CikisTarihi == null);

            if (otoparktakiAraclar.Count == 0)
            {
                Console.WriteLine("Otoparkta araç bulunmamaktadır.");
                return;
            }

            Console.WriteLine("\nOtoparktaki Araçlar:");
            foreach (var arac in otoparktakiAraclar)
            {
                Console.WriteLine($"Plaka: {arac.AracPlaka}, Tip: {arac.AracTipi}, Giriş: {arac.GirisTarihi}");
            }
        }

        private static void RaporGetir()
        {
            var cikisYapmisAraclar = parkKayitlari.FindAll(a => a.CikisTarihi > a.GirisTarihi);

            if (cikisYapmisAraclar.Count == 0)
            {
                Console.WriteLine("Bugün giriş-çıkış yapan araç bulunmamaktadır.");
                return;
            }

            Console.WriteLine("\nZ Raporu - Günlük İşlemler:");
            foreach (var arac in cikisYapmisAraclar)
            {
                Console.WriteLine($"Plaka: {arac.AracPlaka}, Tip: {arac.AracTipi}, " +
                                  $"Giriş: {arac.GirisTarihi}, Çıkış: {arac.CikisTarihi}, Ücret: {arac.Ucret} TL");
            }
        }

        private static void AracCikisi()
        {
            Console.WriteLine("Çıkış yapacak aracın plakasını giriniz: ");
            string aracPlaka = Console.ReadLine();

            // Park kayıtlari listesindeki aracları kontrol et
            var arac = parkKayitlari.Find(a => a.AracPlaka == aracPlaka && a.CikisTarihi == DateTime.MinValue);

            if (arac == null)
            {
                Console.WriteLine("Bu araç otoparkta bulunamadı");
                return;
            }

            // Araç çıkışı işlemi
            arac.CikisTarihi = DateTime.Now;
            arac.Ucret = UcretHesapla(arac.AracTipi, arac.GirisTarihi, arac.CikisTarihi);

            Console.WriteLine($"Araç çıkış yaptı. Ücret: {arac.Ucret} TL");

            // Veriyi dosyaya kaydet
            DosyayiKaydet();
        }


        private static decimal UcretHesapla(string aracTipi, DateTime girisSaati, DateTime cikisSaati)
        {
            decimal ucret = 0;
            TimeSpan fark = cikisSaati - girisSaati;
            double saat = fark.TotalHours;

            switch (aracTipi)
            {
                case "Araba":
                    ucret = Convert.ToDecimal(saat * 10);
                    break;
                case "Motor":
                    ucret = Convert.ToDecimal(saat * 5);
                    break;
                case "Minibüs":
                    ucret = Convert.ToDecimal(saat * 20);
                    break;
                case "Otobüs":
                    ucret = Convert.ToDecimal(saat * 30);
                    break;
                default:
                    ucret = 0;
                    break;
            }
            //return Tarife.ContainsKey(aracTipi) ? (decimal)saat * Tarife[aracTipi] : 0;
            return ucret;

        }

        public static int kapasite = 20;
        private static void AracGirisi()
        {
            if (parkKayitlari.Count >= kapasite)
            {
                Console.WriteLine("Otopark dolu. Araç girişi yapılamaz.");
                return;
            }
            Console.WriteLine("Araç plakasını giriniz: ");
            string aracPlaka = Console.ReadLine();

            var mevcutArac = parkKayitlari.Find(a => a.AracPlaka == aracPlaka && a.CikisTarihi == DateTime.MinValue);

            if (mevcutArac != null)
            {
                Console.WriteLine("Bu araç içerde bulunuyor.");
                return; // Araç zaten içerde, çıkış yapması bekleniyor.
            }

            Console.WriteLine("Araç tipini girin [Araba, Motor, Minibüs, Otobüs]: ");
            string aracTipi = Console.ReadLine();

            ParkKayitlari yeniKayit = new ParkKayitlari
            {
                AracPlaka = aracPlaka,
                AracTipi = aracTipi,
                GirisTarihi = DateTime.Now,
                CikisTarihi = DateTime.MinValue, // Çıkış yapmamış araç için
            };

            parkKayitlari.Add(yeniKayit); // Listeye ekleniyor
            DosyayiKaydet(); // Dosyaya kaydediyoruz
            Console.WriteLine("Araç otoparka girdi.");
        }


        private static readonly Dictionary<string, decimal> Tarife = new()
        {
            { "Araba", 10m },
            { "Motor", 5m },
            { "Minibüs", 20m },
            { "Otobüs", 30m }
        };
    }

    public class ParkKayitlari
    {
        public string AracPlaka { get; set; }
        public string AracTipi { get; set; }
        public DateTime GirisTarihi { get; set; } = DateTime.Now;
        public DateTime CikisTarihi { get; set; } = DateTime.MinValue;
        public decimal Ucret { get; set; }
    }
}
