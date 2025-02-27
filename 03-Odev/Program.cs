
#region Mail
/*
namespace _03_Odev
{
    static class Program
    {
        static void Main()
        {
            string mail = "abçöğşkl@gmail.com";
            string sonuc = Turkish2English(mail);
            Console.WriteLine(sonuc);

        }

        static string Turkish2English(string input)
        {
            string[] turkce = { "ğ", "ü", "ı", "ş", "ö", "ç" };
            string[] ingilizce = { "g", "u", "i", "s", "o", "c" };

            for (int i = 0; i < turkce.Length; i++) //input içindeki eşleşenleri değiştiriyor. mail.lengthe göre yüksek performans.
            {
                input = input.Replace(turkce[i], ingilizce[i]);
            }
            return input;
        }
    }
}
*/
#endregion

#region TcKimlikNo

/*
namespace _03_Odev
{
    static class Program
    {
        static void Main()
        {
            string tc = TcIste();
            bool dogruMu = TcKimlikNoDogrulama(tc);
            Console.WriteLine(dogruMu ? "Gçerli TC":"Gçersiz TC");
        }

        private static bool TcKimlikNoDogrulama(string tc)
        {
            if (string.IsNullOrEmpty(tc) || tc.Length != 11 || !long.TryParse(tc, out _)){
                return false;
            }

            int[] tcArray = new int[11]; //tc 11 hanelidir
            for (int i = 0; i < 11; i++)
            {
                tcArray[i] = tc[i] - '0';
            }

            if (tcArray[0] == 0) return false; //ilk deger 0 olamaz

            int teklerToplam = tcArray[0] + tcArray[2] + tcArray[4] + tcArray[6] + tcArray[8];

            int ciftlerToplam = tcArray[1] + tcArray[3] + tcArray[5] + tcArray[7];

            int on = ((teklerToplam * 7) - ciftlerToplam) % 10;

            if (on != tcArray[9]) return false;

            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                toplam += tcArray[i];
            }

            int onbir = toplam % 10;
            if (onbir != tcArray[10]) return false;

            return true;
        }

        private static string TcIste()
        {
            Console.Write("TC giriniz: ");
            return Console.ReadLine();
            
            
        }
    }
}
*/

#endregion

#region ornek1
// İki sayı alıp bu sayıları çarpıcak ve karekökünü geri döndüren metodun bulunduğu uygulamayı yazınız.

/*
namespace _03_Odev
{
    static class Program
    {
        static void Main()
        {
            double sonuc = Karekok(2, 4);
            Console.WriteLine(sonuc);
        }

        static double Karekok(double x, double y)
        {
            double carpim = (x * y);
            return Math.Sqrt(carpim);
        }
    }
}
*/

#endregion

#region ornek2

//Bir metot yazın, parametre olarak bir sayı dizisi alsın ve bu dizideki en büyük sayıyı döndürsün.

/*
namespace _03_Odev
{
    static class Program
    {
        static void Main()
        {
            int[] dizi = { 33, 65, 67, 78, 94, 34 };
            int sonuc = EnBuyuk(dizi);
            Console.WriteLine(sonuc);

        }

        private static int EnBuyuk(int[] dizi)
        {
            int buyuk = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > buyuk)
                    buyuk = dizi[i];

            }
            return buyuk;
        }
    }
}
*/

#endregion

#region ornek3
// Bir metot yazın, parametre olarak bir cümle ve bir harf alsın. Bu cümledeki belirtilen harfin kaç kez geçtiğini döndürsün.

/*
namespace _03_Odev
{
    static class Program
    {
        static void Main()
        {
            string cumle = "Merhaba Dünya!";
            char harf = 'a';
            int sayi = KacKez(cumle, harf);
            Console.WriteLine(sayi);
        
        }

        private static int KacKez(string cumle, char harf)
        {
            int sayac = 0;
            foreach (var item in cumle)
            {
                if (item == harf)
                    sayac++;
            }
            return sayac;

        }
    }
}
*/

#endregion

#region ornek4

//Bir metot yazın, parametre olarak bir sayı dizisi alsın. Bu dizideki tek sayıları yeni bir diziye aktarıp döndürsün.
/*
namespace _03_Odev
{
    static class Program
    {
        static void Main()
        {
            int[] sayilar = {1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] tekSayilar = TekSayilar(sayilar);

            Console.WriteLine(string.Join(", ", tekSayilar));
        }

        private static int[] TekSayilar(int[] dizi)
        {
            List<int> tekler = new List<int>();

            foreach (var item in dizi)
            {
                if (item % 2 != 0)
                    tekler.Add(item);
            }

            return tekler.ToArray();

        }
    }
}
*/

#endregion

#region ornek5
//Bir metot yazın, parametre olarak bir sayı alsın. Bu sayının faktöriyelini döndürsün.

/*
namespace _03_Odev
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine(Faktoriyel(5));
            
        }
        static int Faktoriyel(int sayi)
        {
            int sonuc = 1;
            for (int i = sayi; i >= 1; i--)
            {
                // 5! = 5*4*3*2*1
                sonuc *= i;
            }
            return sonuc;
        }
    }
}
*/

#endregion

#region ornek6

//Bir metot yazın, parametre olarak bir string alıp bu string'in palindrom olup olmadığını kontrol etsin. Palindrom, tersten okunuşu da aynı olan kelimelerdir (örneğin "radar").
/*
namespace _03_Odev
{
    static class Program
    {
        static void Main()
        {
            string kelime = "radar";
            bool sonuc = Palindrom(kelime);
            Console.WriteLine(sonuc);
        }

        private static bool Palindrom(string kelime)
        {
            string ters = "";
            for (int i = kelime.Length - 1; i >= 0; i--)
            {
                ters += kelime[i];
            }
            return kelime == ters.ToString();
        }
    }

}
*/
#endregion

#region ornek7


//Bir metot yazın, parametre olarak bir sayı dizisi alsın ve bu dizinin ortalamasını döndürsün.

/*
namespace _03_Odev
{
    static class Program
    {
        static void Main()
        {
            int[] dizi = { 1, 2, 3, 4, 5 , 6 };
            Console.WriteLine(OrtalamaDondur(dizi));
        }

        static double OrtalamaDondur(int[] dizi)
        {
            int toplam = 0;
            
            foreach (var item in dizi)
            {
                toplam += item;
            }
            double ortalama = (double)toplam / dizi.Length;
            return ortalama;
        }
    }
}
*/
#endregion

#region ornek8

//Bir metot yazın, parametre olarak bir sayı alıp o sayıya kadar olan Fibonacci dizisini döndürsün.
/*
namespace _03_Odev
{
    static class Program
    {
        static void Main()
        {
            int sayi = 5;
            Console.WriteLine(Fibonacci(sayi));

        }

        private static int Fibonacci(int sayi)
        {
            if(sayi == 0) return 0;
            if (sayi == 1) return 1;

            int a=0, b = 1, toplam = 0;
            for (int i = 0; i < sayi; i++)
            {
                toplam = a + b;
                a = b;
                b = toplam;
            }
            return toplam;

            //return Fibonacci(sayi - 1) + Fibonacci(sayi - 2);

        }
    }
}
*/
#endregion

#region ornek9

// Bir metot yazın, parametre olarak bir sayı alıp bu sayının asal olup olmadığını döndürsün.

/*
namespace _03_Odev
{
    static class Program
    {
        static void Main()
        {
            int sayi = 10;
            bool sonuc = AsalMi(sayi);
            Console.WriteLine(sonuc);
        }

        private static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false;
            if (sayi == 2) return true;
            if (sayi % 2 == 0) return false;

            for (int i = 3; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
*/

#endregion

#region ornek10

//Bir metot yazın, parametre olarak bir dizi alıp bu dizinin elemanlarını ters çevirip yeni bir dizi döndürsün.
/*
namespace _03_Odev
{
    static class Program
    {
        static void Main()
        {
            int[] dizi = {1, 2, 3, 4, 5, 6 };
            int[] tersDizi = TersCevir(dizi);
            Console.WriteLine(string.Join(",", tersDizi));
        }

        private static int[] TersCevir(int[] dizi)
        {
            int[] tersDizi = new int[dizi.Length];
            for (int i = 0; i < dizi.Length; i++)
            {
                tersDizi[i] = dizi[dizi.Length - 1 - i];
            }
            return tersDizi; 

        }
    }
}

*/

#endregion

#region ornek11

//Bir metot yazın, parametre olarak bir sayı dizisi alsın ve bu dizideki tüm sayıların çarpımını döndürsün.

/*
namespace _03_Odev
{
    static class Program
    {
        static void Main()
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(Carpimlar(sayilar));
        }

        private static int Carpimlar(int[] sayilar)
        {
            int carpim = 1;
            for(int i = 0; i<sayilar.Length; i++)
            {
                carpim *= sayilar[i];
            }
            return carpim;
        }
    }
}
*/
#endregion

#region ornek12

//Bir metot yazın, parametre olarak bir dizi alıp bu dizideki en küçük ve en büyük sayıyı döndüren bir tuple geri dönsün.

/*
namespace _03_Odev
{
    static class Program
    {
        static void Main()
        {
            int[] dizi = { 1, 2, 3, 4, 5, 6 };
            var sonuc = EnBuyukEnKucuk(dizi);
            Console.WriteLine(sonuc.Item1 + "   " + sonuc.Item2);
        }

        private static (int, int) EnBuyukEnKucuk(int[] dizi)
        {
            int enBuyuk = dizi[0];
            int enKucuk = dizi[0];

            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > enBuyuk)
                {
                    enBuyuk = dizi[i];
                }
                if (dizi[i] < enKucuk)
                { 
                    enKucuk = dizi[i]; 
                }

            }
            return (enBuyuk, enKucuk);
        }
    }
}
*/
#endregion

#region ornek13
//Bir metot yazın, parametre olarak bir string alıp bu string'deki vokal harflerin (a, e, i, o, u) sayısını döndürsün.

/*
namespace _3_Odev
{
    public static class Program
    {
        static void Main()
        {
            string mesaj = "Hello World!";
            int sonuc = Vokaller(mesaj);
            Console.WriteLine(sonuc);
        }

        private static int Vokaller(string mesaj)
        {
            int sayac = 0;
            mesaj = mesaj.ToLower();
            foreach (var item in mesaj)
            {
                if("aeiou".Contains(item))
                {
                    sayac++;
                }
            }
            return sayac;
        }
    }
}
*/
#endregion
