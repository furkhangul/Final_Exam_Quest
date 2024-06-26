#Soru:
/*Bir firmaya ait bilgileri içeren “FirmaDetaylari” adında bir sınıf oluşturun. Bu bilgiler; firmanın adresi, çalışan sayısı
ve kuruluş tarihi olsun. Firmaya yeni eleman işe almak için “elemanEkle(miktar)” ve bir elemanı işten çıkarmak için
“elemanCikar(miktar)” gibi metotlar oluşturun ve değişkenleri doğrudan erişime kapatın. Buna göre gereken kodları
yazın.
*/
using System;
using System.Globalization;

class Program
{
    static FirmaDetaylari firma;
    static void Main()
    {
        Console.WriteLine("[1]Eleman Ekle ");
        Console.WriteLine("[2]Eleman Çıkar");
        Console.WriteLine("[3]Elemanları Görüntüle");
        Console.WriteLine("[4]Firma Bilgileri Ekle");
        Console.WriteLine("[0]Menüye Dön");
        Console.Write("Mod seç: ");
        int mod = int.Parse(Console.ReadLine());

        switch (mod)
        {
            case 0: 
                Console.Clear();
                Main();
                break;
            case 1:
                Console.Clear();
                elemanEkle();
                Console.ReadLine();
                Main();
                break;
            case 2:
                Console.Clear();
                elemanCikar();
                Console.ReadLine();
                Main();
                break;
            case 3:
                Console.Clear();
                FirmaBilgi();
                Console.ReadLine();
                Main();
                break;
            case 4: 
                Console.Clear();
                FirmaBilgiEkle();
                Console.ReadLine();
                Main();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Lütfen geçerli mod seç ! ");
                Main();
                break;
        } 
    }
    static void elemanCikar()
    {
        firma.CalisanSayisi = firma.CalisanSayisi - 1;
    }
    static void elemanEkle()
    {
        firma.CalisanSayisi = firma.CalisanSayisi + 1;
    }
    static void FirmaBilgi()
    {
        Console.WriteLine("Firma adı: {0}", firma.FirmaAdi);
        Console.WriteLine("Firma adresi: {0}", firma.FirmaAdres);
        Console.WriteLine("Çalışan sayısı: {0}", firma.CalisanSayisi);
        Console.WriteLine("Firma çalışan sayısı: {0}", firma.CalisanSayisi);
    }
    static void FirmaBilgiEkle()
    {
        Console.Write("Firma adını Giriniz: ");
        string firmaadi= Console.ReadLine();
        Console.Write("Firma adresini giriniz:");
        string firmaadres= Console.ReadLine();
        Console.Write("Çalışan eleman sayısını giriniz:");
        int calisansayisi= int.Parse(Console.ReadLine());
        Console.Write("Firma kuruluş yılı:");
        int kurulusyili = int.Parse(Console.ReadLine());

        firma = new FirmaDetaylari(firmaadi,firmaadres, calisansayisi,kurulusyili);
    }
}

class FirmaDetaylari
{
    public string FirmaAdi {  get; set; }
    public string FirmaAdres {  get; set; }
    public int CalisanSayisi {  get; set; }
    public int KurulusYili {  get; set; }
    public FirmaDetaylari(string firmaadi, string firmaadres, int calisansayisi, int kurulusyili)
    {
        FirmaAdi = firmaadi;
        FirmaAdres = firmaadres;
        CalisanSayisi = calisansayisi;
        KurulusYili = kurulusyili;
    }


}
