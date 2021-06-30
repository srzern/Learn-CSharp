using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Id = 123;
            urun1.Adi = "Elma";
            urun1.Aciklama = "Taze bir elma";
            urun1.Fiyati = 11.99;

            Product urun2 = new Product();
            urun2.Id = 234;
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.Fiyati = 89.99;

            Product urun3 = new Product();
            urun3.Id = 345;
            urun3.Adi = "Kavun";
            urun3.Aciklama = "Yamuk bir kavun";
            urun3.Fiyati = 69.99;


            Product[] urunler = new Product[] {urun1,urun2, urun3};

            //instance - class örneği
            SepetManager sepetManager = new SepetManager();
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Id + ": " + urun.Adi + ": " + urun.Aciklama + ": " + urun.Fiyati + " lira ");
                sepetManager.Ekle(urun);
            }

            Console.WriteLine("----------------Ayırma----------------");
        }
    }
}
