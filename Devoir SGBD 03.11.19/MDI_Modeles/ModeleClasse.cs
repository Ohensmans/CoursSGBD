using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI_Modeles
{
    public class ModeleClasse : ModeleSchool
    {
        public ModeleClasse()
        {
        }

        public ModeleClasse(string lib, int id, DateTime lupd)
        {
            Id = id;
            Lib = lib;
            LastUpd = lupd;
        }

        public int Id { get; set; }
        public string Lib { get; set; }
        public DateTime LastUpd { get; set; }

        public new ModeleClasse Init (List<dynamic> lDyn)
        {
            return new ModeleClasse(lDyn[0], lDyn[1], lDyn[2]);
        }

    }

}
