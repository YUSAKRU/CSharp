using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen pozitif bir tam sayı giriniz: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number < 0)
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz!");
            return;
        }

        long factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"{number}! = {factorial}");
    }
}