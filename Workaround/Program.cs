using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Degiskenler();

            SelamVer(isim: "Engin");
            SelamVer(isim:"Erto");
            SelamVer(isim:"Ayşe");
            SelamVer();


            int sonuc = Topla(50);



            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);

        }

        static int Topla(int sayi1 , int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;

        }

        private static void Degiskenler()
        {
            //degiskenler();

            Vatandas vatandas = new Vatandas();
            
            

            
            

        }

        private static void NewMethod1()
        {
            string mesaj = "Selam";
            double tutar = 100000.5; //db'den gelir.
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Ertuğrul";
            string soyadi = "Yanardağ";
            int dogumYili = 1993;
            long tcNo = 41167744420;


            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);

            Console.WriteLine(tutar);
            Console.WriteLine(tutar);
        }
    }
    //pascal casing
    public class Vatandas
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public int DogumYili { get; set; }

        public long TcNo { get; set; }
    }

    

    
}
