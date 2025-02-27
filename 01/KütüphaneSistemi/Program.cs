
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        Kutuphane kutuphane = new Kutuphane();
        kutuphane.VerileriYukle(); // 📂 JSON'dan verileri yükle

        int secim;
        do
        {
            Console.WriteLine("\n📚 Kütüphane Sistemi 📚");
            Console.WriteLine("1. Kitap Ekle");
            Console.WriteLine("2. Kitapları Listele");
            Console.WriteLine("3. Kitap Ödünç Al");
            Console.WriteLine("4. Kitap İade Et");
            Console.WriteLine("5. Ödünç Alınan Kitapları Listele");
            Console.WriteLine("6. Çıkış");
            Console.Write("Seçiminizi yapın: ");

            try
            {
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        kutuphane.KitapEkle();
                        break;
                    case 2:
                        kutuphane.KitaplariListele();
                        break;
                    case 3:
                        kutuphane.KitapOduncAl();
                        break;
                    case 4:
                        kutuphane.KitapIadeEt();
                        break;
                    case 5:
                        kutuphane.OduncAlinanKitaplariListele();
                        break;
                    case 6:
                        Console.WriteLine("📖 Kütüphane sisteminden çıkılıyor...");
                        kutuphane.VerileriKaydet(); // 📂 JSON'a verileri kaydet
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

        } while (secim != 6);
    }
}

// 📖 Kitap Sınıfı
class Kitap
{
    public string KitapAdi { get; set; }
    public string Yazar { get; set; }
    public string ISBN { get; set; }
    public bool Mevcut { get; set; } = true;

    public Kitap(string kitapAdi, string yazar, string isbn)
    {
        KitapAdi = kitapAdi;
        Yazar = yazar;
        ISBN = isbn;
    }
}

// 📚 Kütüphane Yönetim Sınıfı
class Kutuphane
{
    //  Kütüphanedeki kitapları tutan liste
    private List<Kitap> kitapListesi = new List<Kitap>();

    //anahtar olarak isbn numarası, değer olarak kitap nesnesi
    private Dictionary<string, Kitap> oduncAlinanKitaplar = new Dictionary<string, Kitap>();

    private readonly string kitaplarDosya = "kitaplar.json";
    private readonly string oduncDosya = "oduncKitaplar.json";

    // 📂 JSON'dan Verileri Yükleme
    public void VerileriYukle()
    {
        try
        {
            if (File.Exists(kitaplarDosya))
            {
                string jsonText = File.ReadAllText(kitaplarDosya);
                
                kitapListesi = JsonConvert.DeserializeObject<List<Kitap>>(jsonText) ?? new List<Kitap>();
            }

            if (File.Exists(oduncDosya))
            {
                string jsonText = File.ReadAllText(oduncDosya);
                //
                oduncAlinanKitaplar = JsonConvert.DeserializeObject<Dictionary<string, Kitap>>(jsonText) ?? new Dictionary<string, Kitap>();
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
            File.WriteAllText(kitaplarDosya, JsonConvert.SerializeObject(kitapListesi, Formatting.Indented));
            File.WriteAllText(oduncDosya, JsonConvert.SerializeObject(oduncAlinanKitaplar, Formatting.Indented));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Veriler kaydedilirken hata oluştu: {ex.Message}");
        }
    }

    // ✅ Kitap Ekleme Metodu
    public void KitapEkle()
    {
        try
        {
            Console.Write("📖 Kitap Adı: ");
            string kitapAdi = Console.ReadLine();

            Console.Write("✍️ Yazar: ");
            string yazar = Console.ReadLine();

            Console.Write("🔖 ISBN: ");
            string isbn = Console.ReadLine();

            kitapListesi.Add(new Kitap(kitapAdi, yazar, isbn));
            Console.WriteLine("✅ Kitap başarıyla eklendi.");
            VerileriKaydet();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Kitap eklenirken hata oluştu: {ex.Message}");
        }
    }

    // ✅ Kitap Ödünç Alma Metodu
    public void KitapOduncAl()
    {
        try
        {
            Console.Write("📖 Ödünç almak istediğiniz kitabın ISBN numarasını girin: ");
            string isbn = Console.ReadLine();

            Kitap kitap = kitapListesi.FirstOrDefault(k => k.ISBN == isbn && k.Mevcut);
            if (kitap != null)
            {
                kitap.Mevcut = false;
                oduncAlinanKitaplar[isbn] = kitap;
                Console.WriteLine($"✅ {kitap.KitapAdi} kitabı ödünç alındı.");
                VerileriKaydet();
            }
            else
            {
                Console.WriteLine("❌ Kitap bulunamadı veya zaten ödünçte.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Ödünç alma işlemi başarısız: {ex.Message}");
        }
    }

    // ✅ Kitap İade Etme Metodu
    public void KitapIadeEt()
    {
        try
        {
            Console.Write("📖 İade etmek istediğiniz kitabın ISBN numarasını girin: ");
            string isbn = Console.ReadLine();

            if (oduncAlinanKitaplar.ContainsKey(isbn))
            {
                Kitap kitap = oduncAlinanKitaplar[isbn];
                kitap.Mevcut = true;
                oduncAlinanKitaplar.Remove(isbn);
                Console.WriteLine($"✅ {kitap.KitapAdi} kitabı iade edildi.");
                VerileriKaydet();
            }
            else
            {
                Console.WriteLine("❌ Bu ISBN numarası ile ödünç alınmış bir kitap bulunamadı.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Kitap iade edilirken hata oluştu: {ex.Message}");
        }
    }

    internal void KitaplariListele()
    {
        Console.WriteLine("\n Kitap Listesi 📚");
        foreach(var kitap in kitapListesi)
        {
            Console.WriteLine($" {kitap.KitapAdi} - {kitap.Yazar} - {kitap.ISBN} - {(kitap.Mevcut ? "Mevcut" : "Ödünçte")}");
        }
    }

    internal void OduncAlinanKitaplariListele()
    {
        Console.WriteLine("\n Ödünç Alınan Kitaplar 📚");
        foreach (var kitap in oduncAlinanKitaplar.Values)
        {
            Console.WriteLine($" {kitap.KitapAdi} - {kitap.Yazar} - {kitap.ISBN}");
        }
    }
}
