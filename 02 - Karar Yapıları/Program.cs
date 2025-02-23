// Karar Yapıları
#region Genel
/*
 * 
 * if (true) {
 * kosul dogruysa calisir
 * }
 * 
 * else if(true) {
 * kosul dogruysa calisir
 * }
 * 
 * else {
 * kosul dogru degilse calisir
 * }
 
 */
#endregion

#region Haftanın Günleri
// ctrl + K + S region alma
// ctrl + K + D kodları düzenler
// ctrl + K + C yoruma alma
// ctrl + K + U yorumdan çıkarma
// ctrl + S
// ctrl + X

/*

// kullanıcıdan 1-7 arasında bir sayı alın.
// girilen değere göre haftanın gününü ekrana yazdır.

Console.WriteLine("1-7 arasında bir gün giriniz.");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1) Console.WriteLine("Pazartesi");
else if (a == 2) Console.WriteLine("Salı");
else if (a == 3) Console.WriteLine("Çarşamba");
else if (a == 4) Console.WriteLine("Perşembe");
else if (a == 5) Console.WriteLine("Cuma");
else if (a == 6) Console.WriteLine("Cumartesi");
else if (a == 7) Console.WriteLine("Pazar");
else Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
*/

#endregion

#region Ornek1
// 0dan kücük 100den büyük olmamalı
// kullanıcıya çıktı verilecek output "Lütfen yaşınızı giriniz 0-100"
// kullanici yaşını girecek input, gelen değeri int.Parse(). kullaniciYasi integer tipinde.
//<0>100 geçersiz yaş
// else geçerli yaş
/*
Console.WriteLine("Lütfen yaşınızı giriniz 0-100");
int yas = int.Parse(Console.ReadLine());

if (yas < 100 && yas > 0)  Console.WriteLine("gecerli yas");
else  Console.WriteLine("gecersiz yas");

//veya
if (yas <= 0 || yas >= 100) Console.WriteLine("gecersiz yas");
else Console.WriteLine("gecerli yas");
*/
#endregion

#region ornek2
/*
vizeNotuBaslangic:
Console.WriteLine("Lütfen vize notunuzu giriniz 0-100");
int not1 = int.Parse(Console.ReadLine());

finalNotuBaslangic:
Console.WriteLine("Lütfen final notunuzu giriniz 0-100"); // output
int not2 = int.Parse(Console.ReadLine()); //input, assign

if (not2 < 0 || not2 > 100)
{
    Console.WriteLine("0 ile 100 arasında değer girmediniz");
    goto finalNotuBaslangic;
}

if (not1 < 0 || not1 > 100)
{
    Console.WriteLine("0 ile 100 arasında değer girmediniz");
    goto vizeNotuBaslangic;
}

//veya
if ((not2 < 0 || not2 > 100) || (not1 < 0 || not1 > 100))
{
    Console.WriteLine("0 ile 100 arasında değer girmediniz");
    if (not2 < 0 || not2 > 100) goto finalNotuBaslangic;
    if (not1 < 0 || not1 > 100) goto vizeNotuBaslangic;
}

int not1agirlik = not1 * 30 / 100;
int not2agirlik = not1 * 70 / 100;
double sonuc = not1agirlik + not2agirlik;

if (sonuc < 30 && sonuc >= 0)
    Console.WriteLine("FF");

else if (sonuc < 50 && sonuc >= 30)
    Console.WriteLine("CC");

else if (sonuc < 70 && sonuc >= 50)
    Console.WriteLine("BB");

else if (sonuc <= 100 && sonuc >= 70)
    Console.WriteLine("AA");
else
    Console.WriteLine("Hatalı giriş");
*/
#endregion

#region TernaryIf
//ternary if tek satırda işlemi bitirme

//sözdizimi : kosul? true:false;

/*
int sayi1;

if (3 > 2)
    sayi1 = 10;
else
    sayi1 = 5;

int sayi2 = (3 > 2) ? 10 : 5;
*/

#endregion

#region ornek3

/*
Console.WriteLine("kullanıcı adı");
string deger = Console.ReadLine();

string result = deger.Length > 0 ? deger : "default";
Console.WriteLine(result);
*/

#endregion

#region ornek4
/*
//dışardan girilen sayi tek mi cift mi ekrana yazdirin
Console.WriteLine("bir sayi giriniz: ");
int deger = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((deger % 2 == 0) ? "cift" : "tek");
*/
#endregion

#region ornek5
/*
Console.WriteLine("kullanıcınin not ortalaması");
int ort = Convert.ToInt32(Console.ReadLine());

string sonuc = (ort > 90) ? "AA":
    (ort > 80) ? "BB":
    (ort > 70) ? "CC" : 
    "kaldınız";
Console.WriteLine(sonuc);

*/
#endregion

#region Switch Case
/*
 * switch (kosul)
 *      case "a":statement; break;
 *      case "b":statement; break;
 *      case "c":statement; break;
 *      default:statement; break;
 */
#endregion

#region ornek6
/*

Console.WriteLine("bir mevsim giriniz: ");
string mevsim = Console.ReadLine();

switch (mevsim)
{
    case "Kış": Console.WriteLine("Ocak", "Şubat", "Mart"); break;
    case "Bahar": Console.WriteLine("Mart", "Nisan", "Mayıs"); break;
    case "Yaz": Console.WriteLine("Haziran", "Temmuz", "Ağustos"); break;
    case "Sonbahar": Console.WriteLine("Eylül", "Ekim", "Kasım"); break;
    default:  Console.WriteLine("düzgün bir mevsim giriniz"); break;
}
    
*/
#endregion

#region ornek7
/*
Console.WriteLine("birini giriniz: Admin, Yönetici, CEO, Başkan, uye: ");
string user = Console.ReadLine();
switch (user)
{
    case "Admin":
    case "Yonetici":
    case "CEO":
    case "Baskan": Console.WriteLine("Yonetim paneline hosgeldiniz"); break;
    case "uye": Console.WriteLine("Anasayfaya hosgeldiniz"); break;
    default: Console.WriteLine("giris yetkiniz yok"); break;
}
*/
#endregion





