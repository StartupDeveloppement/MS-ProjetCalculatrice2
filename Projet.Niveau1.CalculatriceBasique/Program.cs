using System;

namespace Projet.Niveau1.CalculatriceBasique
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Affichage.Afficher("Bonjour !");
            TypeOperation();
        }

        private static void TypeOperation()
        {
            Affichage.Afficher("Quelle type d'opération souhaitez vous faire :");
            Affichage.Afficher("1.Addition");

            int saisieClavier = Convert.ToInt16(Console.ReadLine());

            if (saisieClavier == 1)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                int premierChiffre = Convert.ToInt16(Console.ReadLine());
                Affichage.AfficherSansRetourLigne("Second nombre :");
                int secondChiffre = Convert.ToInt16(Console.ReadLine());

                var calcul = new Calcul(premierChiffre, secondChiffre);
                var resultat = calcul.addition();

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
            else
            {
                Affichage.Afficher("Mauvaise saisie");
                TypeOperation();
            }
        }
    }
}