using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        int i = 0;
        Console.WriteLine($"{sayi} sayısına kadar olan çift sayılar:");
        
        while (i <= sayi)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
            i++;
        }
        
        Console.WriteLine(); // Yeni satır için
    }
}