using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {//naming convention
        //syntax
        public void Ekle(Urun urun) // Urun tipidir. Parantez içine parametre ekliyoruz. urun ise aşağıda kullanılacak isim
        { 
            Console.WriteLine("Sepete eklendi:"+urun.Adi); 
        }

        public void Ekle2(string urunAdi, string aciklama, int fiyati, int stok)
        {
            Console.WriteLine("Sepete eklendi:" + urunAdi);

        }

    }
}
