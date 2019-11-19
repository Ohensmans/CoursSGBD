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
    public class Participe : ServiceClasse
    {
        public int Participe_Add(string nom, string prenom, string libelle)
        {
            _Return = 0;
            try
            {
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@Nom", nom));
                lst.Add(new SqlParameter("@Prenom", prenom));
                lst.Add(new SqlParameter("@Libelle", libelle));
                _Return = MyExecute("Participe_Add", lst);

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

        public int Participe_Delete(string nom, string prenom, string libelle)
        {
            _Return = 0;
            try
            {
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@Nom", nom));
                lst.Add(new SqlParameter("@Prenom", prenom));
                lst.Add(new SqlParameter("@Libelle", libelle));
                _Return = MyExecute("Participe_Delete", lst);

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

        public int Participe_Delete2(Guid studentId, int ClassID)
        {
            _Return = 0;
            try
            {
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@Stu_id", studentId));
                lst.Add(new SqlParameter("@Clas_Id", ClassID));
                _Return = MyExecute("Participe_Delete2", lst);

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

        public int Participe_Update(string nomOld, string prenomOld, string libelleOld, string nomNew, string prenomNew, string libelleNew)
        {
            _Return = 0;
            try
            {
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@NomOld", nomOld));
                lst.Add(new SqlParameter("@PrenomOld", prenomOld));
                lst.Add(new SqlParameter("@LibelleOld", libelleOld));
                lst.Add(new SqlParameter("@NomNew", nomNew));
                lst.Add(new SqlParameter("@PrenomNew", prenomNew));
                lst.Add(new SqlParameter("@LibelleNew", libelleNew));
                _Return = MyExecute("Participe_Update", lst);
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

        public List<dynamic> Participe_SelectAll()
        {
            List<dynamic> lModele = new List<dynamic>();
            try
            {
                string pTab = "Participe";
                return MyExecuteSelect("Participe_SelectAll", pTab);
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
