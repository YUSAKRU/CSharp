Console.Write("Fibonacci serisi için terim sayısını giriniz: ");
int terimSayisi = Convert.ToInt32(Console.ReadLine());

int ilkSayi = 0, ikinciSayi = 1;

Console.Write($"Fibonacci Serisi ({terimSayisi} terim): ");

// İlk sayıyı yazdır
if (terimSayisi >= 1)
    Console.Write(ilkSayi);

// İkinci sayıyı yazdır
if (terimSayisi >= 2)
    Console.Write(", " + ikinciSayi);

// Kalan terimleri hesapla ve yazdır
for (int i = 3; i <= terimSayisi; i++)
{
    int sonrakiSayi = ilkSayi + ikinciSayi;
    Console.Write(", " + sonrakiSayi);

    ilkSayi = ikinciSayi;
    ikinciSayi = sonrakiSayi;
}

Console.WriteLine();
