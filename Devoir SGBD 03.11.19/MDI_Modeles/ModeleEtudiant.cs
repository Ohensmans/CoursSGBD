using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI_Modeles
{
    public class ModeleEtudiant : ModeleSchool
    {
        public ModeleEtudiant()
        {
        }

        public ModeleEtudiant(string nom, string prenom, Guid stu_Id, DateTime lUpdt)
        {
            Nom = nom;
            Prenom = prenom;
            Stu_Id = stu_Id;
            LastUpd = lUpdt;
        }

        public string Nom{ get; set; }
        public string Prenom { get; set; }
        public Guid Stu_Id { get; set; }
        public DateTime LastUpd { get; set; }

        public new ModeleEtudiant Init (List<dynamic> lDyn)
        {
            return new ModeleEtudiant(lDyn[0], lDyn[1], lDyn[2], lDyn[3]);
        }
    }
}
