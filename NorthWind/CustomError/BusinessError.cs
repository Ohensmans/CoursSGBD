using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomError
{
    public class BusinessError : Exception
    {
        private string _Message;

        public BusinessError(SqlException sqlex)
        {
            this._Message = sqlex.Message;
        }

        public override string Message
        {
            get { return _Message; }
        }
    }
}
