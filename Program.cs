using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Gökhan";
            calisan1.soyAd = "Çam";
            calisan1.No=55;
            calisan1.Departman="Yazılım";

            calisan1.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string soyAd;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan Adi: {0}",Ad);
            Console.WriteLine("Calisan Adi: {0}",soyAd);
            Console.WriteLine("Calisan Adi: {0}",No);
            Console.WriteLine("Calisan Adi: {0}",Departman);
        }

    }
}