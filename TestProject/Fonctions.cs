using System;
using System.Collections.Generic;

public class Function
{
    public static Random random = new Random();
    public static int[]? choixChiffre()
    {
        int[] ?chiffre = null;
        Console.WriteLine("Avec combien de chiffres voulez-vous jouer ? ");
        if (int.TryParse(Console.ReadLine(), out int Quantite) && Quantite > 1)
        {
            chiffre = new int[Quantite]; 
            for (int i = 0; i < Quantite; i++){
                chiffre[i] = random.Next(0, 10);
            }


        Console.WriteLine();

        return chiffre;
        }



        else
        {
            Console.WriteLine("Entrer un chiffre valide");
        }
        return null;
    }

    public static void trouverChiffre(int[]? chiffres)
    {
        if (chiffres != null)
        {
            Console.WriteLine($"| Trouvez les {chiffres.Length} chiffres qui composent le nombre.");

            bool gagne = false;
            while (!gagne)
            {
                Console.WriteLine($"Saisir les {chiffres.Length} chiffres à la suite :");
                string? reponse = Console.ReadLine();

                if (reponse != null && reponse.Length == chiffres.Length)
                {
                    int chiffresBienPlaces = 0;
                    // Utiliser une liste pour suivre les chiffres déjà comptés
                    List<int> chiffresDejaComptes = new List<int>();

                    for (int i = 0; i < reponse.Length; i++)
                    {
                        int chiffreUtilisateur = reponse[i] - '0';

                        if (chiffreUtilisateur == chiffres[i])
                        {
                            chiffresBienPlaces++;
                            // Ajouter à la liste des chiffres déjà comptés pour éviter de les recompter
                            chiffresDejaComptes.Add(chiffreUtilisateur);
                        }
                    }

                    int chiffresCorrects = 0;
                    for (int i = 0; i < reponse.Length; i++)
                    {
                        int chiffreUtilisateur = reponse[i] - '0';

                        // Vérifier si le chiffre est correct mais mal placé, et s'il n'a pas été déjà compté
                        if (chiffreUtilisateur != chiffres[i] && chiffres.Contains(chiffreUtilisateur) && !chiffresDejaComptes.Contains(chiffreUtilisateur))
                        {
                            chiffresCorrects++;
                            chiffresDejaComptes.Add(chiffreUtilisateur); // Ajouter pour éviter de recompter
                        }
                    }

                    if (chiffresBienPlaces == chiffres.Length)
                    {
                        Console.WriteLine("Félicitations ! Vous avez trouvé tous les chiffres et tous sont à la bonne place !");
                        gagne = true;
                    }
                    else if (chiffresBienPlaces > 0 || chiffresCorrects > 0)
                    {
                        Console.WriteLine($"Vous avez {chiffresCorrects + chiffresBienPlaces} chiffres corrects, {chiffresCorrects} chiffres mal placés, et {chiffresBienPlaces} chiffres à la bonne place. Essayez encore !");
                    }
                    else
                    {
                        Console.WriteLine("Aucun chiffre correct. Essayez encore !");
                    }
                }
                else
                {
                    Console.WriteLine($"Vous devez saisir exactement {chiffres.Length} chiffres.");
                }
            }
        }
    }
}
