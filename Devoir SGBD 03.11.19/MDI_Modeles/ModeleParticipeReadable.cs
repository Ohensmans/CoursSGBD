using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI_Modeles
{
    public class ModeleParticipeReadable
    {
        public ModeleParticipeReadable()
        {
        }

        public ModeleParticipeReadable (string stuNom, string stuPre, string clasLib, DateTime lastUpd)
        {
            StuPre = stuPre;
            StuNom = stuNom;
            ClasLib = clasLib;
            LastUpd = lastUpd;

        }

        public string StuPre { get; set; }
        public string StuNom { get; set; }
        public string ClasLib { get; set; }
        public DateTime LastUpd { get; set; }

    }
}
