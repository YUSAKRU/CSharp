using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Numbers from 1 to 10 (excluding 7):");
        
        for (int i = 1; i <= 10; i++)
        {
            if (i != 7)
            {
                Console.Write(i + " ");
            }
        }
        
        Console.WriteLine(); // Add a new line at the end
    }
}