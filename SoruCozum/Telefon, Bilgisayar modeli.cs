#soru
/*Üretici firma, model ve üretim tarihi gibi özelliklere sahip “Cihaz” adında bir temel sınıf oluşturun. Bu sınıfı, ek
özelliklere sahip olan “Akıllı Telefon” ve “Dizüstü Bilgisayar” adında iki yeni sınıf şeklinde genişletin. Her iki sınıfın
da kendine ait ek özellikleri olmalıdır. Örneğin; Akıllı Telefon'un “ekranBoyutu” ve Dizüstü Bilgisayar'ın “işlemciTipi”
gibi... Bu sınıfların kodlamasını yapın.*/


using System;
using System.ComponentModel.Design;

class Program
{

    static List<AkilliTelefon> AkilliTelefonlar = new List<AkilliTelefon>();
    static List<DizustuBilgisayar> DizustuBilgisayarlar = new List<DizustuBilgisayar>();
    static void Main()
    {
        Console.WriteLine("[1] Dizüstü Bilgisayar Ekle");
        Console.WriteLine("[2] Akıllı Telefon Ekle");
        Console.WriteLine("[3] Dizüstü Bilgisayar Listele");
        Console.WriteLine("[4] Akıllı Telefon Listele");
        Console.WriteLine("[0] Ana menüye dön");
        Console.Write("Numara gir: ");
        int mod = int.Parse(Console.ReadLine());
        switch(mod)
        {
            case 0:
                Console.Clear();
                DizustuBilgisayarEkle();
                Main();
                break;
            case 1:
                Console.Clear();
                AkilliTelefonEkle();
                Main();
                break;
            case 2:
                Console.Clear();
                DizustuBilgisayarListele();
                Console.ReadLine();
                Main();
                break;
            case 3:
                Console.Clear();
                AkilliTelefonListele();
                Console.ReadLine();
                Main();
                break;
            default:
                Console.WriteLine("LÜTFEN GEÇERLİ MOD SEÇ ! ");
                Main();
                break;
        }
    }
    
    static void DizustuBilgisayarEkle()
    {
        Console.Write("Üretici Firmayı Giriniz: ");
        string uretici = Console.ReadLine();
        Console.Write("Marka Modeli: ");
        string model = Console.ReadLine();
        Console.Write("Uretim Yili:");
        int uretmyili = int.Parse(Console.ReadLine());
        Console.Write("Ram Boyutu:");
        int ramboyutu = int.Parse(Console.ReadLine());
        Console.Write("Ekran Kartı Modeli:");
        string ekrankartimodeli = Console.ReadLine();
        Console.Write("İşlemi Modeli:");
        string islemcimodeli  = Console.ReadLine();
        Console.Write("SSD Boyutu:");
        int ssdboyutu = int.Parse(Console.ReadLine());

        DizustuBilgisayar yeniBilgisayar = new DizustuBilgisayar(uretici, model, uretmyili, ramboyutu, ekrankartimodeli,islemcimodeli,ssdboyutu);
        DizustuBilgisayarlar.Add(yeniBilgisayar);

    }
    static void AkilliTelefonEkle()
    {
        Console.Write("Üretici Firmayı Giriniz: ");
        string uretici = Console.ReadLine();
        Console.Write("Marka Modeli: ");
        string model = Console.ReadLine();
        Console.Write("Uretim Yili:");
        int uretmyili = int.Parse(Console.ReadLine());
        Console.Write("Ekran Boyuru(inc):");
        int ekranboyuru = int.Parse(Console.ReadLine());
        Console.Write("Kamera Pixeli:");
        int kamerapixel = int.Parse(Console.ReadLine());
        Console.Write("Batarya Depolama Miktarı(volt):");
        int batarya = int.Parse(Console.ReadLine());
        Console.Write("Depolama (gb):");
        int depolama = int.Parse(Console.ReadLine());

        AkilliTelefon yeniTelefon = new AkilliTelefon(uretici, model, uretmyili, ekranboyuru, kamerapixel,batarya,depolama);
        AkilliTelefonlar.Add(yeniTelefon);
    }
    static void DizustuBilgisayarListele()
    {
        Console.WriteLine("Dizüstü Bilgisayar Özellikleri:");
        foreach (var i in DizustuBilgisayarlar)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Üretici: {i.Uretici}");
            Console.WriteLine($"Model: {i.Model}");
            Console.WriteLine($"Üretim Yılı: {i.UretimYili}");
            Console.WriteLine($"RAM Boyutu: {i.RamBoytu} GB");
            Console.WriteLine($"Ekran Kartı Modeli: {i.EkranKartiModeli}");
            Console.WriteLine($"İşlemci Modeli: {i.İslemciModeli}");
            Console.WriteLine($"SSD Boyutu: {i.SsdBoyutu} GB");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");

        }

    }

    static void AkilliTelefonListele()
    {
        Console.WriteLine("Akilli Telefon Özellikleri:");
        foreach(var i in AkilliTelefonlar) 
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Üretici: {i.Uretici}");
            Console.WriteLine($"Model: {i.Model}");
            Console.WriteLine($"Üretim Yılı: {i.UretimYili}");
            Console.WriteLine($"Ekran Boyutu: {i.EkranBoyutu} inç");
            Console.WriteLine($"Kamera Çözünürlüğü: {i.KameraPixel} MP");
            Console.WriteLine($"Batarya Kapasitesi: {i.Batarya} mAh");
            Console.WriteLine($"Depolama Kapasitesi: {i.Depolama} GB");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");
        }

    }


}

class Cihaz
{
    public string Uretici {  get; set; }
    public string Model { get; set; }
    public int UretimYili { get; set; }

}
class AkilliTelefon : Cihaz
{
    public int EkranBoyutu { get; set; }
    public int KameraPixel {  get; set; }
    public int Batarya {  get; set; }
    public int Depolama { get; set; }

    public AkilliTelefon(string uretici, string model, int uretimyili,int ekranBoyutu, int kameraPixel, int batarya, int depolama)
    {
        Uretici = uretici;
        Model = model;
        UretimYili = uretimyili;
        EkranBoyutu = ekranBoyutu;
        KameraPixel = kameraPixel;
        Batarya = batarya;
        Depolama = depolama;
    }
}   

class DizustuBilgisayar : Cihaz
{
    public int RamBoytu {  get; set; }
    public string EkranKartiModeli {  get; set; }
    public string İslemciModeli{  get; set; }
    public int SsdBoyutu { get; set; }

    public DizustuBilgisayar(string uretici,string model, int uretimyili,int ramBoytu, string ekranKartiModeli, string islemciModeli, int ssdBoyutu)
    {
        Uretici = uretici;
        Model = model;
        UretimYili = uretimyili;
        RamBoytu = ramBoytu;
        EkranKartiModeli = ekranKartiModeli;
        İslemciModeli = islemciModeli;
        SsdBoyutu = ssdBoyutu;
    }
}   
