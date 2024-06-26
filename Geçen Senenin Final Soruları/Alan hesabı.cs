#Soru:
/*
Şekil adında soyut bir sınıf oluşturun ve bu sınıfın alanHesapla( ) adlı soyut bir metodu olsun. Daha sonra, Şekil
sınıfından türeyen ve alanHesapla() metodunu uygulayan Dikdörtgen ve Daire adında iki sınıf daha oluşturun.
Dikdörtgen sınıfının uzunluk ve genişlik, Daire sınıfının ise yarıçap özellikleri olmalıdır. Gerekli kodu yazın.
*/
using System;

abstract class Sekil
{
    public abstract double alanHesapla();

}
class Dikdortgen : Sekil
{
    public double KisaKenar {  get; set; }
    public double UzunKenar { get; set; }

    public Dikdortgen(double kisaKenar, double uzunKenar)
    {
        KisaKenar = kisaKenar;
        UzunKenar = uzunKenar;
    }

    public override double alanHesapla()
    {
        return UzunKenar * KisaKenar;
    }
}
class Daire : Sekil
{
    public double Yaricap { get; set; }

    public Daire(double yaricap)
    {
        Yaricap = yaricap;
    }

    public override double alanHesapla()
    {
        return Math.PI * Yaricap * Yaricap;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("[1] Dikdörtgen alan");
        Console.WriteLine("[2] Daire alan");
        Console.WriteLine("Seç:");
        int sec = int.Parse(Console.ReadLine());

        switch(sec)
        {
            case 1:
                dikdortgenHesapla();
                Console.ReadKey();
                Main();
                break;

            case 2:
                daireHesapla();
                Console.ReadKey();
                Main();
                break;
            default:
                Main();
                break;
        }
    }
    static void dikdortgenHesapla()
    {
        Console.WriteLine("UZUN KENAR:");
        double uzunkenar = double.Parse(Console.ReadLine());
        Console.WriteLine("KISA KENAR:");
        double kisakenar = int.Parse(Console.ReadLine());

        Dikdortgen dikdortgen = new Dikdortgen(uzunkenar, kisakenar);
        double alan = dikdortgen.alanHesapla();
        Console.WriteLine("Şeklin Alanı: {0}", alan);

    }
    static void daireHesapla() 
    {
        Console.WriteLine("Yarıçap:");
        double yaricap = double.Parse(Console.ReadLine());

        Daire daire = new Daire(yaricap);
        double alan = daire.alanHesapla();
        Console.WriteLine("Şeklin Alanı: {0}", alan);

    }
}
