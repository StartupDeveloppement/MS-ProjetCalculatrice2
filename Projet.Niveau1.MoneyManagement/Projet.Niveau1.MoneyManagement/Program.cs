
using System;
using System.Collections.Generic;

namespace Projet.Niveau1.MoneyManagement
{
    class Program
    {
        internal static bool ExitRequested;
        private static List<Operation> _compteEnBanque;

        static void Main(string[] args)
        {
            Affichage.Afficher("Bonjour !");
            ExitRequested = false;
            _compteEnBanque = new List<Operation>();
            BeginMoneyManagement();
        }

        private static void BeginMoneyManagement()
        {
            while(ExitRequested == false)
            {
                Affichage.DisplayMenu();
                int choix = Convert.ToInt16(Console.ReadLine());
                if (choix != 6)
                {
                    PlayIt(choix);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }

        private static void PlayIt(int choix)
        {
            switch (choix)
            {
                case 1:
                    ListerLesOperations();
                    break;
                case 2:
                    AjouterUneOperation();
                    break;
                case 3:
                    AjouterDesOperations();
                    break;
                case 4:
                    SupprimerUneOperation();
                    break;
                case 5:
                    ViderLeCompte();
                    break;
            }
        }

        private static void ViderLeCompte()
        {
            _compteEnBanque = null;
            Affichage.Afficher("Le compte est vide, merci de passer à la banque");
        }

        private static void SupprimerUneOperation()
        {
            Affichage.Afficher("Merci de donner des détails afin de trouver la bonne opération : ");

            Operation dummy = new Operation(new DateTime(), 0,false);
            dummy.GetDate();
            dummy.GetMontant();
            dummy.GetRegularite();

            bool existe = EstCeQueOperationExiste(dummy);
            if(existe)
            {
                if (Affichage.DemanderSiAutreOperation())
                {
                    _compteEnBanque.Remove(dummy);
                }
                else
                {
                    Affichage.Afficher("Cette opération ne va pas être supprimée");
                }
            }
            else
            {
                Affichage.Afficher("Cette opération n'existe pas, merci de recommencer");
            }
        }

        private static bool EstCeQueOperationExiste(Operation dummy)
        {
            bool result = false;
            foreach (var operation in _compteEnBanque)
            {
                if (operation.Equals(dummy))
                    result = true;
            }
            return result;
        }

        private static void AjouterDesOperations()
        {
            bool finAjout = true;
            int nombre = 1;
            Affichage.Afficher("Début des ajouts");
            while (finAjout)
            {
                Affichage.Afficher("Opération " + nombre + " :");
                AjouterUneOperation();
                finAjout = Affichage.DemanderSiAutreOperation();
            }
        }

        private static void AjouterUneOperation()
        {
            //TODO
            //Prendre en compte les choix de l'utilisateur, vérifier les saisies
            Affichage.Afficher("----- Ajout d'une opération -----");
            Affichage.Afficher("Date de l'opération : ");
            DateTime saisie = new DateTime();
            Affichage.Afficher("Montant de l'opération : ");
            int montant = 100;
            Affichage.Afficher("Opération régulière (0 pour non, 1 pour oui)");
            bool regulier = true;
            Operation operationEnCours = new Operation(saisie, montant, regulier);
            _compteEnBanque.Add(operationEnCours);
        }

        private static void ListerLesOperations()
        {
            if(_compteEnBanque.Count == 0)
            {
                Affichage.Afficher("Aucune opération disponible, merci de créditer votre compte");
            }
            else
            {
                Affichage.Afficher("----- Liste des opérations -----");
                foreach (var operation in _compteEnBanque)
                {
                    string operationAvecFormat = operation.ToString();
                    Affichage.Afficher(operationAvecFormat);
                }
            }
            Affichage.Afficher("");
        }
    }
}
