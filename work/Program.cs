using System;

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAd = "Nacide";
            musteri1.MusteriSoyad = "Kalkarlar";
            musteri1.MusteriYas = 42;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAd = "Kalem";
            musteri2.MusteriSoyad = "Lüle";
            musteri2.MusteriYas = 38;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAd = "Hakim";
            musteri3.MusteriSoyad = "LD";
            musteri3.MusteriYas = 45;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.MusteriAd = "Doktor";
            musteri4.MusteriSoyad = "Sancak";
            musteri4.MusteriYas = 28;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("---------------------Çoklu Müşteri Ekleme---------------------");
            foreach (var musteri in musteriler)
            {
                musteriManager.Add(musteri);
            }

            Console.WriteLine("-----------------Tekli Müşteri Ekleme-------------------------");
            musteriManager.Add(musteri4);
            Console.WriteLine("------------------Müşteri Silme------------------------");
            var siMusteri = musteri1;
            musteriManager.Delete(siMusteri);
            Console.WriteLine("--------------------Özel Müşteri Listeleme----------------------");
            var liMusteri = musteri1;
            musteriManager.List(liMusteri);

            Console.WriteLine("-------------------Genel Listeleme-----------------------");
            foreach (var musteri in musteriler)
            {


                Console.WriteLine("Müşteri başarıyla listelendi:");
                musteriManager.GenelListe(musteri);


            }

        }
    }
}
