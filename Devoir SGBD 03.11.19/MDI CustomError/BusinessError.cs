using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI_CustomError

{
    public enum MyLangue
    {
        FR=0, NL=1, EN=2
    }


    public class BusinessError : Exception
    {
        private string _Message;
        private int _Number = -1;

        public BusinessError (SqlException exsql)
        {
            try
            {
                switch (exsql.Number)
                {

                    case 18054:
                        _Number = 1;
                        // J'ai essaye de joindre mes raisserror avec de .Class et des .State mais cela ne fonctionne pas. J'aimerai savoir comment faire les liens
                        break;
                    default:
                        _Message = exsql.Message + " -- " + exsql.Number;
                        break;

                }
            }
            catch (Exception e)
            {
                throw e;
            }
           
        }


        public override string Message
        {
            get { return _Message; }
        }

        public int Number
        {
            get { return _Number; }
        }



    }
}
