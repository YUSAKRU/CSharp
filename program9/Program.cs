using System;

class Program
{
    static void Main(string[] args)
    {
        int toplam = 0;

        for (int i = 1; i <= 10; i++)
        {
            toplam += i;
        }

        Console.WriteLine("1'den 10'a kadar olan sayıların toplamı: " + toplam);
    }
}