using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.Models
{
    public class Etudiant
    {

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string CIN { get; set; }
        public string CNE { get; set; }
        public DateTime DateNaissance { get; set; }

        public Etudiant()
        {
            
        }

        public Etudiant(string nom)
        {
            this.Nom = nom;
        }
        public Etudiant(string nom, string prenom)
        {
            this.Nom = nom;
            this.Nom = prenom;
        }


    }
}
