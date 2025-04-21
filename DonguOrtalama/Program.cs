
Console.WriteLine("Hoşgeldiniz: toplam 5 sayi girilicek");
Thread.Sleep(3000);
Console.Clear();


Console.Write("1. Sayıyı giriniz: ");
int Sayi1 =int.Parse(Console.ReadLine());
Console.Write("2. Sayıyı giriniz: ");
int Sayi2 =int.Parse(Console.ReadLine());
Console.Write("3. Sayıyı giriniz: ");
int Sayi3 =int.Parse(Console.ReadLine());
Console.Write("4. Sayıyı giriniz: ");
int Sayi4 =int.Parse(Console.ReadLine());
Console.Write("5. Sayıyı giriniz: ");
int Sayi5 =int.Parse(Console.ReadLine());

List<int> Data = new List<int>{Sayi1,Sayi2,Sayi3,Sayi4,Sayi5};

int toplam = 0;

for (int i = 0; i < Data.Count; i++)
{
    toplam += Data[i];
}

double ortalama = (double)toplam / Data.Count;

Console.WriteLine("ortalamanız : " + ortalama);