
#Soru:
/*
Bir e-ticaret sitesi gönderisinin analizinin yapılması istenmektedir. Bunun için geliştirilecek uygulama, analiz edilen
ürünler için “iyi”, “orta” ve “kötü” olarak üç kategoride değerlendirmelidir. Bu uygulamanın girdisi bir string (gönderi
metni) olacak ve çıktısı, gönderinin hangi kategoriye ait olduğunu belirleyecektir. Uygulamanızı, kelimelerin içerdiği
anlam bakımından en çok tekrar eden kategoriye göre karar verecek şekilde tasarlayabilirsiniz (Örneğin, en çok “fena
değil” kelimesi geçiyorsa, bu gönderi muhtemelen orta kategorisindedir, “çok memnunum” kelimesi geçiyorsa iyi
kategorisindedir).
*/
using System;

class Program
{
    static void Main()
    {
        int iyiKelimeSayisi = 0;
        int ortaKelimeSayisi = 0;
        int kotuKelimeSayisi = 0;

        string memnuniyet;

        string[] iyiKelimeler = new string[] { "çok memnunum", "harika", "çok iyi" };
        string[] ortaKelimeler = new string[] { "orta", "memnunum", "fena değil" };
        string[] kotuKelimeler = new string[] { "kötü", "çok kötü", "hayal kırıklığı" };

        Console.WriteLine("Lütfen E-ticaret sitenizde girdiğiniz metni yazınız:");
        string metin = Console.ReadLine();

   
        foreach (var kelime in iyiKelimeler)
        {
            if (metin.Contains(kelime))
            {
                iyiKelimeSayisi++;
            }
        }

        foreach (var kelime in ortaKelimeler)
        {
            if (metin.Contains(kelime))
            {
                ortaKelimeSayisi++;
            }
        }

        foreach (var kelime in kotuKelimeler)
        {
            if (metin.Contains(kelime))
            {
                kotuKelimeSayisi++;
            }
        }
        if (iyiKelimeSayisi > ortaKelimeSayisi && iyiKelimeSayisi > kotuKelimeSayisi)
        {
            memnuniyet = "iyi";
        }
        else if (ortaKelimeSayisi > kotuKelimeSayisi && ortaKelimeSayisi > iyiKelimeSayisi)
        {
            memnuniyet = "orta";
        }
        else
        {
            memnuniyet = "kötü";
        }

        Console.Clear();
        Console.WriteLine("Girdiğiniz metnin analizi sonucunda metnin {0} bir metin olduğunu göstermektedir.", memnuniyet);
    }
}
