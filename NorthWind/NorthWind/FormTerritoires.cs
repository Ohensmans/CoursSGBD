using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind
{
    public partial class FormTerritoires : Form
    {
        public FormTerritoires()
        {
            InitializeComponent();
        }

        private void FormTerritoires_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void bt_LoadAll_Click(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void LoadAllData()
        {
            try
            {
                BusinessLayer.ModeleTerritoires oTerritoire = new BusinessLayer.ModeleTerritoires();
                dataGrid.DataSource = oTerritoire.LoadAllData();

            }
            catch (CustomError.BusinessError be)
            {
                MessageBox.Show(be.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_SaveAll_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.ModeleTerritoires oTerritoire = new BusinessLayer.ModeleTerritoires();
                oTerritoire.SaveAll((DataView)dataGrid.DataSource);
                LoadAllData();
            }
            catch (CustomError.BusinessError be)
            {
                MessageBox.Show(be.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
