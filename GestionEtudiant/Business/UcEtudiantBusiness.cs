using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEtudiant.Models;

namespace GestionEtudiant.Business
{
    public class UcEtudiantBusiness
    {

        public List<Etudiant> ListOfStudent { get; set; }
        public UcEtudiantBusiness()
        {
            ListOfStudent = new List<Etudiant>();
            for (int i = 0; i < 5; i++)
            {
                Etudiant etudiant = new Etudiant();
                etudiant.CIN = "1231361";
                etudiant.CNE = "23262";
                etudiant.Prenom = "Maxence" + i;
                etudiant.Nom = "Pchn" + i;

                ListOfStudent.Add(etudiant);
            }
        }
    }
}
