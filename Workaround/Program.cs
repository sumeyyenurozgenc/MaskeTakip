using Business.Concrete;
using Entities.Concrete;
using Microsoft.Win32.SafeHandles;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Vatandas vatandas1 = new Vatandas();
        //Variables();

        SelamVer("Sümeyye");
        SelamVer("Nur");
        SelamVer("Engin");
        SelamVer();

        int sonuc = Topla(6, 58);

        string ogrenci1 = "Engin";
        string ogrenci2 = "Berkay";
        string ogrenci3 = "Ali";

        //Console.WriteLine(ogrenci1);
        //Console.WriteLine(ogrenci2);
        //Console.WriteLine(ogrenci3);

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Kerem";
        ogrenciler[2] = "Berkay";

        ogrenciler = new string[4];
        ogrenciler[3] = "İlker";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        int sayi1 = 10;
        int sayi2 = 20;
        sayi2 = sayi1;
        sayi1 = 30;
        Console.WriteLine(sayi2);

        string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = { "Bursa", "Antalya", "Diyarbakır" };

        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";
        Console.WriteLine(sehirler2[0]);

        foreach (string sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }

        List<string> yeniSehirler1 = new List<string>() { "Ankara1", "İstanbul1", "İzmir1" };
        yeniSehirler1.Add("Adana1");

        foreach (string sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }

        Person person1 = new Person();
        person1.FirstName = "Sümeyye Nur";
        person1.LastName = "Özgenç";
        person1.NationalIdentity = 123;
        person1.DateOfBirthYear = 1997;

        Person person2 = new Person();
        person2.FirstName = "Engin";

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);


        Console.ReadLine();
    }
    static void SelamVer(string isim = "isimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }

    static int Topla(int sayi1 = 5, int sayi2 = 10)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam : " + sonuc);
        return sonuc;
    }

    static void Variables()
    {
        string mesaj = "Merhaba";
        double tutar = 10000;
        int sayi = 100;
        bool girisYapmisMi = false;


        string ad = "Sümeyye Nur";
        string soyad = "Özgenç";
        int dogumYili = 1997;
        long tc = 4548765213;


        Console.WriteLine(tutar * 1.18);
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }


        //public string ad = "Sümeyye Nur";
        //public string soyad = "Özgenç";
        //public int dogumYili = 1997;
        //public long tc = 4548765213;
    }
}