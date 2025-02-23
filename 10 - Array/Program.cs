
#region Maas Hesapla
// maaş hesapla
// kaç kişinin maaşını girmek istiyorsunuz
// isimler, ücretler double, çalışma saatleri int
//ekrana yazdırmak ister misiniz e/h

/*
int kisisay = 0;
do
{
    Console.Write("kaç kişinin maaşını girmek istiyorsunuz");

} while (!int.TryParse(Console.ReadLine(), out kisisay));



//int kisisay = 0;

//Console.Write("kaç kişinin maaşını girmek istiyorsunuz");
//kisisay = int.Parse(Console.ReadLine());



string[] isimler = new string[kisisay];
double[] ucretler = new double[kisisay];
int[] saatler = new int[kisisay];

for (int i = 0; i < kisisay; i++)
{
    Console.WriteLine($"{i + 1}. kişinin ismi: ");
    isimler[i] = Console.ReadLine().Trim();

//    Console.WriteLine($"{i + 1}. kişinin ücreti: ");
//    ucretler[i] = double.Parse(Console.ReadLine());
  

   do
   {
        Console.WriteLine($"{i + 1}. kişinin ücreti: ");

    } while (!double.TryParse(Console.ReadLine(), out ucretler[i]));

//    Console.WriteLine($"{i + 1}. kişinin calisma saati: ");
//    saatler[i] = int.Parse(Console.ReadLine());

    do
    {
        Console.WriteLine($"{i + 1}. kişinin calisma saati: ");
    } while (int.TryParse(Console.ReadLine(), out saatler[i]));


Console.WriteLine("Ekrana yazdırmak ister misiniz (E/H): ");
string cevap = Console.ReadLine().ToLower();

if (cevap == "e")
{
    Console.WriteLine("Maas: ");
    for (int i = 0; i < kisisay; i++)
    {
        double maas = ucretler[i] * saatler[i];
        Console.WriteLine($"{isimler[i]}: {maas}");
    }
}
else
    Console.WriteLine("maas yazdırılamadı");
*/
#endregion

#region NBooyutlu Dizi
//int[] vizeler = { 30, 59, 65, 25, 87, 34 };
//int[] finaller = { 55, 42, 66, 88, 75, 24 };

//int[,] tumSinavlar = new int[6, 2] { { 30, 55 }, { 59, 42 }, { 65, 66 }, { 25, 88 }, { 87, 75 }, { 34, 24 } };

//Console.WriteLine(tumSinavlar[4,1]);

//for (int i = 0; i < tumSinavlar.GetLength(0); i++) // 0 olunca 6 kere döner.
//{
//    for (int j = 0; j < tumSinavlar.GetLength(1); j++) // 1 olunca 2 ye denk geliyor
//    {
//        Console.Write(tumSinavlar[i,j]);
//        Console.Write("\t"); //tab kadar bosluk
//    }
//    Console.WriteLine();

//}

#endregion

#region ornek1
//tek boyutlu bir int dizisi oluştur. dışardan gelecek adete göre veri alınacak ve sınav notları tutulacak. en son ekrana yazılacak. ortalaması da ekrana yazılsın.

/*
int adet = 0;

Console.WriteLine("kaç veri adedi olsun: ");
adet = int.Parse(Console.ReadLine());

int[] notlar = new int[adet];

int toplam = 0;

for (int i = 0; i < adet; i++)
{
    Console.WriteLine($"{i+1}. notu giriniz: ");
    notlar[i] = int.Parse(Console.ReadLine());
    toplam += notlar[i];  
}

Console.WriteLine("notlar: ");
foreach (var item in notlar)
{
    Console.WriteLine(item);
}

double ort = (double)toplam / adet;
Console.WriteLine("ortalama: " + ort);
*/
#endregion

#region ornek2
// rastgele üretilen 15 adet sayıyı bir dizide tutunuz. büyükten küçüğe doğru alt alta gösterin

/*
Random rand = new Random();

int[] num = new int[15];

for (int i = 0; i < num.Length; i++)
{
    num[i] = rand.Next(1, 101);
}

Array.Sort(num); //kücükten büyüge sıralar
Array.Reverse(num); // ters cevirir

foreach (var item in num)
{
    Console.WriteLine("num: " + item);
}
*/

#endregion



