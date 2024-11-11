﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz: ");
        int limit = Convert.ToInt32(Console.ReadLine());

        // İlk iki Fibonacci sayısı
        int a = 0, b = 1;

        // İlk sayıyı yazdır
        Console.Write(a);

        // Limit değerine kadar Fibonacci sayılarını yazdır
        while (b <= limit)
        {
            Console.Write(", " + b);
            
            // Bir sonraki Fibonacci sayısını hesapla
            int temp = a + b;
            a = b;
            b = temp;
        }

        Console.WriteLine();
    }
}