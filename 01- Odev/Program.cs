#region 1
//Dışarıdan ürün adı girilecek bize hangi bölümde olduğunu söylecek...

//Domates, Biber, Patlican => Meyve ve Sebze Bölümüne bak.
//Diş Macunu, Parfüm, Sabun => Kozmetik Bölümüne bak.
//Cep Telefonu, TV, Bilgisayar => Teknoloji Bölümüne bak.
//Bunların dışında bir ürün => "Bu ürün bizde yok!"....

/*
Console.Write("Hangi ürünü istediğinizi yazınız: ");
string urun = Console.ReadLine();

switch (urun)
{
    case "Domates":
    case "Biber":
    case "Patlican": Console.WriteLine("Meyve ve Sebze Bölümüne bakın.");
        break;

    case "Dis Macunu":
    case "Parfum":
    case "Sabun": Console.WriteLine("Kozmetik bölümüne bakın.");
        break;

    case "Cep Telefonu":
    case "TV":
    case "Bilgisayar": Console.WriteLine("Teknoloji bölümüne bakın.");
        break;

    default: Console.WriteLine("Bu ürün bizde yok!");
        break;
}
*/

#endregion

#region 2
//Dışarıdan siparis alınacak olan kitap miktarı girilsin. Sipariş sayısı 20 den az ise %5, 20-50 arasında ise %10, 50-100 aralığında ise %15, 100 den fazla ise %25 indirim.

//Kitabın birim fiyatı 50 TL

//Toplam Sipariş Miktarı:
//Toplam Fiyat
// Indirim Miktarı
// Ödenecek Miktar

/*
int kitapMik = 0;
int kitapFiyat = 50;
double kitapYeniFiyat = 0;

Console.Write("Sipariş alınacak olan kitap miktarı: ");
kitapMik = int.Parse(Console.ReadLine());

if (kitapMik < 20) kitapYeniFiyat = kitapFiyat - (kitapFiyat * 0.05);
else if (kitapMik < 50) kitapYeniFiyat = kitapFiyat - (kitapFiyat * 0.1);
else if (kitapMik < 100) kitapYeniFiyat = kitapFiyat - (kitapFiyat * 0.15);
else kitapYeniFiyat = kitapFiyat - (kitapFiyat * 0.25);

Console.WriteLine($"Toplam sipariş miktarı: {kitapMik}");
Console.WriteLine($"Toplam fiyat: {kitapMik * kitapFiyat}");
Console.WriteLine($"Indirim miktarı: {kitapMik*(kitapFiyat - kitapYeniFiyat)}");
Console.WriteLine($"Odenecek miktar: {kitapMik * kitapYeniFiyat}");
*/
#endregion

#region 3
//2.	Kullanıcının girdiği iki sayının karelerinin toplamını görüntüleyen programın algoritma ve akış diyagramını çiziniz.
// psüdocode yaz
// Kod yaz

/*
int birinci, ikinci;

try
{

Console.Write("Birinci sayıyı giriniz: ");
birinci = int.Parse(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz: ");
ikinci = int.Parse(Console.ReadLine());

int karelerToplamı = (birinci * birinci) + (ikinci * ikinci);
Console.Write($"Kareler toplamı: {karelerToplamı}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
*/
#endregion

#region 4
//11.Klavyeden girilen 5 adet sayıdan çift sayıların toplamının tek sayıların toplamına oranını bulunuz
/*
int sayac = 0;
int sayi = 0;

int ciftSayi = 0;
int tekSayi = 0;

while (sayac < 5)
{
    Console.WriteLine($"{sayac + 1}. sayiyi yazınız: ");
    if (int.TryParse(Console.ReadLine(), out sayi))

        if (sayi % 2 != 0)
        {
            tekSayi += sayi;
        }
        else
        {
            ciftSayi += sayi;
        }
    sayac++;
}
if (tekSayi != 0)
{
    double oran = (double)ciftSayi / tekSayi;
    Console.WriteLine($"Oran: {oran}");

}
else Console.WriteLine("Payda (tek sayılar) 0 olamaz.");

*/
#endregion

#region 5
//çarpım tablosu
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j} "); //string interpolation | 0 verb
    }
}
#endregion
