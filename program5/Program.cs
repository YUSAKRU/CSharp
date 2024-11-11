Console.WriteLine("Lütfen bir gün ismi giriniz (örn: Pazartesi): ");
string gun = Console.ReadLine().ToLower(); // Girilen günü küçük harfe çeviriyoruz

switch (gun)
{
    case "pazartesi":
    case "salı":
    case "çarşamba":
    case "perşembe":
    case "cuma":
        Console.WriteLine("Bu gün hafta içidir.");
        break;
    case "cumartesi":
    case "pazar":
        Console.WriteLine("Bu gün hafta sonudur.");
        break;
    default:
        Console.WriteLine("Geçersiz gün ismi girdiniz!");
        break;
}
