Console.Write("Birinci sayıyı giriniz: ");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz: ");
double sayi2 = Convert.ToDouble(Console.ReadLine());

Console.Write("İşlem seçiniz (+, -, *, /): ");
char islem = Convert.ToChar(Console.ReadLine());

double sonuc = 0;

if (islem == '+')
{
    sonuc = sayi1 + sayi2;
}
else if (islem == '-')
{
    sonuc = sayi1 - sayi2;
}
else if (islem == '*')
{
    sonuc = sayi1 * sayi2;
}
else if (islem == '/')
{
    if (sayi2 != 0)
        sonuc = sayi1 / sayi2;
    else
    {
        Console.WriteLine("sıfıra bölme hatası!");
        return;
    }
}
else
{
    Console.WriteLine("geçersiz işlem!");
    return;
}

Console.WriteLine("Sonuç: {0}", sonuc);https://web.bookipi.com/auth/login