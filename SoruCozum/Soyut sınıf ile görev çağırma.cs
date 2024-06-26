#SORU:
/*Bir okulda farklı türden çalışanlar (Öğretmen, Temizlik Görevlisi ve Müdür) olduğunu düşünün. Adı soyadı, sicil
numarası, maaş gibi ortak özelliklere sahip ve görevYap( ) metodu bulunan “OkulPersoneli” adında soyut bir sınıf
oluşturun. Buna göre, görevYap( ) metodunu her bir çalışanın ne iş yaptığını ekrana yazdıracak şekilde “Öğretmen”,
“Temizlik Görevlisi” ve “Müdür” sınıflarında uygulayın. (Örneğin, bir Öğretmen ders verir, bir Temizlik Görevlisi
okulu temizler gibi...)*/
using System;

 public abstract class OkulPersoneli
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int  No { get; set; }
    public int Age { get; set; }
    public abstract void gorevYap();
}

public class Ogretmen : OkulPersoneli
{
    public override void gorevYap()
    {
        Console.WriteLine("Öğretmen Ders Verir ! ");
    }
}

public class TemizlikGorevlisi : OkulPersoneli
{
    public override void gorevYap()
    {
        Console.WriteLine("Temizlik personeli okulun temizlik işleri ile ilgilenir ! ");
    }

}
public class Mudur : OkulPersoneli
{
    public override void gorevYap()
    {
        Console.WriteLine("Okul müdürü okulun idaresini ve ilgili işilerin yürütülmesinden sorumludur ! ");
    }

}

class Program
{
    static void Main()
    {

        Ogretmen ogretmen = new Ogretmen();
        ogretmen.Name = "Furkan";
        ogretmen.Surname = "Gül";
        ogretmen.No = 12;
        ogretmen.Age = 20;

        TemizlikGorevlisi temizlik = new TemizlikGorevlisi();
        temizlik.Name = "Feyzullah";
        temizlik.Surname = "Ramiz";
        temizlik.No = 2;
        temizlik.Age = 40;

        Mudur mudur = new Mudur();
        mudur.Name = "Murat";
        mudur.Surname = "Demir";
        mudur.No = 3;
        mudur.Age = 50;

        mudur.gorevYap();
        temizlik.gorevYap();
        ogretmen.gorevYap();
        
      
    }
}
