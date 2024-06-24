using System;
using System.Security.Cryptography.X509Certificates;

class Prgram
{
    static List<Musteri> musteriler = new List<Musteri>();
    static void Main()
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("| [1] Müşteri Ekle");
        Console.WriteLine("| [2] Müşterileri Görüntüle");
        Console.WriteLine("| [0] Ana Menüye Dön");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Mod Seç:");
        int mod = int.Parse(Console.ReadLine());
        switch(mod)
        {
            case 0: 
            Console.Clear();
                Main();
                break;
            case 1:
                Console.Clear();
                MuseriEkle();
                Console.Clear();
                Main();
                break; 
            case 2:
                Console.Clear();
                MusteriGoruntule();
                Console.ReadLine();
                Console.Clear();
                Main();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Lütfen geçerli bi mod seçiniz ! ");
                Main();
                break;
        }
    }
    
    static void MuseriEkle()
    {
     
        Console.Write("Lütfen müşeri ID'sini giriniz:");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Lütfen müşeri ismini giriniz:");
        string name = Console.ReadLine();
        Console.Write("Lütfen müşeri soyadını giriniz:");
        string surname = Console.ReadLine();
        Console.Write("Lütfen müşeri yaşını giriniz:");
        int age = int.Parse(Console.ReadLine());   
        Console.Write("Lütfen müşteri mesleği giriniz:");
        string departmant = Console.ReadLine();

        Musteri yenimusteri = new Musteri(id,name, surname,age, departmant);
        musteriler.Add(yenimusteri);
    }
    static void MusteriGoruntule()
    {
        foreach(var i in musteriler)
        {
            Console.WriteLine("ID:{0}",i.ID);
            Console.WriteLine("İsim:{0}",i.Name);
            Console.WriteLine("Soyisim:{0}", i.Surname);
            Console.WriteLine("Yaş:{0}", i.Age);
            Console.WriteLine("Meslek:{0}", i.Departmant);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");
        }
    }
}


public class Musteri
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Departmant { get; set; }  

    public Musteri(int id, string name, string surname, int age, string departmant)
    {
        ID = id;
        Name = name;
        Surname = surname;
        Age = age;
        Departmant = departmant;
    }
}
