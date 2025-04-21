
        List<int> sayilar = new List<int> {
            42, 7, 89, 16, 33, 58, 91, 24, 76, 11,
            63, 5, 38, 70, 19, 84, 29, 97, 2, 51
        };

  
        Console.Write("Bir sayı girin: ");
        int kullaniciSayisi = int.Parse(Console.ReadLine());


        List<int> buyukSayilar = sayilar.Where(sayi => sayi > kullaniciSayisi).ToList();
        List<int> kucukSayilar = sayilar.Where(sayi => sayi < kullaniciSayisi).ToList();


        Console.WriteLine($"{kullaniciSayisi} sayısından büyük olan sayılar:");
        
        
        for (int i = 0; i < buyukSayilar.Count; i++)
        {
            Console.WriteLine(buyukSayilar[i]);
        }
        
        
        Console.WriteLine($"{buyukSayilar.Count} adet sayının büyük olduğu bulundu.");

        Console.WriteLine($"{kullaniciSayisi} sayısından küçük olan sayılar:");
        
        
        for (int i = 0; i < kucukSayilar.Count; i++)
        {
            Console.WriteLine(kucukSayilar[i]);
        }
        
        
        Console.WriteLine($"{kucukSayilar.Count} adet sayının küçük olduğu bulundu.");
