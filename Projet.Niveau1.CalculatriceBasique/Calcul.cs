namespace Projet.Niveau1.CalculatriceBasique
{
    public class Calcul
    {
        private readonly int premierChiffre;
        private readonly int secondChiffre;

        public Calcul(int premierChiffre, int secondChiffre)
        {
            this.premierChiffre = premierChiffre;
            this.secondChiffre = secondChiffre;
        }

        public int addition()
        {
            return premierChiffre + secondChiffre;
        }
    }
}