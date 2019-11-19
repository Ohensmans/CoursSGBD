using MDI_CustomError;
using MDI_Modeles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _2019._10._17_MDI
{
    public partial class FormClasse : Form
    {
        public FormClasse()
        {
            InitializeComponent();
        }

        private void bt_Read_Click(object sender, EventArgs e)
        {
            getClasses();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ModeleClasse oModele = (ModeleClasse)dataGrid.CurrentRow.DataBoundItem;
                MDI_DB.Classe oClasse = new MDI_DB.Classe();
                oClasse.Classe_Delete(oModele.Lib);
                getClasses();
            }
            catch (BusinessError be)
            {
                MessageBox.Show(be.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClasseAdd fClasseAdd = new FormClasseAdd();
            fClasseAdd.MdiParent = this.MdiParent;
            fClasseAdd.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClasseUpdate fClasseUpdate = new FormClasseUpdate();
            fClasseUpdate.MdiParent = this.MdiParent;
            fClasseUpdate.Show();
        }

        private void FormClasse_Load(object sender, EventArgs e)
        {
            getClasses();
        }

        private void getClasses()
        {
            try
            {
                MDI_DB.Classe oClasse = new MDI_DB.Classe();
                dataGrid.DataSource = oClasse.Classe_SelectAll();
            }
            catch (BusinessError be)
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
