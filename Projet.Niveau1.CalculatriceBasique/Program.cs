using System;

namespace Projet.Niveau1.CalculatriceBasique
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Affichage.AffichageCouleur("Bonjour !", ConsoleColor.Blue);
            TypeOperation();
        }

        private static void TypeOperation()
        {
            Affichage.AffichageCouleur("Quelle type d'opération souhaitez vous faire :", ConsoleColor.White);
            Affichage.AffichageCouleur("1.Addition", ConsoleColor.Red);
            Affichage.Afficher("2.Soustraction");
            Affichage.Afficher("3.Multiplication");
            Affichage.Afficher("4.Division");


            //try parse
            string saisieClavier = Console.ReadLine();

            int result;
            bool resultatParse = int.TryParse(saisieClavier, out result);
            if (!resultatParse)
            {
                Affichage.Afficher("la saisie n'est pas un nombre, try again!");
                TypeOperation();
            }
            else
            {
            
        
            if (result == 1)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double premierChiffre = Convert.ToDouble(Console.ReadLine());
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double secondChiffre = Convert.ToDouble(Console.ReadLine());

                var calcul = new Calcul(premierChiffre, secondChiffre);
                var resultat = calcul.addition();

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
            if (result == 2)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double premierChiffre = Convert.ToDouble(Console.ReadLine());
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double secondChiffre = Convert.ToDouble(Console.ReadLine());

                var calcul = new Calcul(premierChiffre, secondChiffre);
                var resultat = calcul.soustraction();

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
            if (result == 3)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double premierChiffre = Convert.ToDouble(Console.ReadLine());
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double secondChiffre = Convert.ToDouble(Console.ReadLine());

                var calcul = new Calcul(premierChiffre, secondChiffre);
                var resultat = calcul.multiplication();

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
            if (result == 4)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double premierChiffre = Convert.ToDouble(Console.ReadLine());
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double secondChiffre = Convert.ToDouble(Console.ReadLine());
                var calcul = new Calcul(premierChiffre, secondChiffre);
                var resultat = calcul.division();
                  
                
                    if (secondChiffre == 0) { 
                        Console.WriteLine("Impossible de diviser par 0 !");
                TypeOperation();
                }
        

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }

            {
                Affichage.Afficher("Mauvaise saisie");
                TypeOperation();
            }
        }
    }
}
}

