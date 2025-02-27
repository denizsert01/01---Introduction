
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SatışSistemi
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();
            program.DosyayiAc();
            program.Giris();
        }

        private void Giris()
        {
            Console.WriteLine("********************");
            Console.WriteLine("Bir işlem seçiniz: ");
            Console.WriteLine("1- Ürün Ekle");
            Console.WriteLine("2- Ürünleri Listele");
            Console.WriteLine("3- Ürün Güncelle");
            Console.WriteLine("4- Ürün Sil");
            Console.WriteLine("5- Satış Yap");
            Console.WriteLine("6- Satış Geçmişini Görüntüle");
            Console.WriteLine("7- Çıkış");

            string cevap = Console.ReadLine();

            switch (cevap)
            {
                case "1":
                    UrunEkle();
                    break;
                case "2":
                    UrunleriListele();
                    break;
                case "3":
                    UrunGuncelle();
                    break;
                case "4":
                    UrunSil();
                    break;
                case "5":
                    SatisYap();
                    break;
                case "6":
                    SatisGecmisiniGoruntule();
                    break;
                case "7":
                    Cikis();
                    break;
                default:
                    Console.WriteLine("Gecerli bir sayi girin.");
                    break;
            }
        }

        readonly string urunlerDosyasi = "urunlerDosyasi.json";
        readonly string satisDosyasi = "satisDosyasi.json";


        private List<Urun> urunlerListesi = new List<Urun>();
        private List<Satis> satisListesi = new List<Satis>();

        private void Cikis()
        {
            DosyayiKaydet();
            Console.WriteLine("Uygulamadan çıkılıyor...");
            Environment.Exit(0);
        }
        private void DosyayiAc() //Json'dan oku
        {
            try
            {
                if (File.Exists(urunlerDosyasi))
                {
                    string jsonText = File.ReadAllText(urunlerDosyasi);
                    urunlerListesi = JsonConvert.DeserializeObject<List<Urun>>(jsonText) ?? new List<Urun>();

                }

                if (File.Exists(satisDosyasi))
                {
                    string jsonText = File.ReadAllText(satisDosyasi);
                    satisListesi = JsonConvert.DeserializeObject<List<Satis>>(jsonText) ?? new List<Satis>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Dosyayı açarken bir hata oluştu: {ex.Message}");
            }

        }
        private void DosyayiKaydet() //Json'a kaydet
        {
            File.WriteAllText(urunlerDosyasi, JsonConvert.SerializeObject(urunlerListesi, Formatting.Indented));

            File.WriteAllText(satisDosyasi, JsonConvert.SerializeObject(satisListesi, Formatting.Indented));

        }

        private void SatisGecmisiniGoruntule()
        {

            if (satisListesi != null)
            {

                Console.WriteLine("Satış geçmişi görüntüleniyor: ");

                foreach (var satis in satisListesi)
                {
                    Console.WriteLine($"{satis.Miktar} - {satis.Tarih}");
                }

            }
            else
            {
                Console.WriteLine("Satis gecmisi bulunmuyor.");
            }
        }

        private void SatisYap()
        {
            Console.WriteLine("Almak istediğiniz ürünün id'sini girin: ");
            string id = Console.ReadLine();

            var urun = urunlerListesi.FirstOrDefault(u => u.ID == id);

            if (id != null)
            {
                Console.WriteLine("Satın almak istediğiniz miktar: ");
                int miktar = int.Parse(Console.ReadLine());

                if (miktar < urun.Stok)
                {
                    urun.Stok -= miktar;
                    satisListesi.Add(new Satis(urun.Isim, miktar, DateTime.Now, urun.Ucret));
                    Console.WriteLine("Satis yapıldı.");
                    DosyayiKaydet();
                }
                else
                {
                    Console.WriteLine("Stok yetersiz.");
                }

            }
            else
            {
                Console.WriteLine("Ürün bulunamadı.");
            }
        }

        private void UrunSil()
        {
            Console.WriteLine("Silmek istediğiniz ürünün id'sini girin: ");
            string id = Console.ReadLine();

            var urun = urunlerListesi.FirstOrDefault(u => u.ID == id);
            if (id != null)
            {
                urunlerListesi.Remove(urun);
                Console.WriteLine("Ürün silindi");
                DosyayiKaydet();
            }
            else
            {
                Console.WriteLine("Ürün bulunamadı.");
            }
        }

        private void UrunGuncelle()
        {
            Console.WriteLine("Güncellemek istediğiniz ürünün id'sini girin: ");
            string id = Console.ReadLine();
            var urun = urunlerListesi.FirstOrDefault(u => u.ID == id);

            if (id != null)
            {
                Console.WriteLine("Yeni fiyatı girin: ");
                urun.Ucret = double.Parse(Console.ReadLine());

                Console.WriteLine("Ürün güncellendi");
                DosyayiKaydet();
            }
            else
            {
                Console.WriteLine("Ürün bulunamadı");
               
            }
        }

        private void UrunleriListele()
        {
            if (urunlerListesi.Count == 0)
            {
                Console.WriteLine("Ürün bulunamadı.");
                return;
            }
            else
            {
                Console.WriteLine("Ürünler listeleniyor...");

                foreach (var urun in urunlerListesi)
                {
                    Console.WriteLine($" {urun.ID} - {urun.Isim} - {urun.Ucret}");
                }
            }

        }

        private void UrunEkle()
        {

            try
            {
                Console.WriteLine("Eklemek istediğiniz ürünün id'si: ");
                string id = Console.ReadLine();

                Console.WriteLine("İsmi: ");
                string isim = Console.ReadLine();

                Console.WriteLine("Ücreti: ");
                double ucret = double.Parse(Console.ReadLine());

                Console.WriteLine("Stok: ");
                int stok = int.Parse(Console.ReadLine());

                if (id != null)
                {
                    urunlerListesi.Add(new Urun(ucret, isim, id, stok));
                    DosyayiKaydet();
                    Console.WriteLine("Ürün eklendi.");
                }
                else
                {
                    Console.WriteLine("Düzgün bir id giriniz.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ürünü eklerken bir hata oluştu {ex}");
            }

        }
    }

    public class Urun
    {
        public double Ucret { get; set; }
        public string Isim { get; set; }

        public string ID { get; set; }

        public int Stok { get; set; }


        public Urun(double ucret, string isim, string id, int stok)
        {
            Ucret = ucret;
            Isim = isim;
            ID = id;
            Stok = stok;

        }
    }

    public class Satis
    {
        public string Isim { get; set; }
        public int Miktar { get; set; }
        public DateTime Tarih { get; set; }

        public double ToplamTutar { get; set; }

        

        public Satis(string Isim, int miktar, DateTime tarih, double toplamTutar)
        {
            Miktar = miktar;
            Tarih = tarih;
            Isim = Isim;
            ToplamTutar = toplamTutar;
        }

    }
}
