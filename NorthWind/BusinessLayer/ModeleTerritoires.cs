using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ModeleTerritoires : Modele
    {
        public ModeleTerritoires()
        {
            oData = new DataAcces.DataTerritoire();
        }


    }
}
