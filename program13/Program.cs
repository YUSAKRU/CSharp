int rows = 5; // Üçgen için satır sayısı

for (int i = 1; i <= rows; i++)
{
    // Boşlukları yazdır
    for (int space = 1; space <= rows - i; space++)
    {
        Console.Write(" ");
    }

    // Yıldızları yazdır
    for (int j = 1; j <= 2 * i - 1; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine(); // Bir sonraki satıra geç
}
