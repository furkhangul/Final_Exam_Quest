using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen matrisininzin satır sayısını giriniz: ");
        int satir = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen matrisinizin sütun sayısını giriniz: ");
        int sutun = Convert.ToInt32(Console.ReadLine());

        int[,] matris = new int[satir, sutun];
        for(int i = 0; i < satir; i++)
        {
            for(int j = 0; j < sutun; j++)
            {
                Console.WriteLine("Lütfen {0}.satırın {1}.sütununu giriniz: ",i+1,j+1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                matris[i, j] = sayi;

            }
        }
        for (int i = 0; i < satir; i++)
        {
            for (int j = 0; j < sutun; j++)
            {
                Console.Write(matris[i,j] + " ");
            }
            Console.WriteLine("\n");
        }


        Console.ReadLine();
    }
}
