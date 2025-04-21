Console.WriteLine(" Hoşgeldiniz, Lütfen isminizi giriniz: ");
string Name = Console.ReadLine();
Console.WriteLine("Lütfen Soyadınızı giriniz: ");
string SurName = Console.ReadLine();
string NameSurname = Name + " " + SurName;
Console.WriteLine("Hoşgeldiniz, " + NameSurname);
Thread.Sleep(1000);

Console.WriteLine("La Casa de Papel Quiz'ine Hoşgeldiniz");
Thread.Sleep(3000);

Console.WriteLine("Quiz'e başlayalım mı? ");
Console.WriteLine("(E) Evet / (H) Hayır");
string userData = Console.ReadLine();

if (userData == "E" || userData == "e")
{
    Console.WriteLine("Harika, başlıyoruz hemen!");
    Thread.Sleep(3000);
    Console.Clear();

    Console.WriteLine("1. Soru: Diziyi bitirdiniz mi?");
    string FinishSeries = Console.ReadLine();

    Console.WriteLine("2. Soru: 1 ile 10 arası puanlama üzerinden kaç verirsiniz?");
    string PointSeries = Console.ReadLine();
    int PointSeriesValue = int.Parse(PointSeries);

    if (PointSeriesValue >= 5)
    {
        Console.WriteLine("Diziyi beğenmiş olmalısın.");
        Thread.Sleep(3000);
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Diziyi beğenmemiş olmalısın.");
        Thread.Sleep(3000);
        Console.Clear();
    }

    Console.WriteLine("3. Soru: Dizide en beğendiğiniz karakter kimdi?");
    string Person = Console.ReadLine();

    Console.WriteLine("4. Soru: Diziyi dublaj mı yoksa altyazılı mı izlemeyi tercih edersin?");
    Console.WriteLine("(A) Dublaj / (B) Altyazılı");
    string Subtitle = Console.ReadLine();

    if (Subtitle == "A" || Subtitle == "a")
    {
        Console.WriteLine("Dublaj izlemek en iyisi bence de.");
        Thread.Sleep(3000);
        Console.Clear();
    }
    else if (Subtitle == "B" || Subtitle == "b")
    {
        Console.WriteLine("Altyazı izlemek en iyisi bence de.");
        Thread.Sleep(3000);
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Yanlış giriş yaptınız!!!");
    }

    Console.WriteLine("5. Soru: Sizce en iyi sezon hangisiydi?");
    string BestSeason = Console.ReadLine();
    int BestSeasonValue = int.Parse(BestSeason);

    if (BestSeasonValue == 1)
    {
        Console.WriteLine("1. Sezon gerçekten iyiydi.");
    }
    else if (BestSeasonValue == 2)
    {
        Console.WriteLine("2. Sezon gerçekten iyiydi.");
    }
    else if (BestSeasonValue == 3)
    {
        Console.WriteLine("3. Sezon gerçekten iyiydi.");
    }
    else if (BestSeasonValue == 4)
    {
        Console.WriteLine("4. Sezon gerçekten iyiydi.");
    }
    else if (BestSeasonValue == 5)
    {
        Console.WriteLine("5. Sezon gerçekten iyiydi.");
    }
    else
    {
        Console.WriteLine("Bu dizi 5 sezon, emin misin? :)");
    }

    Console.WriteLine("6. Soru: La Casa de Papel hangi ülkede geçiyor?");
    Console.WriteLine("(A) Amerika (B) Almanya (C) İspanya (D) Avustralya");
    string country = Console.ReadLine();

    if (country == "A" || country == "a")
    {
        Console.WriteLine("A şıkkı yanlış cevap :(");
        Thread.Sleep(3000);
    }
    else if (country == "B" || country == "b")
    {
        Console.WriteLine("B şıkkı yanlış cevap :(");
        Thread.Sleep(3000);
    }
    else if (country == "C" || country == "c")
    {
        Console.WriteLine("Evet, doğru cevap! İyi bir izleyicisin :)");
        Thread.Sleep(3000);
        Console.Clear();
    }
    else if (country == "D" || country == "d")
    {
        Console.WriteLine("D şıkkı yanlış cevap :(");
        Thread.Sleep(3000);
    }
    else
    {
        Console.WriteLine("Yanlış giriş yaptınız!!!");
    }

    Console.WriteLine("Verdiğiniz cevapları görmek ister misiniz?");
    Console.WriteLine("(E) Evet / (H) Hayır");
    string Answers = Console.ReadLine();

    if (Answers == "E" || Answers == "e")
    {
        Console.Clear();
        Console.WriteLine("Cevaplarınız hazır! Aşağıdaki gibidir:");

        Console.WriteLine("• İsim Soyisim: " + NameSurname);
        Console.WriteLine("• 1. Soru: Diziyi bitirdiniz mi? " + FinishSeries);
        Console.WriteLine("• 2. Soru: Kaç puan verdiniz? " + PointSeries);
        Console.WriteLine("• 3. Soru: En beğendiğiniz karakter: " + Person);
        Console.WriteLine("4. Soru: Diziyi dublaj mı yoksa altyazılı mı izlemeyi tercih edersin?");
        Console.WriteLine("• 4. Soru: Tercihiniz: " + Subtitle);
        Console.WriteLine("• 5. Soru: En iyi sezon: " + BestSeason);
        Console.WriteLine("(A) Amerika (B) Almanya (C) İspanya (D) Avustralya");
        Console.WriteLine("• 6. Soru: Ülke tercihi: " + country);

        Console.WriteLine("Teşekkürler, quiz tamamlandı! ");
    }
    else if (Answers == "H" || Answers == "h")
    {
        Console.WriteLine("Tamamdır, iyi günler!");
    }
    else
    {
        Console.WriteLine("Yanlış giriş yaptınız!!!");
    }
}
else if (userData == "H" || userData == "h")
{
    Console.WriteLine("Daha sonra görüşürüz.");
    Thread.Sleep(1000);
}
else
{
    Console.WriteLine("Eksik veya yanlış karakter girişi!!!");
}
