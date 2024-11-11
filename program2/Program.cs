Console.WriteLine("Merhaba Dünya!");
Console.WriteLine("Birinci sayıyı giriniz:");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz:");
double sayi2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Toplama: {sayi1 + sayi2}");
Console.WriteLine($"Çıkarma: {sayi1 - sayi2}");
Console.WriteLine($"Çarpma: {sayi1 * sayi2}");
Console.WriteLine(sayi2 != 0 ? $"Bölme: {sayi1 / sayi2}" : "Bölme: Sıfıra bölme hatası!");