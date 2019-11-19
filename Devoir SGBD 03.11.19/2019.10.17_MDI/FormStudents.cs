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
    public partial class FormStudents : Form
    {
        public FormStudents()
        {
            InitializeComponent();
        }

        private void bt_Read_Click(object sender, EventArgs e)
        {
            getStudents();
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            getStudents();
        }

        private void getStudents()
        {
            try
            {
                MDI_DB.Students oStudents = new MDI_DB.Students();
                dataGrid.DataSource = oStudents.Students_SelectAll();
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudentsAdd fStudentsAdd = new FormStudentsAdd();
            fStudentsAdd.MdiParent = this.MdiParent;
            fStudentsAdd.Show();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudentsUpdate fStudentsUpdate = new FormStudentsUpdate();
            fStudentsUpdate.MdiParent = this.MdiParent;
            fStudentsUpdate.Show();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ModeleEtudiant oModele = (ModeleEtudiant)dataGrid.CurrentRow.DataBoundItem;
                MDI_DB.Students oStudents = new MDI_DB.Students();
                oStudents.Students_Delete(oModele.Nom, oModele.Prenom);
            }
            catch (BusinessError be)
            {
                MessageBox.Show(be.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            getStudents();
        }
    }
}
