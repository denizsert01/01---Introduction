
#region 1
/*Rastgele [-50,50] arasında 20 sayı alınız. Bu sayıları bir dizi içerisinde tutunuz.
Ekrana yazdırırken sayıların negatif, pozitif ve işaretsiz olma durumlarını yanına yazdıran programı yazın
*/

/*
Random rand = new Random();
int[] num = new int[20];

for (int i = 0; i < num.Length; i++)
{
    num[i] = rand.Next(-50, 51);
}

foreach (var item in num)
{
    if (item < 0)
    {
        Console.WriteLine($"{item} negatif");
    }
    else if (item > 0)
    {
        Console.WriteLine($"{item} pozitif");
    }
    else
    {
        Console.WriteLine($"{item} işaretsiz");
    }

}
*/
#endregion

#region 2
// int 20 lik dizi tanımla.

// for döngüsü içinde rastgele [-50,50] sayı al.

// alınan sayıyı diziye ata.

// foreach ekran yazdırırken, sayının yanına negatif ise negatif yazsın.

/*
int[] dizi = new int[20];

Random random = new Random();
for (int i = 0; i < dizi.Length; i++)
{
    dizi[i] = random.Next(-50, 51);
}

foreach (var item in dizi)
{
    if(item < 0)
    {
        Console.WriteLine($"{item} negatif");
    }
    else Console.WriteLine(item);
}
*/
#endregion

#region 3
//Rastgele [-50,50] arasında 20 sayı alınız. negatifsayiları negatifler dizisinde, pozisitfleri pozitifler dizisinde tutunuz ve en son ekrana bastırınız.

/*
List<int> pozitif = new List<int>();
List<int> negatif = new List<int>();

Random random = new Random();
int[] num = new int[20];

for (int i = 0; i < num.Length; i++)
{
    num[i] = random.Next(-50, 51);
    if (num[i] > 0) pozitif.Add(num[i]);
    else if (num[i] < 0) negatif.Add(num[i]);
    else i--; //0 ise
}
Console.WriteLine($"pozitifler dizisi: ");
foreach (var item in pozitif)
{
    Console.WriteLine(item);
}

Console.WriteLine($"negatifler dizisi: ");
foreach (var item in negatif)
{
    Console.WriteLine(item);
}
*/
#endregion

#region 4
//Kullanıcı tarafından doldurulan 10 boyutlu bir dizideki en büyük ve en küçük değeri dizi fonksiyonlarını kullanmadan bulun ve ekrana yazdırın

/*
int[] degerler = new int[10];

for (int i = 0; i < degerler.Length; i++)
{
    Console.WriteLine($"{i + 1}. degeri giriniz");
    degerler[i] = int.Parse(Console.ReadLine());
}

int enBuyuk = degerler[0];
int enKucuk = degerler[0];

for (int i = 0; i < degerler.Length; i++)
{
    if (degerler[i] > enBuyuk)
        enBuyuk = degerler[i];
    if (degerler[i] < enKucuk)
        enKucuk = degerler[i];
}

Console.WriteLine($"En büyük: {enBuyuk}");
Console.WriteLine($"En kücük: {enKucuk}");
*/

#endregion

#region 5
//Klavyeden girilen bir dizi içerisindeki sayıların ortalamasını bulduktan sonra, bu ortalamanın altında kalan elemanları yeni bir diziye atayın ve ekrana yazdırın.

/*
int sum = 0;
string cevap;
//int toplam = 0;
double ortalama = 0;
List<int> nums = new List<int>();
do
{
    Console.WriteLine("Sayi giriniz: ");
    int num = int.Parse(Console.ReadLine());
    nums.Add(num);
    //toplam += num;

    Console.WriteLine("Devam etmek istiyor musunuz? E/H");
    cevap = Console.ReadLine().ToLower();

}
while (cevap == "e");

//ortalama = (double)toplam / nums.Count();
ortalama = nums.Average();

List<int> altta = new List<int>();
foreach (var item in nums)
{
    if (item < ortalama)
        altta.Add(item);
}

Console.WriteLine($"ortalama: {ortalama}");
Console.WriteLine($"ortalamanın altında kalanlar:");
foreach (var item in altta)
{
    Console.WriteLine(item);
    
}

*/
#endregion

#region 6
//Klavyeden girilen bir dizi sayısını Bubble Sort algoritması ile sıralayın ve sıralı diziyi ekrana yazdırın.

/*
List<int> dizi = new List<int>();
string cevap;

do
{
    Console.WriteLine("Bir sayı ekleyin: ");
    int sayi = int.Parse(Console.ReadLine());
    dizi.Add(sayi);

    Console.WriteLine("Devam etmek istiyor musunuz (E/H)");
    cevap = Console.ReadLine().ToLower();

} while (cevap == "e");

dizi.Sort();
Console.WriteLine("Dizi elemanları: ");

foreach (var item in dizi)
{
    Console.WriteLine(item);
}
*/
#endregion

#region 7
//2x2 boyutunda iki matris tanımlayın ve bu matrislerin çarpımını hesaplayarak sonucu ekrana yazdırın.

/*
int[,] matris1 = { { 1, 2 }, { 3, 4 } };
int[,] matris2 = { { 11, 22 }, { 33, 34 } };

int[,] sonuc = new int[2, 2];

for (int i = 0; i < 2; i++) // satırı gezer
{
    for (int j = 0; j < 2; j++) // sütunu gezer
    {
        sonuc[i, j] = 0;
        for (int k = 0; k < 2; k++) // çarpmayı yapar
        {
            sonuc[i, j] += matris1[i, k] * matris2[k, j];
        }
    }
}

Console.WriteLine("Çarpım sonucu: ");

for (int i = 0; i < 2; i++) 
{
    for (int j = 0; j < 2; j++)
    {
        Console.WriteLine(sonuc[i,j] + "   ");
    }
    Console.WriteLine();

}

*/
#endregion

#region 8
//Klavyeden girilen bir dizi (örneğin bir kelime veya sayı) palindrom mu (tersiyle aynı mı) olduğunu kontrol eden bir program yazın.

/*
Console.WriteLine("Kontrol edilecek kelime: ");
string kelime = Console.ReadLine();

List<char> harfler = kelime.ToList();

List<char> ters = new List<char>(harfler);
ters.Reverse();

if (harfler.SequenceEqual(ters))
    Console.WriteLine($"{kelime} palindromdur.");
else Console.WriteLine($"{kelime} palindrom değildir.");
*/

#endregion

#region 9
//Klavyeden girilen 10 adet sayıdan 100'den büyük olanları bir diziye atan programı yazın

/*
int sayi = 0;
int sayiAdedi = 0;
List<int> buyuk = new List<int>();
do
{
    Console.WriteLine($" {sayiAdedi+1}. sayiyi giriniz: ");
    sayi = int.Parse(Console.ReadLine());

    if (sayi > 100)
    {
        buyuk.Add(sayi);
    }
    sayiAdedi++;
} while (sayiAdedi < 10);

Console.WriteLine("100'den büyük olanlar: ");
foreach (var item in buyuk)
{
    Console.WriteLine(item);
}
*/
#endregion

#region sayisalLoto
int kolonSayisi;

Console.Write("Kaç kolon oynayacaksınız (1-8): ");

while (!int.TryParse(Console.ReadLine(), out kolonSayisi) || kolonSayisi < 1 || kolonSayisi > 8)
{
    Console.WriteLine("1 ve 8 arasında bir değer girmediniz");
}

//if(kolonSayisi<1 || kolonSayisi>8)
//    Console.WriteLine("1 ve 8 arasında bir değer girmediniz");

Random rnd = new Random();

List<int[]> kolonlarMatrisi = new List<int[]>();

for (int i = 0; i < kolonSayisi; i++)
{
    List<int> kolon = new List<int>();
    while (kolon.Count < 7)
    {
        int yeniEkle = rnd.Next(1, 50);

        if (!kolon.Contains(yeniEkle))
            kolon.Add(yeniEkle);
    }
    kolonlarMatrisi.Add(kolon.ToArray());
}

Console.WriteLine("Lotonuz: ");
for (int i = 0; i < kolonlarMatrisi.Count; i++)
{
    Console.WriteLine($"{i + 1}. kolonunuzda: {string.Join(", ", kolonlarMatrisi[i])}");
}

#endregion