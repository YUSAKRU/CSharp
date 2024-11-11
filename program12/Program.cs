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

Console.WriteLine("{0}! = {1:N0}", number, factorial); // :N0 ifadesi ile sayıyı binlik gruplara ayırarak yazdırıyoruz