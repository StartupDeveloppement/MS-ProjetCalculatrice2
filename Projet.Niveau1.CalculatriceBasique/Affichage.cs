﻿using System;

namespace Projet.Niveau1.CalculatriceBasique
{
    public class Affichage
    {
        public static void Afficher(string texte)
        {
            Console.WriteLine(texte);
        }

        public static void AfficherSansRetourLigne(string texte)
        {
            Console.Write(texte);
        }
        public static void AffichageCouleur(string texte, ConsoleColor couleur)
        {
            Console.ForegroundColor = couleur;
            Afficher(texte);
     }
}
}