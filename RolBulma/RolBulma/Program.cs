
List<string> calisanlar = new List<string>
{
    "Orhan Ekici",
    "Ahmet Durmaz",
    "Burak gün",
    "Nimet Dikkat",
    "Ayşe  Dur"
};

List<bool> Roller = new List<bool>
{
    true,
    false,
    false,
    false,
    false,

};

while (true)
{
    Console.WriteLine("kullanıcı adı giriniz ?");
    string userInput = Console.ReadLine();
    
    int gelen =calisanlar.IndexOf(userInput);

    if (gelen != -1)
    {
        string rol = Roller[gelen] ? "admin" : "kullanici";
        Console.WriteLine($"hosgeldin : {calisanlar[gelen]}, kullanici rol :{rol}");
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("kulanıcı yok");
    }
}



