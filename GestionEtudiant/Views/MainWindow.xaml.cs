using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionEtudiant
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnEditer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {            
        }

        private void btnGestionEtudiant_Click(object sender, RoutedEventArgs e)
        {
            Views.MyUserControls.UCEtudiant uCEtudiant = new Views.MyUserControls.UCEtudiant();

            Business.UcEtudiantBusiness etudiantBusiness = new Business.UcEtudiantBusiness();

            uCEtudiant.DataContext = etudiantBusiness;

            grContent.Children.Clear();
            grContent.Children.Add(uCEtudiant);
        }

        private void btnAbsence_Click(object sender, RoutedEventArgs e)
        {
            Views.MyUserControls.UCAbsence uCAbsence = new Views.MyUserControls.UCAbsence();
            grContent.Children.Clear();
            grContent.Children.Add(uCAbsence);
        }
    }
}
