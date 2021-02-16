using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEtudiant.Models;

namespace GestionEtudiant.Business
{
    public class MainWindowBusiness
    {
        public string TitleOfMainWindow { get; set; }

        public List<Models.Etudiant> ListOfStudent { get; set; }

        public MainWindowBusiness()
        {
            TitleOfMainWindow = "hello";

            ListOfStudent = new List<Etudiant>();

            for(int i=0; i < 5; i++)
            {
                Etudiant etudiant = new Etudiant();

                etudiant.CIN = "123125";
                etudiant.CNE = "1235646";
                etudiant.Nom = "Pchn" + i;
                etudiant.Prenom = "Maxence" + i;
                ListOfStudent.Add(etudiant);
            }
        }
    }
}
