using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { }; //array tanımlamak için
            Urun urun1 = new Urun(); //class tanımlamak için kullanılır.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır";
            Urun[] urunler = new Urun[] {urun1,urun2 }; //dizi arrayi yaptık
            foreach (var urun in urunler) //urun ismi takma isimdir yerine x bile yazabilirsin. Urun veri tipidir aslında. var da yazabilirsin
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("...................");

            }

            Console.WriteLine("............Metotlar..............");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); //metodu çağırdık
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            
        }
    }
}
