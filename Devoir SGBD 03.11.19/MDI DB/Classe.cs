using MDI_CustomError;
using MDI_Modeles;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI_DB
{
    public class Classe : ServiceClasse
    {

        public int Classe_Add(string pLib)
        {
            _Return = 0;
            try
            {
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@Lib", pLib));
                _Return = MyExecute("Classe_Add", lst);

            }
            catch (BusinessError be)
            {
                throw be;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return _Return;
        }

        public int Classe_Delete(string pLib)
        {
            _Return = 0;
            try
            {
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@Libelle", pLib));
                _Return = MyExecute("Classe_Delete", lst);

            }
            catch (BusinessError be)
            {
                throw be;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return _Return;
        }

        public int Classe_Update(string pLibOld, string pLibNew)
        {
            _Return = 0;
            try
            {
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@Lib_Old", pLibOld));
                lst.Add(new SqlParameter("@Lib_New", pLibNew));
                _Return = MyExecute("Classe_Update", lst);
            }
            catch (BusinessError be)
            {
                throw be;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return _Return;
        }

        public List<dynamic> Classe_SelectAll()
        {
            List<dynamic> lModele = new List<dynamic>();
            try
            {
                string pTab = "Classe";
                return MyExecuteSelect("Classe_SelectAll", pTab);
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

        public dynamic Classe_SelectOne(int id)
        {
            try
            {
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("Cla_Id",id));
                string pTab = "Classe";
                return MyExecuteSelectOne("Classe_GetNames", pTab, lst);
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
