int rows = 5; // Number of rows for the triangle

for (int i = 1; i <= rows; i++)
{
    // Print spaces
    for (int space = 1; space <= rows - i; space++)
    {
        Console.Write(" ");
    }

    // Print stars
    for (int j = 1; j <= 2 * i - 1; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine(); // Move to next line
}
