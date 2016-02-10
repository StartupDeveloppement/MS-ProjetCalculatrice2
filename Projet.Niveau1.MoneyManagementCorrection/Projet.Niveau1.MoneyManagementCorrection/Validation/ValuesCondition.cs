namespace Projet.Niveau1.MoneyManagementCorrection.Validation
{
    public enum ValuesCondition
    {
        [ParametersDescription(new[] { 0, 1, -1}, "(1 pour oui, 0 pour non, -1 pour ne sais plus)")]
        AbcOneTwoThree,
        [ParametersDescription(new[] { 0, 1}, "(1 pour oui, 0 pour non)")]
        OneForYesZeroForNo,
        [ParametersDescription(new[] { -1 }, "(-1 pour ne sais plus)")]
        LessThanOne
    }
}