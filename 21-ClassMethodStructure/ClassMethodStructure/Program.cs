using System;

namespace ClassMethodStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SinifAdi
            //{
            //   [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
            //   [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //   {
            //       Metot Komutları
            //   }
            //}


            // Erişim Belirleyiciler
            // *Public
            // *Private
            // *Internal
            // *Protected


            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Burak";
            calisan1.Soyad = "Beştaş";
            calisan1.No = 12345678;
            calisan1.Departman = "Yazılım";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan("Deniz", "Arda", 98765432, "İnsan Kaynakları");
            //calisan2.Ad = "Deniz";
            //calisan2.Soyad = "Arda";
            //calisan2.No = 98765432;
            //calisan2.Departman = "İnsan Kaynakları";

            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyAd, int no, string depertman)
        {
            Ad = ad;
            Soyad = soyAd;
            No = no;
            Departman = depertman;
        }

        public Calisan() { }


        internal void CalisanBilgileri()
        {
            Console.WriteLine($"Çalışan Adı: {Ad}");
            Console.WriteLine($"Çalışan Soyadı: {Soyad}");
            Console.WriteLine($"Çalışan Numarası: {No}");
            Console.WriteLine($"Çalışan Departmanı: {Departman}");
        }
    }
}
