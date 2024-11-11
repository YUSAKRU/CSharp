Console.Write("Birinci sayıyı giriniz: ");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz: ");
double sayi2 = Convert.ToDouble(Console.ReadLine());

Console.Write("İşlem seçiniz (+, -, *, /): ");
char islem = Convert.ToChar(Console.ReadLine());

double sonuc = 0;

switch (islem)
{
    case '+':
        sonuc = sayi1 + sayi2;
        break;
    case '-':
        sonuc = sayi1 - sayi2;
        break;
    case '*':
        sonuc = sayi1 * sayi2;
        break;
    case '/':
        if (sayi2 != 0)
            sonuc = sayi1 / sayi2;
        else
        {
            Console.WriteLine("Sıfıra bölme hatası!");
            return;
        }
        break;
    default:
        Console.WriteLine("Geçersiz işlem!");
        return;
}

Console.WriteLine($"Sonuç: {sonuc}");