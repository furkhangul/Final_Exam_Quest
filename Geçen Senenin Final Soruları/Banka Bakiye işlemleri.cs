#Soru:
/*
HesapDetayları adında, bir hesap sahibinin detaylarını kapsülleyen bir sınıf oluşturun. Bu detaylar hesapNumarasi,
hesapSahibiAdi ve bakiye olabilir. Para yatırma ve çekme (paraYatir(miktar), paraCek(miktar)) gibi metotlar
oluşturun, bakiye alanını doğrudan erişime kapatın. Gerekli kodu yazın.
*/

using System;

class Program
{
    static HesapDetaylari hesap;
    static void Main()
    {
        Console.WriteLine("[0] Ana Menüye Dön");
        Console.WriteLine("[1] Hesap Düzenle");
        Console.WriteLine("[2] Bakiye Ekle");
        Console.WriteLine("[3] Bakiye Çek");
        Console.WriteLine("[4] Hesap Bilgileri");
        Console.Write("İşlem Seç:");
        int mod = int.Parse(Console.ReadLine());

        switch(mod)
        {
            case 0: 
                Console.Clear();
                Main();
                break;
            case 1: 
                Console.Clear();
                hesapDuzenle();
                Console.ReadLine();
                Console.Clear();
                Main();
                break;
            case 2:
                Console.Clear();
                bakiyeEkle();
                Console.ReadLine();
                Console.Clear();
                Main();
                break;
            case 3:
                Console.Clear();
                bakiyeCek();
                Console.ReadLine();
                Console.Clear();
                Main();
                break;
            case 4:
                Console.Clear();
                hesapBilgileri();
                Console.ReadLine();
                Console.Clear();
                Main();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Lütfen Geçerli bi seçenek gir !");
                Console.ReadLine();
                Main();
                break;
        }
        static void hesapDuzenle()
        {
            Console.Write("Hesap sahibinin numarası: ");
            int hesapnumarasi = int.Parse(Console.ReadLine());
            Console.Write("Hesap sahibinin adı: ");
            string hesapsahibi= Console.ReadLine();
            Console.Write("Bakiye: ");
            int bakiye = int.Parse(Console.ReadLine());

            hesap = new HesapDetaylari(hesapnumarasi,hesapsahibi, bakiye);
        }
        static void bakiyeEkle()
        {
            Console.Write("Bakiyeye ne kadar para eklemek istediğini gir (TL):");
            int ekle = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}TL bakiyenize eklenmiştir !",ekle);

            hesap.Bakiye = hesap.Bakiye + ekle;

        }
        static void bakiyeCek()
        {
            Console.Write("Bakiyeden ne kadar para çekmek istediğini gir (TL):");
            int cek = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}TL bakiyenize eklenmiştir !", cek);

            hesap.Bakiye = hesap.Bakiye + cek;
        }
        static void hesapBilgileri()
        {
            Console.WriteLine("Hesap Bilgileri:");
            Console.WriteLine("Hesap sahibinin numarası:{0}",hesap.HesapNumarasi);
            Console.WriteLine("Hesap sahibinin adı:{0}",hesap.HesapSahibi);
            Console.WriteLine("Bakiye: {0}",hesap.Bakiye);

        }
    }
}

class HesapDetaylari
{
    public int HesapNumarasi {  get; set; }
    public string HesapSahibi {  get; set; }
    public int Bakiye {  get; set; }

    public HesapDetaylari(int hesapNumarasi,string hesapSahibi,int bakiye) 
    {
        hesapNumarasi = hesapNumarasi;
        hesapSahibi = hesapSahibi;
        Bakiye = bakiye;
    }
}
