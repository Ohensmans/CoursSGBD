using MDI_CustomError;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDI_Modeles;

namespace MDI_DB
{
    public class ServiceClasse
    {
        protected String _Connection = "Server=(local);Database=School;User Id=sa;Password=ephec";
        public List<dynamic> lRead;
        public int _Return;

        public int MyExecute(string pStoredName, List<SqlParameter> lstParam)
        {
            _Return = 0;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = _Connection;

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "secretariat."+pStoredName;
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter oParam in lstParam)
                {
                    cmd.Parameters.Add(oParam);
                }

                cmd.Connection = con ;
                _Return = cmd.ExecuteNonQuery();

                con.Close();

            }

            catch (SqlException exsql)
            {
                BusinessError oErreur = new BusinessError(exsql);
                throw oErreur;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return _Return;
        }

        public List<dynamic> MyExecuteSelect (string pStoredName, string pTab)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = _Connection;
            SqlDataReader oReader;
            List<dynamic> lModele = new List<dynamic>();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                

                cmd.CommandText = "secretariat." + pStoredName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                oReader = cmd.ExecuteReader();

                while(oReader.Read())
                {


                    List<dynamic> lParam = new List<dynamic>();

                    for(int i = 0; i<oReader.FieldCount;i++)
                    {
                        lParam.Add(oReader.GetValue(i));
                    }

                    if (pTab == "Classe")
                    {
                        ModeleClasse oModele = new ModeleClasse();
                        lModele.Add(oModele.Init(lParam));
                    }
                    else if (pTab == "Students")
                    {
                        ModeleEtudiant oModele = new ModeleEtudiant();
                        lModele.Add(oModele.Init(lParam));
                    }
                    else
                    {
                        ModeleParticipe oModele = new ModeleParticipe();
                        lModele.Add(oModele.Init(lParam));
                    }
                    
                    
                }

                con.Close();

            }

            catch (SqlException exsql)
            {
                BusinessError oErreur = new BusinessError(exsql);
                throw oErreur;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return lModele;
        }

        public dynamic MyExecuteSelectOne(string pStoredName, string pTab, List<SqlParameter> lstParamIn)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = _Connection;
            SqlDataReader oReader;
            dynamic oDyn = null;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();


                cmd.CommandText = "secretariat." + pStoredName;
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter oParam in lstParamIn)
                {
                    cmd.Parameters.Add(oParam);
                }

                cmd.Connection = con;

                oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    List<dynamic> lParam = new List<dynamic>();

                    for (int i = 0; i < oReader.FieldCount; i++)
                    {
                        lParam.Add(oReader.GetValue(i));
                    }

                    if (pTab == "Classe")
                    {
                        ModeleClasse oModele = new ModeleClasse();
                        oDyn = oModele.Init(lParam);
                    }
                    else
                    {
                        ModeleEtudiant oModele = new ModeleEtudiant();
                        oDyn = oModele.Init(lParam);
                    }

                }

                con.Close();

            }

            catch (SqlException exsql)
            {
                BusinessError oErreur = new BusinessError(exsql);
                throw oErreur;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return oDyn;
        }

    }
}
