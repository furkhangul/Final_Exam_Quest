/*Örnek amacı ile kodlandı*/

using System;


class Program
{
    static void Main()
    {

        Console.WriteLine("Lütfen Kareinin kenarını giriniz:");
        int karekenar =int.Parse(Console.ReadLine());
        Console.WriteLine("Lütfen kürenin yarıçapını giriniz:");
        int kureyaricap=int.Parse(Console.ReadLine());
        Kare kare = new Kare();
        kare.Kenar = karekenar;
        Kure kure = new Kure();
        kure.Yaricap = kureyaricap;

        double kareHacim = kare.hacimHesapla();
        Console.WriteLine("Karenin hacmi: {0}",kareHacim);
        double kureHacim = kure.hacimHesapla();
        Console.WriteLine("Kurenin hacmi: {0}", kureHacim);
    }
}
abstract class Geometri
{
    public abstract double hacimHesapla();
}

class Kure : Geometri
{
    public double Yaricap {  get; set; }
    public override double hacimHesapla()
    {
        return (4.0 / 3.0) * Yaricap * Yaricap * Yaricap * Math.PI;
    }
}
class Kare : Geometri
{
    public double Kenar { get; set; }

    public override double hacimHesapla()
    {
        return Kenar * Kenar * Kenar;
    }
}
