using System;
using System.Collections.Generic;
using System.Text;

namespace work
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri: " + musteri.Id + ": " + musteri.MusteriAd + " " + musteri.MusteriSoyad + " başarıyla eklediniz!");
        }

        public void List(Musteri liMusteri)
        {
            Console.WriteLine("Müşteri: " + liMusteri.Id + " Başarıyla Listelendi: " + "\n" + liMusteri.MusteriAd + "\n" + liMusteri.MusteriSoyad + "\n" + liMusteri.MusteriYas);
        }
        public void Delete(Musteri siMusteri)
        {
            Console.WriteLine("Müşteri: " + siMusteri.MusteriAd + " başarıyla silindi");
        }

        public void GenelListe(Musteri musteri)
        {
            Console.WriteLine("\n" + musteri.Id + "\n" + musteri.MusteriAd + "\n" + musteri.MusteriSoyad + "\n" + musteri.MusteriYas);
        }
    }
}
