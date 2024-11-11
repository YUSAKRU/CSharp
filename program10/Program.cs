Console.Write("Lütfen bir sayı giriniz: ");

// Try-catch bloğu ile sayısal değer kontrolü yapıyoruz
try
{
    int sayi = Convert.ToInt32(Console.ReadLine());

    // Sayının 2'ye bölümünden kalan 0 ise çift, değilse tek sayıdır
    if (sayi % 2 == 0)
    {
        Console.WriteLine($"{sayi} bir çift sayıdır.");
    }
    else
    {
        Console.WriteLine($"{sayi} bir tek sayıdır.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Hata: Lütfen geçerli bir sayı giriniz!");
}

Console.WriteLine("Program sonlandı. Çıkmak için bir tuşa basınız.");
Console.ReadKey();
