#region 2
// 2- iki sayinin toplamı
/*
int x, y, z;
Console.Write("x değerini giriniz: ");
x = int.Parse(Console.ReadLine());

Console.Write("y değerini giriniz: ");
y = int.Parse(Console.ReadLine());

z = x + y;
Console.WriteLine($"Toplam: {z}");
*/
#endregion

#region 3
// 3- Kullanıcının girdiği iki sayının karelerinin toplamını görüntüle

/*
int x, y, z;
Console.Write("ilk değeri giriniz: ");
x = int.Parse(Console.ReadLine());

Console.Write("ikinci değeri giriniz: ");
y = int.Parse(Console.ReadLine());

z = (x * x) + (y * y);

Console.WriteLine($"Kareler toplamı: {z}");
*/
#endregion

#region 4
// 4- 1'den 100'e kadar olan sayılarının küplerinin toplamını bul
/*
int toplam = 0;
for (int i = 0; i <= 100; i++)
{
    toplam += (i * i * i);
}

Console.WriteLine($"1-100 arası küpler toplamı: {toplam}");
*/

#endregion

#region 5
//5- Doğum tarihi girilen kişinin yaşını hesapla
/*
Console.WriteLine("Doğum tarihinizi giriniz (yil-ay-gun)");
string tarih = Console.ReadLine();

if (DateTime.TryParse(tarih, out DateTime dogumYili))
{
    DateTime bugun = DateTime.Today;
    int yas = bugun.Year - dogumYili.Year;

    if (dogumYili.Date > bugun.AddYears(-yas))
        yas--;

    Console.WriteLine($"Yasiniz: {yas}");
}
else
    Console.WriteLine("Gecersiz tarih");

*/
#endregion

#region 6
//6- Girilen sayının faktöriyelini bul
/*
int faktoriyel = 1;
Console.WriteLine("Sayı giriniz: ");
int sayi = int.Parse(Console.ReadLine());

for (int i = 0; i < sayi; i++)
{
    faktoriyel += faktoriyel * i;
}

Console.WriteLine($"Faktoriyel: {faktoriyel}");
*/

#endregion

#region 7
//7- Çarpma işlemini toplama kullanarak bul
/*
int carpim = 0;

Console.WriteLine($"1. sayıyı giriniz: ");
int ilk = int.Parse(Console.ReadLine());

Console.WriteLine($"2. sayıyı giriniz: ");
int iki = int.Parse(Console.ReadLine());

while(iki>0)
{
    carpim = carpim + ilk;
    iki--;
}

Console.WriteLine($"Sonuc= {carpim}");
*/

#endregion

#region 8
//8- Bölme işlemini çıkarma kullanarak yap

/*
double bolme = 0;

Console.WriteLine($"1. sayıyı giriniz: ");
double bolunen = int.Parse(Console.ReadLine());

Console.WriteLine($"2. sayıyı giriniz: ");
double bolen = int.Parse(Console.ReadLine());

if(bolen == 0)
{
    Console.WriteLine("Sıfıra bölünemez.");
    return;
}


while (bolunen >= bolen)
{
    bolunen -= bolen;
    bolme++;
}

Console.WriteLine($"bolum = {bolme}");
*/
#endregion

#region 9
//9- Girilen sayının istenilen sayıya göre mod işlemini yaptır
/*
Baslangic:
Console.WriteLine($"Sayıyı giriniz: ");
int ilk = int.Parse(Console.ReadLine());

Console.WriteLine($"Hangi sayıya göre mod alınsın: ");
int iki = int.Parse(Console.ReadLine());

if (ilk < iki)
{
    Console.WriteLine("Sayı daha büyük olmalıdır");
    goto Baslangic;
}
else Console.WriteLine($"{ilk} mod {iki} = {ilk % iki}");
*/
#endregion

#region 10

//10- Girilen sayının kaç basamaklı olduğunu söyle
/*
Console.WriteLine($"Sayıyı giriniz: ");
string sayi = Console.ReadLine();

List<char> harfler = sayi.ToList();
int bsm = 0;
foreach (var item in harfler)
{
    bsm++;
}
Console.WriteLine(bsm);
*/
#endregion

#region 11

//11- Girilen 3 basamaklı bir sayının basamaklarının küpleri toplamı sayının kendine  eşit olup olmadığını bul

/*
Baslangic:
Console.WriteLine($"3 basamaklı bir sayı giriniz: ");
int sayi = int.Parse(Console.ReadLine());

if (sayi < 100 || sayi >999)
{
    Console.WriteLine("3 basamaklı bir sayı girmediniz.");
    goto Baslangic;
}

int birler = sayi % 10;
int onlar = (sayi / 10) % 10;
int yuzler = sayi / 100;

int kuplerToplami = (birler * birler * birler) + (onlar * onlar * onlar) + (yuzler * yuzler * yuzler);

if(kuplerToplami == sayi)
    Console.WriteLine("Küpler toplamı kendisine eşittir");
else Console.WriteLine("Küpler toplamı kendisine eşit değildir");
*/

#endregion

#region 12

// 12-  Klavyeden girilen 20 adet sayıdan çift sayıların toplamının tek sayıların toplamına oranını bul

/*
int sayac = 0;
int sayi;
int cift = 0;
int tek = 0;


while (sayac < 20)
{
    Console.WriteLine($"{sayac + 1}. sayıyı giriniz: ");
    sayi = int.Parse(Console.ReadLine());

    if (sayi % 2 == 0)
        cift += sayi;
    else
        tek += sayi;

    sayac++;

}

if (tek != 0)
    Console.WriteLine($"Oran = {(double)cift/tek}");
else Console.WriteLine("Tek sayilar toplamı bölme islemi sebebiyle 0 olamaz.");
*/

#endregion

#region 13
//13- 10 ile 1000 arasındaki tam kare sayıları ekrana yazdır

/*
int i = 4; // çünkü 3*3=9 10dan kücük degil
while (i * i < 1000)
{
    Console.WriteLine(i * i);
    i++;
}
*/
#endregion

#region 14
//14-  Klavyeden girilen 25 adet sayı içerisinden negatif olanların toplamını, çift sayıların çarpımını, 7'ye eşit olanların adetini bulup ekrana yazdır
/*
int sayac = 0;
int sayi;
int neg = 0;
int cift = 1;
bool ciftVarMi = false;
int yedi = 0;

while (sayac < 25)
{
    Console.WriteLine($"{sayac + 1}. sayıyı giriniz: ");
    sayi = int.Parse(Console.ReadLine());

    if (sayi < 0)
        neg += sayi;
if (sayi % 2 == 0)
    {
        ciftVarMi = true;
        cift *= sayi;
    }

    if (sayi == 7)
        yedi++;
        
    sayac++;
}

Console.WriteLine($"Negatiflerin toplamı: {neg} \nÇiftlerin çarpımı: {cift} \n7'ye eşit olanların adedi: {yedi}");
*/
#endregion

#region 15

//15 - Çarpım Tablosu

/*
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
}
*/
#endregion

#region 16

//16- Girilen sayının 5'in kuvveti olup olmadığını bul
/*
Console.Write("Bir sayı giriniz: ");
int sayi = int.Parse(Console.ReadLine());

while(sayi % 5 == 0)
{
    sayi /= 5;
}

if (sayi < 1) Console.WriteLine("5'in kuvveti değildir");
else if (sayi == 1) Console.WriteLine("Bu sayı 5'in kuvvetidir.");

else Console.WriteLine("5'in kuvveti değildir");
*/
#endregion

#region 17

//17-  X,Y pozitif olmak üzere, eğer x sayısının çarpanları toplamı y sayısına ve aynı zamanda y sayısının çarpanları toplamı x sayısına eşit ise bu sayılar dost sayılardır. Buna göre girilen iki sayının dost olup olmadığını bul
/*
Console.Write("Bir sayı giriniz: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Bir sayı giriniz: ");
int y = int.Parse(Console.ReadLine());

if(x>0 && y>0)
{
    int carpanX = 0, carpanY = 0;

    for (int i = 1; i < x; i++)
    {
        if (x / i == 0) carpanX += i;
    }
    for (int i = 1; i < y; i++)
    {
        if (y / i == 0) carpanY += i;
    }

    if(carpanX == carpanY) Console.WriteLine("Dost sayılardır");
    else Console.WriteLine("Dost sayılar değillerdir.");
}
else Console.WriteLine("Pozitif sayı girin.");
*/

#endregion

#region 18
//18-  Fibonacci serisinin ilk 10 terimini ekrana bas (kendisi ve ondan önceki sayıların toplamı)
/*
int terimSay = 10;
int fibonacci = 0;
for (int i = terimSay; i > 0; i--)
{
    fibonacci += i;
}
Console.WriteLine($"Fibonacci(10) = {fibonacci}");
*/
#endregion

#region 19
//19- Klavyeden girilen bir sayının negatif, pozitif veya 0 olup olmadığını bul
/*
try
{
Console.Write("Bir sayı giriniz: ");
int x = int.Parse(Console.ReadLine());

if (x > 0) Console.WriteLine("Pozitif");
else if (x == 0) Console.WriteLine("0");
else if (x < 0) Console.WriteLine("Negatif");
}
catch (Exception ex)
{
    Console.WriteLine("Bir sayı girmediniz");
}
*/
#endregion

#region 20
//20-  Girilen sayının mükemmel sayı olup olmadığını bul
/*
Console.Write("Bir sayı giriniz: ");
int x = int.Parse(Console.ReadLine());
int toplam = 0;
for (int i = 1; i < x; i++)
{
    if (x % i == 0)
    {
        toplam += i;
    }
}

if (x == toplam) Console.WriteLine("Mükemmel sayı!");
else Console.WriteLine("Maalesef mükemmel sayı değil.");
*/
#endregion
