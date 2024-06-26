
#SORU:
/*
Bir organizasyonda üç farklı türden çalışanlar (“Yazılımcı”, “Tasarımcı”, “Yönetici”) olduğunu düşünün. Buna göre,
İsim, Soyisim, Kimlik No, Maaş gibi ortak özelliklere ve bir Ç𝒂𝒍𝚤ş𝒂𝒏𝑻ü𝒓ü( ) metodu bulunan Çalışan adında bir
soyut sınıf oluşturun. Bu sınıfın Ç𝒂𝒍𝚤ş𝒂𝒏𝑻ü𝒓ü( ) metodunu her bir çalışanın ne yaptığını konsol ekranına yazdıracak
şekilde Yazılımcı, Tasarımcı ve Yönetici sınıflarında uygulayın. Örneğin, bir Yazılımcı kod yazar, bir Tasarımcı 3D
katı modelleme yapar gibi.
*/
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("[1] Yazılımcı");
        Console.WriteLine("[2] Yönetici");
        Console.WriteLine("[3] Tasarımcı");
        Console.WriteLine("Seç: ");
        int sec = int.Parse(Console.ReadLine());

        if (sec == 1)
        {
            Console.Clear();
            yazilimcibilgi();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        else if (sec == 2)
        {
            Console.Clear();
            yoneticibilgi();
            Console.ReadLine();
            Console.Clear();
            Main();

        }
        else if(sec == 3)
        {
            Console.Clear();
            tasarimcibilgi();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        else
        {
            Console.Clear();
            Main();
        }
    }
    static void yazilimcibilgi()
    {
        Yazilimci yazilim = new Yazilimci();
        yazilim.Isim = "Furkan";
        yazilim.Soyisim = "Gül";
        yazilim.TC = 132456;
        yazilim.Maas = 500;
        yazilim.calisanTur();

      
       
            Console.WriteLine("İsim:{0}",yazilim.Isim);
            Console.WriteLine("Soyisim:{0}", yazilim.Soyisim);
            Console.WriteLine("TC:{0}", yazilim.TC);
            Console.WriteLine("Maas:{0}",yazilim.Maas);
        
        
    }
    static void yoneticibilgi()
    {
        Yonetici yonet = new Yonetici();
        yonet.Isim = "Furkan";
        yonet.Soyisim = "Gül";
        yonet.TC = 132456;
        yonet.Maas = 500;
        yonet.calisanTur();
        
        
            Console.WriteLine("İsim:{0}", yonet.Isim);
            Console.WriteLine("Soyisim:{0}", yonet.Soyisim);
            Console.WriteLine("TC:{0}", yonet.TC);
            Console.WriteLine("Maas:{0}", yonet.Maas);
        
    }
    static void tasarimcibilgi()
    {
        Tasarimci tasarim = new Tasarimci();
        tasarim.Isim = "Furkan";
        tasarim.Soyisim = "Gül";
        tasarim.TC = 132456;
        tasarim.Maas = 500;
        tasarim.calisanTur();
  

            Console.WriteLine("İsim:{0}", tasarim.Isim);
            Console.WriteLine("Soyisim:{0}", tasarim.Soyisim);
            Console.WriteLine("TC:{0}",tasarim.TC);
            Console.WriteLine("Maas:{0}", tasarim.Maas);
        
    }
}



abstract class Calisan
{

    public string Isim { get; set; }
    public string Soyisim{  get; set; }
    public int TC{  get; set; }
    public int Maas {  get; set; }
    public abstract void calisanTur();
}
class Yazilimci : Calisan
{
    public override void calisanTur()
    {
        Console.WriteLine("Yazılımcı yazılım için gereken tabanı hazırlar !");
    }
}

class Tasarimci : Calisan
{
    public override void calisanTur()
    {
        Console.WriteLine("Tasarımcı hazırlanan yazılımın göreselleştirilip gelişrilmesinde görev yapar ! ");

    }
}
class Yonetici : Calisan
{
    public override void calisanTur()
    {
        Console.WriteLine("Olayların takibini ve görev dağılımı gibi bir çok olaya müdahle eder !");

    }
}
