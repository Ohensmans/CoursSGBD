using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BusinessLayer
{
    public class Modele
    {
        protected dynamic oData;
        protected string call;

        public DataView LoadAllData()
        {
            try
            {
                return oData.LoadData(out call).Tables[call].DefaultView;
            }
            catch (CustomError.BusinessError be)
            {
                throw be;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SaveAll(DataView oView)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {

                    DeleteAll(oView);

                    AddAll(oView);

                    UpdateAll(oView);

                    scope.Complete();
                }

            }
            catch (CustomError.BusinessError be)
            {
                throw be;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void DeleteAll(DataView oView)
        {
            try
            {
                oView.RowStateFilter = DataViewRowState.Deleted;

                if (oView.Count > 0)
                {

                    foreach (DataRowView rowView in oView)
                    {
                        oData.Delete(rowView[0]);
                    }
                }
            }
            catch (CustomError.BusinessError be)
            {
                throw be;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddAll(DataView oView)
        {
            try
            {
                oView.RowStateFilter = DataViewRowState.Added;
                if (oView.Count > 0)
                {
                    foreach (DataRowView rowView in oView)
                    {
                        List<dynamic> lst = new List<dynamic>();

                        for (int i = 0; i < rowView.Row.Table.Columns.Count; i++)
                        {
                            lst.Add(rowView[i]);
                        }

                        oData.Add(lst);
                    }
                }
            }
            catch (CustomError.BusinessError be)
            {
                throw be;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateAll(DataView oView)
        {
            try
            {
                oView.RowStateFilter = DataViewRowState.ModifiedOriginal;
                if (oView.Count > 0)
                {
                    
                    List<dynamic> lstOld = new List<dynamic>();

                    foreach (DataRowView rowView in oView)
                    {
                        lstOld.Add(rowView[0]);
                    }

                    oView.RowStateFilter = DataViewRowState.ModifiedCurrent;
                    List<dynamic> lst = new List<dynamic>();
                    int j = 0;

                    foreach (DataRowView rowView in oView)
                    {
                        lst.Add(lstOld[j]);

                        for (int i = 0; i < rowView.Row.Table.Columns.Count; i++)
                        {
                            lst.Add(rowView[i]);
                        }
                        j++;
                    }

                    oData.Update(lst);
                }

            }
            catch (CustomError.BusinessError be)
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
