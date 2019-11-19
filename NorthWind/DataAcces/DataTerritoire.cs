using CustomError;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public class DataTerritoire : Data
    {
        public DataTerritoire()
        {
            Call = "Territories";
            NameTable = "Territory";
        }

        public int Add(List<dynamic> lst)
        {
            try
            {
                List<SqlParameter> lstSqlParam = new List<SqlParameter>();

                lstSqlParam.Add(new SqlParameter("@TerritoryID", lst[0]));
                lstSqlParam.Add(new SqlParameter("@TerritoryDescription", lst[1]));
                lstSqlParam.Add(new SqlParameter("@RegionID", lst[2]));
                return Execute(lstSqlParam, "Add");

            }
            catch (BusinessError be)
            {
                throw be;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Update(List<dynamic> lst)
        {
            try
            {
                List<SqlParameter> lstSqlParam = new List<SqlParameter>();

                lstSqlParam.Add(new SqlParameter("@OldTerritoryID", lst[0]));
                lstSqlParam.Add(new SqlParameter("@NewTerritoryID", lst[1]));
                lstSqlParam.Add(new SqlParameter("@TerritoryDescription", lst[2]));
                lstSqlParam.Add(new SqlParameter("@RegionID", lst[3]));
                return Execute(lstSqlParam, "Update");

            }
            catch (BusinessError be)
            {
                throw be;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
