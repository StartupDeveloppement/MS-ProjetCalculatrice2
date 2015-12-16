using System;
using static System.Console;

namespace Projet.Niveau1.MoneyManagement
{
    class Affichage
    {
        #region Affichage Console
        public static void Afficher(string texte)
        {
            WriteLine(texte);
        }

        public static void AfficherSansRetourLigne(string texte)
        {
            Write(texte);
        }
        #endregion

        #region Menu
        public static void DisplayMenu()
        {
            Afficher("----------------------------------------");
            AffichageCouleur("Menu du logiciel",ConsoleColor.White);
            Afficher("");
            AffichageCouleur("1. Lister le détails des opérations", ConsoleColor.Green);
            Afficher("2. Ajouter une opération");
            Afficher("3. Ajouter une opération régulière");
            Afficher("4. Supprimer une opération");
            Afficher("5. Vider le compte");
            Afficher("6. Quitter le logiciel");
            AffichageCouleur("----------------------------------------",ConsoleColor.White);
        }
        #endregion

        public static void AffichageCouleur(string texte, ConsoleColor couleur)
        {
            ForegroundColor = couleur;
            Afficher(texte);
        }

        public static bool DemanderSiAutreOperation()
        {
            //TODO : Afficher un message
            //Retourner true si oui, false si non
            return false;
        }
    }
}
