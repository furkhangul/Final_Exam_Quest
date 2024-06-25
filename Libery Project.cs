using System;

class Program
{
    static List<Kitap> Kitaplar = new List<Kitap>();
    static List<Kullanici> Kullaniciler = new List<Kullanici>();
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(" _  ___  _ _   _  _      _                   __   ___   _         _   _         ___ _    _             _ ");
        Console.WriteLine("| |/ (_)(_) |_(_)(_)_ __| |_  __ _ _ _  ___  \\ \\ / (_)_(_) _  ___| |_(_)_ __   / __(_)__| |_ ___ _ __ (_)");
        Console.WriteLine("| ' <| || |  _| || | '_ \\ ' \\/ _` | ' \\/ -_)  \\ V / / _ \\ ' \\/ -_)  _| | '  \\  \\__ \\ (_-<  _/ -_) '  \\| |");
        Console.WriteLine("|_|\\_\\\\_,_|\\__|\\_,_| .__/_||_\\__,_|_||_\\___|   |_|  \\___/_||_\\___|\\__|_|_|_|_| |___/_/__/\\__\\___|_|_|_|_|");
        Console.WriteLine("                   |_|                                                                                   ");
        Console.WriteLine("                                 Furkan Gül  | Nesne Yönelimli Programlama I                             ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("\n[*]Bu program 'Nesne Yönelimli Programlama I' dersinin ödevi olarak Furkan Gül tarafından kodlanmıştır.");
        Console.WriteLine("[*]Kütüphane uygulamasında kullanıcı ekleme/çıkarma, kitap ekleme/çıkarma, kullanım bilgileri gibi özellikler mevcuttur.");
        Console.WriteLine("[*]Lütfen sadece yönergeleri takip ediniz!");
        menu();

    }
    static void menu()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("| [1] Kitap Ekle                    |");
        Console.WriteLine("| [2] Kitapları Gör                 |");
        Console.WriteLine("| [3] Kullanıcı EKle                |");
        Console.WriteLine("| [4] Kullanıcıları Gör             |");
        Console.WriteLine("| [0] Ana Menüye Dön                |");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Lütfen bir mod giriniz: ");
        int mod = int.Parse(Console.ReadLine());
        switch(mod)
        {
            case 0:
                Console.Clear();
                Main();
                break;
            case 1: 
                Console.Clear();
                KitapEkle();
                break;
            case 2:
                Console.Clear();
                KitaplariGor();
                break;
            case 3:
                Console.Clear();
                KullaniciEkle();
                break;
            case 4:
                Console.Clear();
                KullanicileriGor();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Girdiğiniz mod bulunamıyor lütfen tekrar deneyiniz !");
                menu();
                break;
        }
    }
    static void KitapEkle()
    {
        Console.WriteLine("Lütfen kitap ISBN kodunu giriniz: ");
        int isbn = int.Parse(Console.ReadLine());
        Console.WriteLine("Lütfen kitap adını giriniz: ");
        string name = Console.ReadLine();
        Console.WriteLine("Lütfen kitap yazarının adını giriniz: ");
        string bookwriter= Console.ReadLine();
        Console.WriteLine("Lütfen kitap basım yılını giriniz: ");
        int year = int.Parse(Console.ReadLine());

        Kitap kitapekle = new Kitap(isbn,name,bookwriter,year);
        Kitaplar.Add(kitapekle);
    }
    static void KitaplariGor()
    {
        foreach(var i in Kitaplar)
        {
            Console.WriteLine("Kitap ISBN kodu: {0}",i.ISBN);
            Console.WriteLine("Kitap adı: {0}", i.BookName);
            Console.WriteLine("Kitap yazarının adı: {0}", i.BookWriter);
            Console.WriteLine("Kitap basım yılı: {0}", i.Year);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--------------------------------------");

        }

    }
    static void KullaniciEkle()
    {
        Console.WriteLine("Lütfen kullanıcının ID'sini giriniz: ");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Lütfen kullanıcının adını giriniz: ");
        string name = Console.ReadLine();
        Console.WriteLine("Lütfen kullanıcının soyadını giriniz: ");
        string surname = Console.ReadLine();
        Console.WriteLine("Lütfen kullanıcının doğum yılını giriniz: ");
        int age = int.Parse(Console.ReadLine());
        Kullanici yenikullanici = new Kullanici(id,name,surname,age);
        Kullaniciler.Add(yenikullanici);
    }
    static void KullanicileriGor()
    {
        foreach (var i in Kullaniciler)
        {
            Console.WriteLine("Kullanıcının ID'si: {0}", i.ID);
            Console.WriteLine("Kullanıcının adı: {0}", i.Name);
            Console.WriteLine("Kullanıcının soyadı: {0}", i.Surname);
            Console.WriteLine("Kullanıcının yaşı: {0}", i.Age);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--------------------------------------");

        }
    }
}

class Kitap
{
    public int ISBN { get; set; }
    public string BookName { get; set; }
    public string BookWriter { get; set; }
    public int Year { get; set; }

    public Kitap(int isbn, string bookname, string bookwriter, int year)
    {
        ISBN = isbn;
        BookName = bookname;
        BookWriter = bookwriter;
        Year = year;
    }
}
class Kullanici
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Surname {  get; set; }
    public int Age {  get; set; }

    public Kullanici(int id,string name,string surname,int age) 
    {
        ID = id;
        Name = name;
        Surname = surname;
        Age = age;
    }

}
