// donguler for, while, do while

#region genel
/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
*/
/*
for (int i =2; i<=1000; i+=2)
{
    Console.WriteLine(i);
}

for (int i = 1000; i > 0; i -= 2)
{
    Console.WriteLine(i);
}

for (int i = 1; i < 1000; i += 1)
{

    if ( i % 2 != 0);
    Console.WriteLine(i);
}

*/
#endregion

#region ornek_1
//for (int i = 1945; i<=DateTime.Now.Year; i++)
//{
//    if (i == 1990 || i == 1992) Console.ForegroundColor = ConsoleColor.Red;
//    else Console.ForegroundColor = ConsoleColor.White;
//}
//Console.WriteLine(i);


//int toplam = 0;
//try
//{
//    for (int i = 1; i <= 10; i++)
//    {
//        Console.Write(i + ". sayiyi verin:");
//        toplam += Convert.ToInt32(Console.ReadLine());
//    }
//    Console.WriteLine("Toplam = " + toplam);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message); 
//}
#endregion

#region ornek_2
/*
for(int i =1; i<=10; i++)
{
Basla:
    Console.Write($"{i}. sayiyi giriniz: ");
    try
    {
        int sayi = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("sayisal değer girmediniz");
        goto Basla;
    }
}

//veya
int toplam = 0;
for (int i = 1; i <= 10; i++)
{
    Console.Write($"{i}. sayiyi giriniz: ");
    try
    {
        toplam = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("sayisal değer girmediniz");
        i--;
    }
}

*/
#endregion

#region ornek_3

//int i = 1;
//while (i<=10) {
//    Console.WriteLine(i);
//    i++;
//}



//1.soru

//int i = 1000;
//while (i >= 1)
//{
//    Console.WriteLine(i);
//    i--;
//}




//2.soru
/*
int j = 1;
int ciftToplam = 0;
int tekToplam = 0;

while (j <= 100)
{
    if (j % 2 == 0) ciftToplam += j;
    else tekToplam += j;
    j++;
}

Console.WriteLine((ciftToplam - tekToplam) * (ciftToplam - tekToplam));
*/


//3. soru

/*
int toplam = 0;
int i = 0;
while ( i < 10 ){
    Console.WriteLine(i + ".sayıyı girin");
    toplam += int.Parse(Console.ReadLine());
    i++;
}
Console.WriteLine(toplam);
*/
#endregion

#region genel
//do-while

//do
//{
//    //işlemler
//} while (koşul);

#endregion

#region ornek_4
/*
string durum = "yes";

do
{
    Console.WriteLine("Döngünün içindesin");
    Console.WriteLine("devam mı [yes,no]");

    durum = Console.ReadLine();

} while (durum != "no");
Console.WriteLine("Döngünün dışındasın");

*/

#endregion

#region ornek_5
//int sayac = 0;
//do
//{
//    Console.WriteLine(sayac);
//    sayac++;
//} while (sayac <= 100);




//string ad, sifre;
//do
//{

//    Console.Write("Kullanici adi: ");
//    ad = Console.ReadLine();

//    Console.Write("sifre: ");
//    sifre = Console.ReadLine();

//} while (ad != "admin" && sifre != "123");
//Console.WriteLine("giriş başarılı");
#endregion

#region ornek_6
/*
//try-parse

Console.WriteLine("lütfen bir sayi giriniz:");
bool result = int.TryParse(Console.ReadLine(), out int sayi);

if(result) Console.WriteLine(sayi);
else Console.WriteLine("uygun tamsayi değer girmediniz.");

*/
#endregion

#region ornek_7
//1. BAŞLA
//2. x,y
//3. x'i iste.
//4. x var mı diye kontrol et. varsa 5. adıma geç yoksa 3'e.
//5. y'yi iste.
//6. y var mı diye kontrol et. varsa 7. adıma geç yoksa 5'e.
//7. x + y ' yi göster.
//8. BİTİR.

//1. BAŞLA
//2. dogum tarihini iste.
//3. dogum tarihini integer olarak bir değere ata.
//4. bugünkü günden doğum tarihini çıkar
//5. sonucu göster
//6. BİTİR

//1. BAŞLA
//2. sayi iste
//3. 25 tane sayi istendi mi diye kontrol et varsa 4'e devam et yoksa 3'e geri dön
//4. negatif olanları bul
//5. negatif olanları topla
//6. çift sayıları bul
//7. çift olanları topla.
//8. 7'ye eşit olanları bul
//9. kaç tanesi 7'ye eşit bul
//10. ekrana yazdır
//11. BİTİR

/*
int x, y;

while (true)
{
    Console.Write("Lütfen bir x değeri girin: ");
    if (int.TryParse(Console.ReadLine(), out x)) 
        break; 
    Console.WriteLine("Geçerli bir sayı giriniz!");
}

while (true)
{
    Console.Write("Lütfen bir y değeri girin: ");
    if (int.TryParse(Console.ReadLine(), out y)) 
        break;
    Console.WriteLine("Geçerli bir sayı giriniz!");
}

Console.WriteLine($"x + y = {x + y}");

    */

/*
int dogumYili;

do
{
    Console.Write("Doğum yılını girin: ");
}

while (!int.TryParse(Console.ReadLine(), out dogumYili))
{
    Console.Write("Lütfen bir yıl girin: ");
}

int simdikiYil = DateTime.Now.Year;
int yas = simdikiYil - dogumYili;

Console.WriteLine($"Yaş: {yas}");
*/
#endregion

#region ornek2
/*
int sayi, sayiSayaci = 0, negatifToplam = 0, ciftToplam = 0, yediSayisi = 0;

while (sayiSayaci < 25)
{
    Console.Write($"Lütfen {sayiSayaci + 1}. sayıyı girin: ");
    if (int.TryParse(Console.ReadLine(), out sayi))
    {
        if (sayi < 0)
            negatifToplam += sayi;
        
        if (sayi % 2 == 0)
            ciftToplam += sayi;
        
        if (sayi == 7)
            yediSayisi++;

        sayiSayaci++;
    }
    else Console.WriteLine("Geçerli bir sayı giriniz.");
}

Console.WriteLine($"Negatif sayıların toplamı: {negatifToplam}");
Console.WriteLine($"Çift sayıların toplamı: {ciftToplam}");
Console.WriteLine($"7'ye eşit olanların sayısı: {yediSayisi}");
*/
#endregion

#region ornek3
/*
Console.Write("ilk sayıyı giriniz: ");
int ilk = int.Parse(Console.ReadLine());

Console.Write("ikinci sayıyı giriniz: ");
int ikinci = int.Parse(Console.ReadLine());

int toplamIlk = 0, toplamIki = 0;

for (int i = 0; i<ilk; i++)
{
    toplamIlk += i;
}

for (int i = 0; i < ikinci; i++)
{
    toplamIki += i;
}

int sonuc = toplamIlk + toplamIki;
Console.WriteLine(sonuc);
*/
#endregion
