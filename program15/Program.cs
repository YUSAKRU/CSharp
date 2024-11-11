Console.WriteLine("Lütfen doğum tarihinizi giriniz (GG.AA.YYYY): ");
string dogumTarihiStr = Console.ReadLine();

if (DateTime.TryParse(dogumTarihiStr, out DateTime dogumTarihi)) // Doğru formatta tarih girilmiş mi kontrolü
{
    DateTime bugun = DateTime.Today;    // Bugünün tarihini al

    // Yaş hesaplama
    int yas = bugun.Year - dogumTarihi.Year;
    if (dogumTarihi.Date > bugun.AddYears(-yas)) // Eğer doğum günü bugünden sonra ise yaş bir azaltılmalı
    {
        yas--; // Yaşı bir azalt
    }

    // Yaşanılan gün sayısı hesaplama
    TimeSpan yasanilanGun = bugun - dogumTarihi;

    Console.WriteLine($"Yaşınız: {yas}");
    Console.WriteLine($"Hayatta olduğunuz gün sayısı: {yasanilanGun.Days}");
}
else
{
    Console.WriteLine("Geçersiz tarih formatı! Lütfen GG.AA.YYYY formatında giriniz.");
}
