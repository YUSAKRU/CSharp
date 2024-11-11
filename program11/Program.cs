using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi >= 10 && sayi <= 50)
        {
            Console.WriteLine("Girdiğiniz sayı 10 ve 50 arasındadır.");
            
            if (sayi == 10)
            {
                Console.WriteLine("Girdiğiniz sayı 10'a eşittir.");
            }
            else if (sayi == 50)
            {
                Console.WriteLine("Girdiğiniz sayı 50'ye eşittir.");
            }
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayı 10 ve 50 arasında değildir.");
        }
    }
}