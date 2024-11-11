Console.Write("Lütfen bir sayı giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());

// İlk iki Fibonacci sayısı
int a = 0, b = 1;

// İlk sayıyı yazdır
Console.Write(a);

// Limit değerine kadar Fibonacci sayılarını yazdır
while (b <= limit) // while ifadesi limit değerine kadar çalışmasına olanak sağlar. Limit değerine kadar çalışır.
{
    Console.Write(", " + b);

    // Bir sonraki Fibonacci sayısını hesapla
    int temp = a + b; // a = 0, b = 1, temp = 1 olur
    a = b;
    b = temp;
}

Console.WriteLine(); // Bir sonraki satıra geçmesi için yazıldı, program sonunda satır sonundan komut vermemizi istemesin!
