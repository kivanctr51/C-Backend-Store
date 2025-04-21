
Console.WriteLine("merhaba kaç tane sayı toplamamak istiyorsun");
int UserLogin = int.Parse(Console.ReadLine());


int total = 0;
int count = 0;


for (int i = 1; i <= UserLogin; i++)
{
    Console.Write($"{i}. sayıyı girin: ");
    count = int.Parse(Console.ReadLine());
    total += count;
    
}

Console.WriteLine($"toplama işlemi sonucu :  {total}");