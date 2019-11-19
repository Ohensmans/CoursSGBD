using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public class Data
    {
        protected string _Connection = "Server=(local);Database=NorthWind;User Id=sa;Password =ephec;";

        protected string Call;
        protected string NameTable;

        public DataSet LoadData(out string callOut)
        {
            try
            {
                using (SqlConnection oCon = new SqlConnection())
                {
                    oCon.ConnectionString = _Connection;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand oSelect = new SqlCommand();

                    oSelect.Connection = oCon;
                    oSelect.CommandText = "Select * from " + Call;
                    oSelect.CommandType = CommandType.Text;

                    adapter.SelectCommand = oSelect;

                    DataSet data = new DataSet();

                    callOut = "My" + Call;
                    adapter.Fill(data, callOut);

                    return data;
                }
            }
            catch (SqlException exsql)
            {
                CustomError.BusinessError be = new CustomError.BusinessError(exsql);
                throw be;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public int Delete (dynamic pId)
        {
            try
            {
                using (SqlConnection oCon = new SqlConnection())
                {
                    oCon.ConnectionString = _Connection;
                    using (SqlCommand oSql = new SqlCommand())
                    {
                        oSql.Connection = oCon;
                        oSql.CommandText = "Delete from " + Call +" where "+NameTable+"ID = @id";
                        oSql.CommandType = CommandType.Text;
                        
                        SqlParameter oParam = new SqlParameter("@id", pId);
                        oSql.Parameters.Add(oParam);

                        oSql.Connection.Open();
                        return oSql.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException exsql)
            {
                CustomError.BusinessError be = new CustomError.BusinessError(exsql);
                throw be;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Execute(List<SqlParameter> lstParam, string pProcedureType)
        {
            try
            {
                using (SqlConnection oCon = new SqlConnection())
                {
                    oCon.ConnectionString = _Connection;
                    using (SqlCommand oSql = new SqlCommand())
                    {
                        oSql.Connection = oCon;
                        oSql.CommandText = "secretariat."+Call+"_"+ pProcedureType;
                        oSql.CommandType = CommandType.StoredProcedure;

                        foreach (SqlParameter oParam in lstParam)
                        {
                            oSql.Parameters.Add(oParam);
                        }                       

                        oSql.Connection.Open();
                        return oSql.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException exsql)
            {
                CustomError.BusinessError be = new CustomError.BusinessError(exsql);
                throw be;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
