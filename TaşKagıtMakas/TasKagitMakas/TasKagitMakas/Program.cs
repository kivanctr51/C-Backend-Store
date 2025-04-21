
string[] hamleler = ["taş", "kağıt", "makas"];
Random rng = new Random();
var cpuHamle = hamleler[rng.Next(3)];


Console.WriteLine("Taş Kağıt Makas Oyununa Hoşgeldiniz");

Console.WriteLine("yapmak istediğniz işareti yaziniz");
string UserSelect = Console.ReadLine();

if (cpuHamle == UserSelect)
{
    Console.WriteLine($"Makine : {cpuHamle}");
    Console.WriteLine($"kullanici : {cpuHamle}");
    Console.WriteLine("berabere");
}
else if((cpuHamle == "taş" && UserSelect == "makas") || 
        (cpuHamle == "kağıt" && UserSelect == "taş") || 
        (cpuHamle == "makas" && UserSelect == "kağıt"))
{
    Console.WriteLine($"Makine : {cpuHamle}");
    Console.WriteLine($"kullanici : {UserSelect}");
    Console.WriteLine(" Makine kazandı");
}
else
{
    Console.WriteLine($"Makine : {cpuHamle}");
    Console.WriteLine($"kullanici : {UserSelect}");
    Console.WriteLine("kullanıcı kazandı");
}
