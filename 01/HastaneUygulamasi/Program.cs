using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        Hastane hastane = new Hastane();
        hastane.VerileriYukle(); // 📂 JSON'dan verileri yükle

        Giris(hastane);
    }

    private static void Giris(Hastane hastane)
    {
        int secim;
        do
        {
            Console.WriteLine("\n HASTANE YÖNETİM SİSTEMİ ");
            Console.WriteLine("1. Hasta Ekle");
            Console.WriteLine("2. Hastaları Listele");
            Console.WriteLine("3. Hasta Güncelle");
            Console.WriteLine("4. Hasta Sil");
            Console.WriteLine("5. Randevu Ekle");
            Console.WriteLine("6. Randevuları Listele");
            Console.WriteLine("7. Çıkış");
            Console.Write("Seçiminizi yapın: ");

            try
            {
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        hastane.HastaEkle();
                        break;
                    case 2:
                        hastane.HastalariListele();
                        break;
                    case 3:
                        hastane.HastaGuncelle();
                        break;
                    case 4:
                        hastane.HastaSil();
                        break;
                    case 5:
                        hastane.RandevuEkle();
                        break;
                    case 6:
                        hastane.RandevulariListele();
                        break;
                    case 7:
                        Console.WriteLine("🏥 Hastane sisteminden çıkılıyor...");
                        hastane.VerileriKaydet(); // 📂 JSON'a verileri kaydet
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("❌ Geçersiz seçim, tekrar deneyin.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("⚠️ Lütfen geçerli bir sayı girin!");
                secim = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Beklenmedik bir hata oluştu: {ex.Message}");
                secim = 0;
            }

        } while (secim != 7);
    }
}

// 🏥 Hasta Sınıfı
class Hasta
{
    public string TC { get; set; }
    public string Ad { get; set; }
    public int Yas { get; set; }
    public string Telefon { get; set; }

    public Hasta(string tc, string ad, int yas, string telefon)
    {
        TC = tc;
        Ad = ad;
        Yas = yas;
        Telefon = telefon;
    }
}

// 📅 Randevu Sınıfı
class Randevu
{
    public string TC { get; set; }
    public string Doktor { get; set; }
    public DateTime Tarih { get; set; }

    public Randevu(string tc, string doktor, DateTime tarih)
    {
        TC = tc;
        Doktor = doktor;
        Tarih = tarih;
    }
}

// 🏥 Hastane Yönetim Sınıfı
class Hastane
{
    private List<Hasta> hastaListesi = new List<Hasta>();
    private List<Randevu> randevuListesi = new List<Randevu>();

    private readonly string hastaDosya = "hastalar.json";
    private readonly string randevuDosya = "randevular.json";

    // 📂 JSON'dan Verileri Yükleme
    public void VerileriYukle()
    {
        try
        {
            if (File.Exists(hastaDosya))
            {
                string jsonText = File.ReadAllText(hastaDosya);
                hastaListesi = JsonConvert.DeserializeObject<List<Hasta>>(jsonText) ?? new List<Hasta>();
            }

            if (File.Exists(randevuDosya))
            {
                string jsonText = File.ReadAllText(randevuDosya);
                randevuListesi = JsonConvert.DeserializeObject<List<Randevu>>(jsonText) ?? new List<Randevu>();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Veriler yüklenirken hata oluştu: {ex.Message}");
        }
    }

    // 📂 JSON'a Verileri Kaydetme
    public void VerileriKaydet()
    {
        try
        {
            File.WriteAllText(hastaDosya, JsonConvert.SerializeObject(hastaListesi, Formatting.Indented));
            File.WriteAllText(randevuDosya, JsonConvert.SerializeObject(randevuListesi, Formatting.Indented));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Veriler kaydedilirken hata oluştu: {ex.Message}");
        }
    }

    // ✅ Hasta Ekleme
    public void HastaEkle()
    {
        Console.Write("🆕 TC Kimlik Numarası: ");
        string tc = Console.ReadLine();

        Console.Write("👤 Hasta Adı: ");
        string ad = Console.ReadLine();

        Console.Write("🎂 Yaş: ");
        int yas = int.Parse(Console.ReadLine());

        Console.Write("📞 Telefon: ");
        string telefon = Console.ReadLine();

        hastaListesi.Add(new Hasta(tc, ad, yas, telefon));
        Console.WriteLine($"✅ {ad} hastası eklendi.");
        VerileriKaydet();
    }

    // ✅ Hastaları Listeleme
    public void HastalariListele()
    {
        if (hastaListesi.Count == 0)
        {
            Console.WriteLine("❌ Kayıtlı hasta bulunmamaktadır.");
            return;
        }

        Console.WriteLine("\n📋 Kayıtlı Hastalar:");
        foreach (var hasta in hastaListesi)
        {
            Console.WriteLine($"👤 {hasta.Ad} - {hasta.TC} - {hasta.Yas} yaş - 📞 {hasta.Telefon}");
        }
    }

    // ✅ Hasta Güncelleme
    public void HastaGuncelle()
    {
        Console.Write("🔄 Güncellemek istediğiniz hastanın TC numarasını girin: ");
        string tc = Console.ReadLine();

        var hasta = hastaListesi.FirstOrDefault(h => h.TC == tc);
        if (hasta != null)
        {
            Console.Write("📞 Yeni Telefon Numarası: ");
            hasta.Telefon = Console.ReadLine();

            Console.WriteLine($"✅ {hasta.Ad} hastasının bilgileri güncellendi.");
            VerileriKaydet();
        }
        else
        {
            Console.WriteLine("❌ Hasta bulunamadı.");
        }
    }

    // ✅ Hasta Silme
    public void HastaSil()
    {
        Console.Write("❌ Silinecek hastanın TC numarasını girin: ");
        string tc = Console.ReadLine();

        var hasta = hastaListesi.FirstOrDefault(h => h.TC == tc);
        if (hasta != null)
        {
            hastaListesi.Remove(hasta);
            Console.WriteLine($"✅ {hasta.Ad} hastası silindi.");
            VerileriKaydet();
        }
        else
        {
            Console.WriteLine("❌ Hasta bulunamadı.");
        }
    }

    // ✅ Randevu Ekleme
    public void RandevuEkle()
    {
        Console.Write("📋 Hasta TC: ");
        string tc = Console.ReadLine();

        Console.Write("👨‍⚕️ Doktor Adı: ");
        string doktor = Console.ReadLine();

        Console.Write("📅 Randevu Tarihi (YYYY-MM-DD): ");
        DateTime tarih = DateTime.Parse(Console.ReadLine());

        randevuListesi.Add(new Randevu(tc, doktor, tarih));
        Console.WriteLine($"✅ Randevu eklendi: {doktor} - {tarih.ToShortDateString()}");
        VerileriKaydet();
    }

    // ✅ Randevuları Listeleme
    public void RandevulariListele()
    {
        if (randevuListesi.Count == 0)
        {
            Console.WriteLine("❌ Kayıtlı randevu bulunmamaktadır.");
            return;
        }

        Console.WriteLine("\n📅 Randevular:");
        foreach (var randevu in randevuListesi)
        {
            Console.WriteLine($"👨‍⚕️ {randevu.Doktor} - 📅 {randevu.Tarih.ToShortDateString()} - TC: {randevu.TC}");
        }
    }
}
