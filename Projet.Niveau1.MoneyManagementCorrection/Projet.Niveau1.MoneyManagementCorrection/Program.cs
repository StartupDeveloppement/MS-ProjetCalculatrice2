using System;
using System.Collections.Generic;
using Projet.Niveau1.MoneyManagementCorrection.Affichage;
using Projet.Niveau1.MoneyManagementCorrection.Validation;
// ReSharper disable UnusedParameter.Local

namespace Projet.Niveau1.MoneyManagementCorrection
{
    internal static class Program
    {
        private static bool _exitRequested;
        private static List<Operation> _compteEnBanque;

        private static void Main(string[] args)
        {
            DisplayCenter.Afficher(Textes.Welcome);
            _exitRequested = false;
            _compteEnBanque = new List<Operation>();
            BeginMoneyManagement();
        }

        private static void BeginMoneyManagement()
        {
            while (_exitRequested == false)
            {
                DisplayCenter.DisplayMenu();
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
            DisplayCenter.Afficher(Textes.AccountIsEmpty);
        }

        private static void SupprimerUneOperation()
        {
            DisplayCenter.Afficher(Textes.AskForAllDetails);

            var dummy = new Operation(new DateTime(), 0, false)
            {
                DateOperation = DisplayCenter.GetDate(Textes.FindDate, ValuesCondition.LessThanOne),
                Montant = DisplayCenter.GetMontant(Textes.FindMontant, ValuesCondition.LessThanOne),
                Regulier = DisplayCenter.GetRegularite(Textes.FindRegularite, ValuesCondition.AbcOneTwoThree)
            };

            var existe = EstCeQueOperationExiste(dummy);
            if (existe)
            {
                _compteEnBanque.Remove(dummy);
                if (DisplayCenter.DemanderSiAutreOperation(Textes.AskForAnotherToDelete, ValuesCondition.OneForYesZeroForNo))
                {
                    SupprimerUneOperation();
                }
            }
            else
            {
                DisplayCenter.Afficher(Textes.FindNotFound);
            }
        }

        private static bool EstCeQueOperationExiste(Operation dummy)
        {
            var result = false;
            foreach (var operation in _compteEnBanque)
            {
                if (operation.Equals(dummy))
                    result = true;
            }
            return result;
        }

        private static void AjouterDesOperations()
        {
            var finAjout = true;
            int nombre = 1;
            DisplayCenter.Afficher(Textes.AddsPart);
            while (finAjout)
            {
                DisplayCenter.Afficher("Opération " + nombre + " :");
                AjouterUneOperation();
                finAjout = DisplayCenter.DemanderSiAutreOperation(Textes.AddAnother, ValuesCondition.OneForYesZeroForNo);
                nombre++;
            }
        }

        private static void AjouterUneOperation()
        {
            DisplayCenter.Afficher(Textes.AddPart);
            DisplayCenter.Afficher(Textes.AddAskForDate);
            var date = Convert.ToString(Console.ReadLine());
            var dt2 = DateTime.Parse(date);
            DisplayCenter.Afficher(Textes.AddAskForMontant);
            var value = Console.ReadLine();
            if (value != null)
            {
                var newValue = value.Replace(".", ",");
                var montant = Convert.ToDouble(newValue);
                var regulier = DisplayCenter.GetRegularite(Textes.AddAskForRegularite, ValuesCondition.OneForYesZeroForNo);
                var operationEnCours = new Operation(dt2, montant, regulier);
                _compteEnBanque.Add(operationEnCours);
            }
            else
            {
                DisplayCenter.Afficher(Textes.AddImpossible);
            }
        }

        private static void ListerLesOperations()
        {
            if (_compteEnBanque.Count == 0)
            {
                DisplayCenter.Afficher(Textes.ListPartImpossible);
            }
            else
            {
                DisplayCenter.Afficher(Textes.ListPart);
                foreach (var operation in _compteEnBanque)
                {
                    var operationAvecFormat = operation.ToString();
                    DisplayCenter.Afficher(operationAvecFormat);
                }
            }
            DisplayCenter.Afficher("");
        }
    }
}
