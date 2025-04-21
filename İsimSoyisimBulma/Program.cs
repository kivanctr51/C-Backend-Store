List<string> ogrenciler = [
    "Emre Aydın",
    "Zeynep Güneş",
    "Melis Karaca",
    "Caner Arslan",
    "Ahmet Yılmaz",
    "Ayşe Demir",
    "Fatma Koç",
    "Burak Yıldız",
    "Mehmet Kaya",
    "Selin Özkan",
    "Elif Şahin",
    "Fatma Koç",
    "Emre Aydın",
    "Ahmet Yılmaz",
    "Burak Yıldız",
    "İrem Korkmaz",
    "Ayşe Demir",
    "Burak Yıldız",
    "Elif Şahin",
    "Mert Taş",
    "Selin Özkan",
    "Caner Arslan",
    "Zeynep Güneş",
    "Burak Yıldız",
    "Ahmet Yılmaz",
    "Selin Özkan",
    "Ahmet Yılmaz",
    "Oğuzhan Çelik",
    "Ayşe Demir",
    "Deniz Erdem",
    "Mehmet Kaya",
    "Elif Şahin",
    "Fatma Koç",
    "Emre Aydın",
    "Caner Arslan",
    "Elif Şahin",
    "Ahmet Yılmaz",
    "Emre Aydın",
    "Burak Yıldız",
    "Selin Özkan"
];
Console.Write("Hoşgeldiniz ");

Thread.Sleep(2000);

Console.Clear();
Console.WriteLine("Bir isim giriniz: ");

string girilenIsim = Console.ReadLine();

int sayac = 0;


for (int i = 0; i < ogrenciler.Count; i++)
{
    if (ogrenciler[i] == girilenIsim)
    {
        sayac++;
    }
}

Console.WriteLine("girilen isim Soyisim :  " + girilenIsim);
Console.WriteLine("girilen isim Soyisim :  " + sayac + " defa var");