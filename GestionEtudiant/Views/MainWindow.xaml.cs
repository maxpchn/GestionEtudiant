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
            Business.MainWindowBusiness windowBusiness = new Business.MainWindowBusiness();

            this.DataContext = windowBusiness;

        }
        public List<Models.Etudiant> lstEtudiant = new List<Models.Etudiant>();

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            Models.Etudiant etudiant = new Models.Etudiant("Maxence","Pinchon");
            lstEtudiant.Add(etudiant);
            dgdEtudiant.ItemsSource = lstEtudiant;

        }

        private void btnEditer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {            
        }
    }
}
