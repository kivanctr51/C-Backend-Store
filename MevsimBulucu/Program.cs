
Console.WriteLine("Mevsim Bulucuya hoşgeldiniz");
Console.WriteLine("hangi aydayız");
string Ay = Console.ReadLine();
int AyValue = int.Parse(Ay);

if (AyValue == 1 || AyValue == 2 || AyValue == 3)
{
    Console.WriteLine("İlkbahar Ayındasınız ");
}
else if (AyValue == 4 || AyValue == 5 || AyValue == 6)
{
    Console.WriteLine("Yaz Ayındasınız ");
}
else if (AyValue == 7 || AyValue == 8 || AyValue == 9)
{
    Console.WriteLine("Son Bahar Ayındasınız ");
}
else if (AyValue == 10 || AyValue == 11 || AyValue == 12)
{
    Console.WriteLine("Kış Ayındasınız ");
    
}
else
{
    Console.WriteLine("boyle bir mevsim bulunamadı Tekrar deneyin");
}