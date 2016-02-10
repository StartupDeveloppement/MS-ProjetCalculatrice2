using System;
using System.Linq;
using Projet.Niveau1.MoneyManagementCorrection.Affichage;
using Projet.Niveau1.MoneyManagementCorrection.Validation;

namespace Projet.Niveau1.MoneyManagementCorrection
{
    static class DisplayCenter
    {
        #region Affichage Console
        public static void Afficher(string texte)
        {
            Console.WriteLine(texte);
        }

        public static void Afficher(Textes texte)
        {
            Console.WriteLine(TextesDescription.Get(texte));
        }

        private static void AffichageCouleur(Textes texte, ConsoleColor couleur)
        {
            Console.ForegroundColor = couleur;
            Afficher(texte);
        }
        #endregion

        #region Menu
        public static void DisplayMenu()
        {
            Afficher("----------------------------------------");
            AffichageCouleur(Textes.MenuHome, ConsoleColor.White);
            Afficher("");
            AffichageCouleur(Textes.MenuItem1, ConsoleColor.Blue);
            AffichageCouleur(Textes.MenuItem2, ConsoleColor.Green);
            AffichageCouleur(Textes.MenuItem3, ConsoleColor.DarkMagenta);
            AffichageCouleur(Textes.MenuItem4, ConsoleColor.Red);
            AffichageCouleur(Textes.MenuItem5, ConsoleColor.DarkRed);
            AffichageCouleur(Textes.MenuItem6, ConsoleColor.White);
            Afficher("----------------------------------------");
        }
        #endregion

        public static bool DemanderSiAutreOperation(Textes texte, ValuesCondition condition)
        {
            var parametres = ParametersDescription.Get(condition);
            Afficher(TextesDescription.Get(texte) + parametres.Texte);
            try
            {
                int choix = Convert.ToInt16(Console.ReadLine());
                return parametres.Values.Contains(choix);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static double GetMontant(Textes texte, ValuesCondition condition)
        {
            var parametres = ParametersDescription.Get(condition);
            Afficher(TextesDescription.Get(texte) + parametres.Texte);
            try
            {
                int choix = Convert.ToInt16(Console.ReadLine());
                return choix;
            }
            catch (Exception)
            {
                return 1.0;
            }
        }

        public static DateTime GetDate(Textes texte, ValuesCondition condition)
        {
            var parametres = ParametersDescription.Get(condition);
            Afficher(TextesDescription.Get(texte) + parametres.Texte);
            return DateTime.Now;
        }

        public static bool GetRegularite(Textes texte, ValuesCondition condition)
        {
            var parametres = ParametersDescription.Get(condition);
            Afficher(TextesDescription.Get(texte) + parametres.Texte);
            try
            {
                int choix = Convert.ToInt16(Console.ReadLine());
                return parametres.Values.Contains(choix);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
