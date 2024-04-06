using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n---------------------\n");
        Console.WriteLine("Smartphone Nokia");
        Smartphone nokia = new Nokia("111111111", "Modelo 1", "1234567891011", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Instagram");

        Console.WriteLine("\n---------------------\n");
        Console.WriteLine("Smartphone Iphone");
        Smartphone iphone = new Iphone("2222222222", "Modelo 2", "1234567891011", 64);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Facebook");
    }
}
