Console.WriteLine("Basit bir C# hesap makinesi");

Console.WriteLine("işlem seçiniz [+ - * /]  çıkış yapmak için boş bırakınız");

int sayi1, sayi2;
string mathOp;

Basla:
try
{


    Console.WriteLine("sayi 1: ");
    sayi1 = int.Parse(Console.ReadLine());


    Console.WriteLine("sayi 2: ");
    sayi2 = int.Parse(Console.ReadLine());

    Console.WriteLine("İşlem: ");
    mathOp = Console.ReadLine();

}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    goto Basla;

}

if (mathOp != string.Empty)
{
    switch (mathOp)
    {
        case "+": Console.WriteLine($"Toplam: {sayi1 + sayi2}"); break;
        case "-": Console.WriteLine($"Toplam: {sayi1 - sayi2}"); break;
        case "*":
        case "/":
            try
            {
                Console.WriteLine($"Toplam: {sayi1 * sayi2}"); break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Basla;


            }

            Console.WriteLine($"Toplam: {sayi1 / sayi2}"); break;
        default:
            throw new Exception("yanlış bir işlem seçtiniz");
            break;

    }
}
else Console.WriteLine("işlem boş geldiğinden hesaplama yapılamadı.");

Console.WriteLine("Devam? E/H");
string result = Console.ReadLine();

if (result == "E" || result == "e") goto Basla;



