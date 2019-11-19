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
    public class Students : ServiceClasse
    {

        public int Students_Add(string nom, string prenom)
        {
            _Return = 0;
            try
            {
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@Nom", nom));
                lst.Add(new SqlParameter("@Prenom", prenom));
                _Return = MyExecute("Students_Add", lst);

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

        public int Students_Delete(string nom, string prenom)
        {
            _Return = 0;
            try
            {
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@Nom", nom));
                lst.Add(new SqlParameter("@Prenom", prenom));
                _Return = MyExecute("Students_Delete", lst);

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

        public int Students_UpdateNom(string NomOld, string PrenomOld, string NomNew)
        {
            _Return = 0;
            try
            {
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@Nom_Old", NomOld));
                lst.Add(new SqlParameter("@Prenom_Old", PrenomOld));
                lst.Add(new SqlParameter("@Nom_New", NomNew));
                _Return = MyExecute("Students_Update_Nom", lst);
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

        public int Students_UpdatePrenom(string NomOld, string PrenomOld, string PrenomNew)
        {
            _Return = 0;
            try
            {
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@Nom_Old", NomOld));
                lst.Add(new SqlParameter("@Prenom_Old", PrenomOld));
                lst.Add(new SqlParameter("@Prenom_New", PrenomNew));
                _Return = MyExecute("Students_Update_Prenom", lst);
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

        public List<dynamic> Students_SelectAll()
        {
            List<dynamic> lModele = new List<dynamic>();
            try
            {
                string pTab = "Students";
                return MyExecuteSelect("Students_SelectAll", pTab);
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

        public dynamic Students_SelectOne(Guid id)
        {
            try
            {
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("Stu_Id", id));
                string pTab = "Students";
                return MyExecuteSelectOne("Students_GetNames", pTab, lst);
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
