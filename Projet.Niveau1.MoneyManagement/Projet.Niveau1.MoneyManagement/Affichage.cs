
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
            Afficher("Menu du logiciel");
            Afficher("");
            Afficher("1. Lister le détails des opérations");
            Afficher("2. Ajouter une opération");
            Afficher("3. Ajouter une opération régulière");
            Afficher("4. Supprimer une opération");
            Afficher("5. Vider le compte");
            Afficher("6. Quitter le logiciel");
            Afficher("----------------------------------------");
        }
        #endregion

        public static bool DemanderSiAutreOperation()
        {
            //TODO : Afficher un message
            //Retourner true si oui, false si non
            return false;
        }
    }
}
