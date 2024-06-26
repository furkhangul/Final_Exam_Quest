
#Soru
/*
Araç adında, üretici, model ve yıl gibi özelliklere sahip bir sınıf tanımlayın. Bu temel sınıftan türetilmiş iki yeni sınıf
daha oluşturun, bu sınıflar “Otomobil” ve “Bisiklet” olsun. Her iki sınıfın da kendine özgü (en az üç tane) ek özellikleri
olmalıdır. Örneğin, otomobilin kapıSayısı, Bisikletin taşıyıcıVar gibi. Bu sınıfları kodlayın.
*/
using System;

public class Arac
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public int UretimYili { get; set; }
}

public class Bisiklet : Arac
{
    public string BisikletTip { get; set; }
    public int Vites { get; set; }
    public int FrenSayisi { get; set; }

}

public class Otomobil : Arac
{
    public string AracTipi {  get; set; }
    public int KapiSayisi { get; set; }
    public int KacKilomentre {  get; set; }
     
}

class Porgram { 
    static void Main()
    {
        Bisiklet bisiklet = new Bisiklet();
        bisiklet.Marka = "Salcano";
        bisiklet.Model = "3x3 Arazi";
        bisiklet.UretimYili = 2024;
        bisiklet.BisikletTip = "Yarış bisikleti";
        bisiklet.FrenSayisi = 2;
        bisiklet.Vites = 32;

        Otomobil otomobil = new Otomobil();
        otomobil.Marka = "AUDİ";
        otomobil.Model = "İ7";
        otomobil.UretimYili = 2020;
        otomobil.AracTipi = "Sedan";
        otomobil.KapiSayisi = 2;
        otomobil.KacKilomentre = 32000;


    }
}
