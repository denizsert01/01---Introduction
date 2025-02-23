#region ornek1

int[] numbers = { 123, 123343, 1231, 11, 212, 123, 122, 22 };
int[] hedef = { 99, 98, 233, 434, 2423 };
int elemanSayisi = hedef.Length;

Array.Copy(numbers, hedef, elemanSayisi);

foreach (var item in hedef)
{
    Console.WriteLine(item);
}

Console.WriteLine(); // ayraç

Array.Sort(numbers);

foreach (var item in numbers)
{
    Console.WriteLine(item);
}

Console.WriteLine(); // ayraç

Array.Reverse(numbers);

foreach (var item in numbers)
{
    Console.WriteLine(item);
}

int lastIndex = Array.LastIndexOf(numbers, 11);
Console.WriteLine("lastIndex " + lastIndex);

//Resize önemli
Array.Resize(ref numbers, numbers.Length + 2);
numbers[numbers.Length - 1] = 777;// en sona koy
foreach (var item in numbers)
{
    Console.WriteLine(item);
}
#endregion

#region ornek2
//kullanıcı öğrenci adı, doğum tarihi, final notu girecek. kaç öğrenci gireceği başlangıçta belli değil. ilgili veri tiplerine göre bu 3 veriyi her öğrenci için tutacağınız ve en son ekrana yazacağınız uygulamayı yazınız.

string isim, dogumTarihi, secim;
int final, ögSay;

List<string> isimler = new List<string>();
List<string> dogumTarihleri = new List<string>(); 
List<int> finaller = new List<int>();

do
{
    Console.WriteLine("İsmi: ");
    isim = Console.ReadLine();

    Console.WriteLine("Dogum tarihi: ");
    dogumTarihi = Console.ReadLine();

    Console.WriteLine("Final notu: ");
    final = int.Parse(Console.ReadLine());

    isimler.Add(isim);
    dogumTarihleri.Add(dogumTarihi);
    finaller.Add(final);

    Console.WriteLine("Daha ögrenci eklemek istiyor musunuz: (E/H) ");
    secim = Console.ReadLine().ToLower();
}
while (secim == "e");

Console.WriteLine("ögrenciler: ");
for (int i = 0; i < isimler.Count; i++)
{
    Console.WriteLine($"isim: {isimler[i]}, dogum tarihi: {dogumTarihleri[i]}, final: {finaller[i]}");
}

#endregion
