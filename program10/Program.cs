Console.Write("Lütfen bir sayı giriniz: ");
string giris = Console.ReadLine();
int sayi;

if (int.TryParse(giris, out sayi))
{
    if (sayi % 2 == 0)
    {
        Console.WriteLine($"{sayi} bir çift sayıdır.");
    }
    else
    {
        Console.WriteLine($"{sayi} bir tek sayıdır.");
    }
}
else
{
    Console.WriteLine("Hata: Lütfen geçerli bir sayı giriniz!");
}

Console.WriteLine("Program sonlandı. Çıkmak için bir tuşa basınız.");
Console.ReadKey();


Console.Write("Lütfen bir sayı giriniz: ");





// Tek satırlık yorum için çift eğik çizgi (//) kullanılır
/* Çok satırlı yorumlar için 
    yıldız ve eğik çizgi kombinasyonu kullanılır
    Bu şekilde birden fazla satır yorumlanabilir */
// Try-catch bloğu ile sayısal değer kontrolü yapıyoruz

/*


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


*/

