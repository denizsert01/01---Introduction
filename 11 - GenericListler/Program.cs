#region ornek1
// List <T< içerisinde (T) verilen tipe bürünerek o tipte bir koleksiyon oluşturmamıza olanak sağlayan dizi çeşitidir. Daha önceki ilkel diziler (arrayler) gibi ekleme sınırı olmadan eleman ekleyebildiğimiz yapılardır.

/*
List<int> sayilar = new List<int>();

sayilar.Add(154);
sayilar.Add(21);

Console.WriteLine(sayilar[0]);
Console.WriteLine(sayilar[1]);

Console.WriteLine(sayilar);

sayilar.ForEach(sayi => Console.WriteLine(sayi));

List<string> meyveler = new List<string>() { "Elma", "Armut", "Ayva", "Kivi", "Portakal", "Mandalina" };

meyveler.ForEach(m => Console.WriteLine(m));

foreach (var meyve in meyveler)
{
    Console.WriteLine(meyve);
}
*/
#endregion

#region ornek2
/*
List<string> sehirler = new List<string>();

sehirler.Add("Istanbul");
sehirler.Add("Ankara");
sehirler.Add("Izmir");
sehirler.Add("Eskisehir");

if (sehirler.Contains("Eskisehir"))
{
    Console.WriteLine("var");
}
else Console.WriteLine("yok");


// ternary if ile
//Console.WriteLine(sehirler.Contains("Eskisehir") ? "var":"yok");


//bastirmak icin 1. yol
foreach (var sehir in sehirler)
{
    Console.WriteLine(sehir);
}


//bastirmak icin 2. yol
for (int i = 0; i < sehirler.Count; i++)
{
    Console.WriteLine(sehirler[i]);
}

//bastirmak icin 3. yol
sehirler.ForEach(s => Console.WriteLine(s));

*/
#endregion
