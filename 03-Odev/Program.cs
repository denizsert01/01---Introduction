
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













//Bir metot yazın, parametre olarak bir sayı dizisi alsın. Bu dizideki tek sayıları yeni bir diziye aktarıp döndürsün.

//Bir metot yazın, parametre olarak bir sayı alsın. Bu sayının faktöriyelini döndürsün.

//Bir metot yazın, parametre olarak bir string alıp bu string'in palindrom olup olmadığını kontrol etsin. Palindrom, tersten okunuşu da aynı olan kelimelerdir (örneğin "radar").

//Bir metot yazın, parametre olarak bir sayı dizisi alsın ve bu dizinin ortalamasını döndürsün.

//Bir metot yazın, parametre olarak bir sayı alıp o sayıya kadar olan Fibonacci dizisini döndürsün.

// Bir metot yazın, parametre olarak bir sayı alıp bu sayının asal olup olmadığını döndürsün.

//Bir metot yazın, parametre olarak bir dizi alıp bu dizinin elemanlarını ters çevirip yeni bir dizi döndürsün.

//Bir metot yazın, parametre olarak bir sayı dizisi alsın ve bu dizideki tüm sayıların çarpımını döndürsün.

//Bir metot yazın, parametre olarak bir dizi alıp bu dizideki en küçük ve en büyük sayıyı döndüren bir tuple geri dönsün.

//Bir metot yazın, parametre olarak bir string alıp bu string'deki vokal harflerin (a, e, i, o, u) sayısını döndürsün.