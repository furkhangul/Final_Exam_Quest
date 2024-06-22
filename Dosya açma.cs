using System;
using System.IO;

class Program

{
    static void Main()
    {
        string uzanti = @"C:\Users\Furkan\Desktop";

        bool dizinVarMi = Directory.Exists(uzanti);

        if (!dizinVarMi)
        {
            Directory.CreateDirectory(uzanti);
        }

        Console.ReadLine();
    } 
}
