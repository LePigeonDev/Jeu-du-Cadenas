using System;
using System.Net;

public class Cadenas
{
    static void Main(string[] args)
    {        
        Console.WriteLine("\n\t\t\t\t\t\t\t\t\t --------------");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t|Jeu du Cadenas|");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t --------------\n");
        int[]? chiffres = Function.choixChiffre();
        Function.trouverChiffre(chiffres);
    }
}
