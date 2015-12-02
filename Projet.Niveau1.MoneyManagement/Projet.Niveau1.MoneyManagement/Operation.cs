using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Niveau1.MoneyManagement
{
    class Operation
    {
        private DateTime dateOperation;
        private int montant;
        private bool reguliere;

        public Operation(DateTime date, int montant, bool reguliere)
        {
            dateOperation = date;
            this.montant = montant;
            this.reguliere = reguliere;
        }

        public override string ToString()
        {
            return dateOperation + "-" + montant;
        }

        public override bool Equals(object obj)
        {
            Operation demo = obj as Operation;
            return demo != null && (demo.montant == this.montant && demo.dateOperation == this.dateOperation &&
                                    demo.reguliere == this.reguliere);
        }

        public void GetMontant()
        {
            Affichage.Afficher("2. Quel est le montant de la transaction ? (-1 pour ne sais plus)");
            montant = 1;
        }

        public void GetDate()
        {
            Affichage.Afficher("2. Quel est la date de la transaction ? (-1 pour ne sais plus)");
        }

        public void GetRegularite()
        {
            Affichage.Afficher("1. Est-ce une opération régulière ? (0 pour oui, 1 pour non, 2 pour ne sais plus");
        }
    }
}
