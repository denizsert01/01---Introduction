

DateTime tarih = DateTime.Now;
Console.WriteLine(tarih.Date); // tarih ama saat 00
Console.WriteLine(tarih.ToLongDateString()); //ekstra gün geliyor
Console.WriteLine(tarih.ToShortDateString()); //günsüz
Console.WriteLine(tarih.ToLongTimeString()); //sadece saat, dk, salisesi
Console.WriteLine(tarih.ToShortTimeString()); //sadece saat, dk
Console.WriteLine(tarih.ToUniversalTime()); //tarih ve saat full

int gun = 7;
int ay = 5;
int yil = 200;
DateTime dogumTarihi = new DateTime(yil, ay, gun); //constructor ile yeni bir nesne oluşturduk.
Console.WriteLine(dogumTarihi.ToLongDateString());

//devamı 21 Şubat notlarda