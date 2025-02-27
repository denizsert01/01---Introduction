using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Otobüsleri oluşturuyoruz
        var otobus1 = new Otobus("34AB1234");
        var otobus2 = new Otobus("06CD5678");

        // Yolcuları oluşturuyoruz
        var yolcu1 = new Yolcu("Ali", "Veli", 30, "Erkek");
        var yolcu2 = new Yolcu("Ayşe", "Yılmaz", 25, "Kadın");

        // Bilet alma işlemi
        otobus1.BiletAl(yolcu1, DateTime.Now.AddDays(1), 120);
        otobus2.BiletAl(yolcu2, DateTime.Now.AddDays(2), 150);

        // Biletleri listeleme işlemi
        Console.WriteLine("Biletler:");
        otobus1.BiletleriListele();
        otobus2.BiletleriListele();
    }
}
public class Yolcu
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int Yas { get; set; }
    public string Cinsiyet { get; set; }

    public Yolcu(string ad, string soyad, int yas, string cinsiyet)
    {
        Ad = ad;
        Soyad = soyad;
        Yas = yas;
        Cinsiyet = cinsiyet;
    }

    public override string ToString()
    {
        return $"{Ad} {Soyad}, Yaş: {Yas}, Cinsiyet: {Cinsiyet}";
    }
}

public class Bilet
{
    public Yolcu Yolcu { get; set; }
    public string OtobusPlakasi { get; set; }
    public DateTime SeferTarihi { get; set; }
    public decimal Fiyat { get; set; }

    public Bilet(Yolcu yolcu, string otobusPlakasi, DateTime seferTarihi, decimal fiyat)
    {
        Yolcu = yolcu;
        OtobusPlakasi = otobusPlakasi;
        SeferTarihi = seferTarihi;
        Fiyat = fiyat;
    }

    public override string ToString()
    {
        return $"{Yolcu.ToString()}, Otobüs Plakası: {OtobusPlakasi}, Tarih: {SeferTarihi.ToShortDateString()}, Fiyat: {Fiyat} TL";
    }
}

public class Otobus
{
    public string Plaka { get; set; }
    public List<Bilet> Biletler { get; set; }

    public Otobus(string plaka)
    {
        Plaka = plaka;
        Biletler = new List<Bilet>();
    }

    public void BiletAl(Yolcu yolcu, DateTime seferTarihi, decimal fiyat)
    {
        var bilet = new Bilet(yolcu, Plaka, seferTarihi, fiyat);
        Biletler.Add(bilet);
        Console.WriteLine("Bilet başarıyla alındı.");
    }

    public void BiletleriListele()
    {
        Console.WriteLine($"Otobüs Plakası: {Plaka}");
        foreach (var bilet in Biletler)
        {
            Console.WriteLine(bilet.ToString());
        }
    }
}
