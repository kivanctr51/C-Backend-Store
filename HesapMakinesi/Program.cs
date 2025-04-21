

Console.WriteLine("Hesap makinesine Hoşgeldiniz");
Thread.Sleep(2000);
Console.WriteLine("1.sayıyı giriniz");
string ilkSayi = Console.ReadLine();
int ilkSayiValue = int.Parse(ilkSayi); 


Console.WriteLine("2.sayıyı giriniz");
string ikinciSayi = Console.ReadLine();
int ikinciSayiValue = int.Parse(ikinciSayi);

Console.WriteLine("hangi işlemi yapmak istiyorsunuz ?");
Console.WriteLine(" +  -  /  *  ");
string isaret = Console.ReadLine();

if (isaret == "+")
{
    Console.WriteLine(ilkSayiValue+ikinciSayiValue);
}
else if (isaret == "-")
{
    Console.WriteLine(ilkSayiValue-ikinciSayiValue);
}else if (isaret == "*")
{
    Console.WriteLine(ilkSayiValue*ikinciSayiValue);
}else if (isaret == "/")
{
    Console.WriteLine(ilkSayiValue/ikinciSayiValue);
}