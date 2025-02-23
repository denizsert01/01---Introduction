

//istisna tipleri

#region ornek1
Basla:
try
{

    Console.WriteLine("Telefon numarası: (XXX-XXX-XX-XX)");
    int gelenDeger = int.Parse(Console.ReadLine());
    Console.WriteLine("Tebrikler! Doğru telefon numarası girdiniz.");

}

//formatta hata olduğunda
catch (FormatException ex)
{
    Console.WriteLine("Format hatası oluştu" + ex.Message);

}

//inte sigmadiginde, cok büyük bir sayi girildiginde
catch (OverflowException ex)
{
    Console.WriteLine("Değer aşımı oluştu" + ex.Message);

}

// 0a bölme hatası
catch (DivideByZeroException ex)
{
    Console.WriteLine("Bölme hatası oluştu" + ex.Message);

}

//yukardakilerden herhangi birine düşmezse buna düşer.
catch (Exception ex)
{
    Console.WriteLine("Format hatası oluştu" + ex.Message);

}

goto Basla;




#endregion