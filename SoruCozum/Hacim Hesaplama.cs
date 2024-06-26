#Soru:
/*HacimHesapla( ) adlı soyut bir metoda sahip “Geometri” isimli soyut bir sınıf oluşturun. Daha sonra, bu sınıftan
türeyen ve hacimHesapla( ) metodunu uygulayan “Küp” ve “Küre” adında iki sınıf daha oluşturun. Küp sınıfının kenar
uzunluğu ve Küre sınıfının ise yarıçapı özellikleri olmalıdır. Gerekli kodlamayı yapın*/


using System;
abstract class Geometri
{
    public abstract double HacimHesapla();
}

class Kup : Geometri
{
    public double KenarUzunlugu {  get; set; }

    public Kup(double kenarUzunlugu)
    {
        KenarUzunlugu = kenarUzunlugu;
    }

    public override double HacimHesapla()
    {
        return KenarUzunlugu* KenarUzunlugu*KenarUzunlugu;
    }
}

class Kure : Geometri
{
    public double YariCap {  get; set; }

    public Kure(double yaricap)
    {
        YariCap = yaricap;
    }

    public override double HacimHesapla()
    {
        return (4.0/3.0)*Math.PI*YariCap*YariCap*YariCap;
    }
}


class Program
{
    static void Main()
    {
        Console.WriteLine("[1]Küp Hesapla");
        Console.WriteLine("[2]Küre Hesapla");
        Console.WriteLine("Mod Seç:");
        int mod = int.Parse(Console.ReadLine());
        if(mod ==1)
        {
            Console.Clear();
            Console.WriteLine("Lütfen kenar uzunluğu gir:");
            double kenarUzunlugu = double.Parse(Console.ReadLine());
            Kup kup = new Kup(kenarUzunlugu);
            double hacim = kup.HacimHesapla();
            Console.WriteLine("Hacim: {0}", hacim);

        }
        else if(mod ==2)
        {
            Console.Clear();
            Console.WriteLine("Lütfen yarıçapı gir:");
            double yaricap = double.Parse(Console.ReadLine());
            Kure kure = new Kure(yaricap);  
            double hacim = kure.HacimHesapla();
            Console.WriteLine("Hacim: {0}", hacim);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Lütfen geçerli mod seç ! ");
            Main();
        }
    }
}
