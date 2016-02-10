namespace Projet.Niveau1.MoneyManagementCorrection.Affichage
{
    public enum Textes
    {
        [TextesDescription("Bonjour !")]
        Welcome,
        [TextesDescription("")]
        Empty,

        [TextesDescription("Menu du logiciel")]
        MenuHome,
        [TextesDescription("1. Lister le détails des opérations")]
        MenuItem1,
        [TextesDescription("2. Ajouter une opération")]
        MenuItem2,
        [TextesDescription("3. Ajouter une opération régulière")]
        MenuItem3,
        [TextesDescription("4. Supprimer une opération")]
        MenuItem4,
        [TextesDescription("5. Vider le compte")]
        MenuItem5,
        [TextesDescription("6. Quitter le logiciel")]
        MenuItem6,

        [TextesDescription("Le compte est vide, merci de passer à la banque")]
        AccountIsEmpty,

        [TextesDescription("Merci de donner des détails afin de trouver la bonne opération : ")]
        AskForAllDetails,
        [TextesDescription("Quel est le montant de la transaction ? ")]
        FindMontant,
        [TextesDescription("Quel est la date de la transaction ? ")]
        FindDate,
        [TextesDescription("Est-ce une opération régulière ? ")]
        FindRegularite,
        [TextesDescription("Supprimer une autre opération ")]
        AskForAnotherToDelete,
        [TextesDescription("Cette opération n'existe pas, merci de recommencer")]
        FindNotFound,

        [TextesDescription("Ajouter une autre opération ")]
        AddAnother,

        [TextesDescription("Début des ajouts")]
        AddsPart,
        [TextesDescription("----- Ajout d'une opération -----")]
        AddPart,
        [TextesDescription("Date de l'opération : ")]
        AddAskForDate,
        [TextesDescription("Montant de l'opération : ")]
        AddAskForMontant,
        [TextesDescription("Opération régulière ")]
        AddAskForRegularite,
        [TextesDescription("Impossible d'ajouter l'opération, merci de recommencer")]
        AddImpossible,

        [TextesDescription("----- Liste des opérations -----")]
        ListPart,
        [TextesDescription("Aucune opération disponible, merci de créditer votre compte")]
        ListPartImpossible
    }
}