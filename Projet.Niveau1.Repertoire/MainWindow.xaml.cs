using System.Collections.ObjectModel;
using System.Windows;

namespace Projet.Niveau1.Repertoire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        private ObservableCollection<Personne> ListePersonnes { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            InstanciationObjets();   
            InitialisationBindings();   
        }

        /// <summary>
        /// Initialisation des objets
        /// </summary>
        private void InstanciationObjets()
        {
            ListePersonnes = new ObservableCollection<Personne>();
        }

        /// <summary>
        /// Initialisation des bindings avec le XAML
        /// </summary>
        private void InitialisationBindings()
        {            
            GrillePersonnes.ItemsSource = ListePersonnes;
        }

        /// <summary>
        /// Permet d'ajouter une personne
        /// </summary>
        /// <param name="sender">Le bouton ajouter</param>
        /// <param name="e"></param>
        private void ButtonAjouter_Click(object sender, RoutedEventArgs e)
        {
            Personne personne = new Personne();
            personne.nom = ChampNom.Text;
            personne.prenom = ChampPrenom.Text;            
            ListePersonnes.Add(personne);
        }

        /// <summary>
        /// Supprime le derniere élément ajoué
        /// </summary>
        /// <param name="sender">Le bouton supprimer</param>
        /// <param name="e"></param>
        private void ButtonTest_Click(object sender, RoutedEventArgs e)
        {
            if (ListePersonnes.Count > 0)
                ListePersonnes.RemoveAt(ListePersonnes.Count-1);
        }
    }
}
