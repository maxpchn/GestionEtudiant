using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.Business
{
    public class UcAbsenceBusiness
    {
        public List<Models.Absence> ListOfAbsence { get; set; }

        public UcAbsenceBusiness()
        {
            ListOfAbsence = new List<Models.Absence>();

            for (int i = 0; i < 5; i++)
            {
                Models.Absence absence = new Models.Absence(i);

                ListOfAbsence.Add(absence);
            }
        }
    }
}
