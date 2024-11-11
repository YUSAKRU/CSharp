using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz: ");
        string input = Console.ReadLine();

        try
        {
            int number = Convert.ToInt32(input);
            int square = number * number;
            Console.WriteLine($"Girdiğiniz sayının karesi: {square}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Hata: Geçerli bir sayı girmediniz!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Hata: Girdiğiniz sayı çok büyük veya çok küçük!");
        }
    }
}