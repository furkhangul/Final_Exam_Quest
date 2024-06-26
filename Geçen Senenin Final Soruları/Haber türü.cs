#Soru
/*
Bir haber metni analiz etme uygulamasının kodlanması isteniyor. Bu uygulama, “spor”, “ekonomi” ve “teknoloji”
haberlerini kategorize edebilmelidir. Uygulamanın girdisi, bir haber metnini string olarak almalı ve çıktısı, haberin
hangi kategoriye ait olduğunu söylemelidir. Uygulamanızı, basit düzeyde en çok hangi veya ne tür kelimelerin tekrar
ettiğine göre karar verecek şekilde tasarlayabilirsiniz (Örneğin en çok “maç” kelimesi geçiyorsa, bu haber muhtemelen
spor kategorisindedir).
*/
using System;

class Program
{
    static void Main()
    {
        int SporSayac = 0, EkonomiSayac = 0, TeknolojiSayac = 0;
        string haber = "Haber bilinmiyor !";
        Console.WriteLine("Metin gir:");
        string metin = Console.ReadLine();

        string[] sporKelimeleri = new string[] { "spor", "maç", "şut", "fenerbahçe" };
        string[] ekonomiKelimeleri = new string[] { "ekonomoi", "banka", "faiz", "enflasyon" };
        string[] teknolojiKelimeleri = new string[] { "teknoloji", "yapay zeka", "robot", "yazılım", "araç" };

        foreach(var kelime in sporKelimeleri)
        {
            if (metin.Contains(kelime))
            {
                SporSayac++;
            }
        }
        foreach(var kelime in ekonomiKelimeleri)
        {
            if (metin.Contains(kelime))
            {
               EkonomiSayac++;
            }
        }
        foreach(var kelime in teknolojiKelimeleri)
        {
            if (metin.Contains(kelime))
            {
                TeknolojiSayac++;
            }
        }
        if(SporSayac>TeknolojiSayac && SporSayac > EkonomiSayac)
        {
            haber = "Spor";
        }
        else if(EkonomiSayac> TeknolojiSayac && EkonomiSayac > SporSayac)
        {
            haber = "Ekonomi";
        }
        else if(TeknolojiSayac > SporSayac && TeknolojiSayac > EkonomiSayac)
        {
            haber = "Teknoloji";
        }
        Console.Clear();
        Console.WriteLine("Girdiğiniz haberin türü: {0}", haber);
    }
}
