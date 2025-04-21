using System.Runtime.InteropServices;
using veriler;

Console.WriteLine("merhabalar kaç ürün girmek istiyorsunuz ?");
int urunSayisi = int.Parse(Console.ReadLine());


var urunler = new List<Urun>();


for (int i = 0; i < urunSayisi; i++)
{
    Console.WriteLine("ad giriniz");
    var inputAd = Console.ReadLine();
    Console.Write("Ürün fiyatı: ");
    var inputFiyat = int.Parse(Console.ReadLine());
    Console.Write("Ürün stok sayısı: ");
    var inputStok = int.Parse(Console.ReadLine());
    
    urunler.Add(new Urun
    {
        Ad = inputAd,
        Fiyat = inputFiyat,
        Stok = inputStok,
    });
    Console.WriteLine("\nÜrün eklendi");
}

int genelToplam = 0;

foreach (var urun in urunler)
{
    int urunToplam = urun.Fiyat ;
    genelToplam += urunToplam;
}

Console.WriteLine($"\nGenel Fiyat Toplamı: {genelToplam} TL");
