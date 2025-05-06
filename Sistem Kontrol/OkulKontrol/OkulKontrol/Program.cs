using OkulKontrol;
using OkulKontrol.Models;
using System.IO;

// Main metodundaki çağrı:


List<Ogrenci> ogrenciler = new List<Ogrenci>();




Console.WriteLine("Merhablar Ögrenci Yonetim Sistemine hoşgeldiniz");
Console.WriteLine("----------------------------------------");
Console.WriteLine("1.Öğrenci Girişi");
Console.WriteLine("2.Öğretmen Girişi");
Console.WriteLine("3.Sınıf Yönetimi");
Console.WriteLine("4.Çıkış");


var GelenCevap = Console.ReadLine();




switch (GelenCevap)
{
    case "1":
        ogrenciYonetimi();
        Console.Clear();
        break;
    case "2":
        ogretmenYonetimi();
     break;
    case "3":

        classRoom();
        break;
    case "4":
        break;
    
    case "0": return;
    default: Console.WriteLine("Geçersiz seçim."); 
    break;
}





static void ogrenciYonetimi()
{ 
   
     string dosyaYolu = "Ogrenci.txt";
    while (true)
    {
 
        Console.WriteLine("ogretmen Yönetimi");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("1.listele");
        Console.WriteLine("2.ekle");
        Console.WriteLine("3.sil");
        Console.WriteLine("0.Geri Döm");
      
        
        var OgrenciSecim = Console.ReadLine();

        switch (OgrenciSecim)
        {
            
            case "1":
             
                if (File.Exists(dosyaYolu))
                {
                    string icerik = File.ReadAllText(dosyaYolu);
                    if (string.IsNullOrWhiteSpace(icerik))
                    {
                        Console.WriteLine("Dosya boş.");
                    }
                    else
                    {
                        Console.WriteLine("Öğrenci Listesi:");
                        Console.WriteLine(icerik);
                    }
                }
                else
                {
                    Console.WriteLine("Dosya bulunamadı.");
                 
                }
                Console.WriteLine("Devam etmek için bir tuşa basın...");
                Console.ReadKey();
          
                break;
            case "2":
                Console.Clear();
                Console.WriteLine("kayıt edilecek ogrenci nedir?");
                var KayitOgrenci = Console.ReadLine();

                string eklenecekMetin = KayitOgrenci + Environment.NewLine;
                File.AppendAllText(dosyaYolu, eklenecekMetin);
                Console.WriteLine("kayıt tamamlandı");
                
                Console.WriteLine("devam etmek için bir tuşa basın");
                Console.Clear();
                Console.ReadKey();
               
                break;
            case "3":
                Console.Clear();
                Console.WriteLine("hepsi silinecek emin misin");
              var DeleteDosya =  Console.ReadLine();
                if (DeleteDosya == "e" || DeleteDosya == "E")
                {
                    File.Delete(dosyaYolu);
                    Console.WriteLine("silme işlemi Başarılı");
                    Console.WriteLine("devam etmek için bir tuşa basın");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("işlem iptal edildi");
                }
                
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Geçersiz seçim. Lütfen geçerli bir seçenek girin.");
                Console.Clear();
                break;
        }
        
    }
}


static void classRoom()

{
    var  dosyaYoluClassRoom = "classRoom.txt";
    Console.WriteLine("Sınıfa ekleme yapmak iste misiniz?");
    var Kontrol = Console.ReadLine();
    if (Kontrol == "e" || Kontrol == "E")
    {
        Console.Clear();
        Console.WriteLine("kayıt   nedir?");
        var kayitogretmen = Console.ReadLine();

        string eklenecekMetin = kayitogretmen+ Environment.NewLine;
        string eklenecekMetinClass = kayitogretmen;
               
               
        File.AppendAllText(dosyaYoluClassRoom, eklenecekMetin);
        Console.WriteLine("kayıt tamamlandı");
                
        Console.WriteLine("devam etmek için bir tuşa basın");
                
        Console.ReadKey();
        

    }
}





static void ogretmenYonetimi()
{ 
 
     string dosyaYoluogretmen = "ogretmen.txt";
    while (true)
    {
 
        Console.WriteLine("ogretmen Yönetimi");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("1.listele");
        Console.WriteLine("2.ekle");
        Console.WriteLine("3.sil");
        Console.WriteLine("0.Geri Döm");
      
        
        var ogretmenSecim = Console.ReadLine();
        string dosyaYoluClassroom = "classRoom.txt";
        switch (ogretmenSecim)
        {
            
            case "1":
             Console.Clear();
                if (File.Exists(dosyaYoluogretmen))
                {
                    string icerik = File.ReadAllText(dosyaYoluogretmen);
                    if (string.IsNullOrWhiteSpace(icerik))
                    {
                        Console.WriteLine("Dosya boş.");
                    }
                    else
                    {
                        Console.WriteLine("ogretmen Listesi:");
                        Console.WriteLine(icerik);
                    }
                }
                else
                {
                    Console.WriteLine("Dosya bulunamadı.");
                 
                }
                Console.WriteLine("Devam etmek için bir tuşa basın...");
                Console.ReadKey();
          
                break;
            case "2":
               Console.Clear();
                Console.WriteLine("kayıt edilecek ogretmen nedir?");
                var kayitogretmen = Console.ReadLine();

                string eklenecekMetin = kayitogretmen+ Environment.NewLine;
                string eklenecekMetinClass = kayitogretmen;
               
               
                File.AppendAllText(dosyaYoluogretmen, eklenecekMetin);
                Console.WriteLine("kayıt tamamlandı");
                
                Console.WriteLine("devam etmek için bir tuşa basın");
                
                Console.ReadKey();
               
                break;
            case "3":
              
                Console.WriteLine("hepsi silinecek emin misin");
              var DeleteDosya =  Console.ReadLine();
                if (DeleteDosya == "e" || DeleteDosya == "E")
                {
                    File.Delete(dosyaYoluogretmen);
                    Console.WriteLine("silme işlemi Başarılı");
                    Console.WriteLine("devam etmek için bir tuşa basın");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("işlem iptal edildi");
                }
                
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Geçersiz seçim. Lütfen geçerli bir seçenek girin.");
                Console.Clear();
                break;
        }
        
    }
}

var ogrenci = new List<Ogrenci>
{
    new Ogrenci { Name = "Ahmet", },
    new Ogrenci { Name = "Ayşe", },
    new Ogrenci { Name = "Mehmet", },
    new Ogrenci { Name = "Zeynep",  },
    new Ogrenci { Name = "Ali",  },
    new Ogrenci { Name= "Elif", }
};

