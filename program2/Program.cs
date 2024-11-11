Console.WriteLine("Birinci sayıyı giriniz:");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz:");
double sayi2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Toplama: {0}", sayi1 + sayi2);
Console.WriteLine("Çıkarma: {0}", sayi1 - sayi2);
Console.WriteLine("Çarpma: {0}", sayi1 * sayi2);
Console.WriteLine(sayi2 != 0 ? "Bölme: {0}" : "Bölme: Sıfıra bölme hatası!", sayi1 / sayi2);