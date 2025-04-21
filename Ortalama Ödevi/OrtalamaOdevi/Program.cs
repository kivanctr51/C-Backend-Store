Console.WriteLine("Ortalama hesaplayıcı'ya hoşgeldiniz");
Console.WriteLine("vize notunuzu giriniz");
string vizeNot =  Console.ReadLine();
int vizeNotValue = int.Parse(vizeNot);

Console.WriteLine("final notunuzu giriniz");
string finalNot =  Console.ReadLine();
int finalNotValue = int.Parse(finalNot);
int toplam = (finalNotValue + vizeNotValue)/2;


Console.WriteLine("ortalamanız : " + toplam);
if (toplam >= 50)
{
    Console.WriteLine("sınavlardan başarılı oldunuz, Tebrikler");
}
else
{
    Console.WriteLine("sınavlardan başarısız oldunuz, çalışmaya devam");
}




