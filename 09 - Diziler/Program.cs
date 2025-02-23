
// Birden fazla aynı tipte veriyi bir arada tutabilmeyi sağlayan nesnelerdir.

#region Tanımlama
string[] isimler;

isimler = new string[5];
isimler[0] = "Zafer";
isimler[1] = "Zehra";
isimler[2] = "Güliz";
isimler[3] = "Deniz";
isimler[4] = "Kartal";

Console.WriteLine();

string[] soyisimler = new string[5];
soyisimler[0] = "Dörter";
soyisimler[1] = "Tekin";
// 2 bos
soyisimler[3] = "Koca";
soyisimler[4] = "Silvester";

Console.WriteLine();

//int[] yaslar = new int[5] { 40, 25, 10, 7, 8 };
int[] yaslar = { 40, 25, 10, 7, 8 }; //initialize esnasında tanımlandıgından sayi belirtmek gereksiz.

char[] harfler = { 'A', 'Z', 'a', '7', '+' };
#endregion
// ctrl k s
#region DiziErişimleri

string[] arabalar = { "TOGG", "BMW", "Mercedes", "Ford", "Renault", "Honda" };

for (int i = 0; i < arabalar.Length; i++)
{
    Console.WriteLine(arabalar[i]);
}

Console.WriteLine(new string('*', 30)); //ayraç

foreach (var araba in arabalar)
{
    /*
    if (araba == "TOGG")
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
        Console.ForegroundColor = ConsoleColor.White;
    */

    Console.ForegroundColor = araba == "TOGG" ? ConsoleColor.Red : ConsoleColor.White;

    Console.WriteLine(araba);
}

Console.WriteLine(new string('*', 30)); //ayraç

object[] nesneler = { "Gel ne olursan ol, gel!", 34343, -5645, true, DateTime.Now, 'A',
123.99, 12.55m, 44.88f, new DateTime(2022, 5, 4)};

foreach (object o in nesneler)
{
    Console.WriteLine(o);
}

#endregion

#region ornek1
/*
int sayac = 0;
int[] sayi = new int[8];

while (sayac < 8)
{
    Console.Write($"{sayac + 1}. degeri giriniz: ");
    sayi[sayac] = int.Parse(Console.ReadLine());
    sayac++;
}

foreach (var item in sayi)
{
    Console.ForegroundColor
        = (item % 2 == 0) ? ConsoleColor.Red : ConsoleColor.White;
    Console.WriteLine(item);
}
*/
//2. yol
/*
int[] sayilar = new int[8];
Random rnd = new Random();

for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[i] = rnd.Next(1, 101); // [1,101)
}
foreach (var item in sayilar)
{
    Console.ForegroundColor
        = (item % 2 == 0) ? ConsoleColor.Red : ConsoleColor.White;
    Console.WriteLine(item);
}
*/

#endregion
