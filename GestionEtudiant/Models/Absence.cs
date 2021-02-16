using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.Models
{
    public class Absence
    {
        public int IdAbsence { get; set; }
        public string MotifAbsence { get; set; }

        public Absence()
        {

        }

        public Absence(int idAbsence)
        {
            IdAbsence = idAbsence;
            MotifAbsence = "retard bus";
        }
    }
}
