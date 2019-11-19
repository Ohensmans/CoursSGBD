using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI_Modeles
{
    public class ModeleParticipe : ModeleSchool
    {
        public ModeleParticipe()
        {
        }

        public ModeleParticipe(Guid stu_Id, int clas_Id, DateTime lUpd)
        {
            Stu_Id = stu_Id;
            Clas_Id = clas_Id;
            LastUpd = lUpd;
        }

        public Guid Stu_Id { get; set; }
        public int Clas_Id { get; set; }
        public DateTime LastUpd { get; set; }

        public new ModeleParticipe Init (List<dynamic> lDyn)
        {
            return new ModeleParticipe(lDyn[0], lDyn[1], lDyn[2]);
        }
    }
}
