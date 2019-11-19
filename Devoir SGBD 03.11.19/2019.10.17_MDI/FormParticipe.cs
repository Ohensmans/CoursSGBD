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
    public partial class FormParticipe : Form
    {
        private Boolean readable;

        public FormParticipe()
        {
            InitializeComponent();
        }


        private void bt_Read_Click(object sender, EventArgs e)
        {
            getParticipates();
            readable = false;
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (readable)
                {
                    List<dynamic> lparam = new List<dynamic>();
                    
                    for (int i =0; i< dataGrid.CurrentRow.Cells.Count;i++)
                    {
                        lparam.Add(dataGrid.CurrentRow.Cells[i].Value);
                    }

                    MDI_DB.Participe oParticipe = new MDI_DB.Participe();
                    oParticipe.Participe_Delete(lparam[1], lparam[0], lparam[2]);
                    getParticipatesReadable();
                }
                else
                {
                    ModeleParticipe oModele = (ModeleParticipe)dataGrid.CurrentRow.DataBoundItem;
                    MDI_DB.Participe oParticipe = new MDI_DB.Participe();
                    oParticipe.Participe_Delete2(oModele.Stu_Id, oModele.Clas_Id);
                    getParticipates();
                }
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

        private void getParticipates ()
        {
            try
            {
                MDI_DB.Participe oParticipe = new MDI_DB.Participe();
                dataGrid.DataSource = oParticipe.Participe_SelectAll();
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

        private void FormParticipe_Load(object sender, EventArgs e)
        {
            getParticipates();
            readable = false;
        }

        public void getParticipatesReadable()
        {
            try
            {
                MDI_DB.Participe oParticipe = new MDI_DB.Participe();
                MDI_DB.Classe oClasse = new MDI_DB.Classe();
                MDI_DB.Students oStudents = new MDI_DB.Students();

                List<dynamic> lReadable = new List<dynamic>();

                foreach (ModeleParticipe oMPart in oParticipe.Participe_SelectAll())
                {

                    string stuPre = oStudents.Students_SelectOne(oMPart.Stu_Id).Prenom;
                    string stuNom = oStudents.Students_SelectOne(oMPart.Stu_Id).Nom;
                    string claLib = oClasse.Classe_SelectOne(oMPart.Clas_Id).Lib;
                    DateTime lastUpd = oMPart.LastUpd;

                    lReadable.Add(new ModeleParticipeReadable(stuNom,stuPre,claLib,lastUpd));
                }

                dataGrid.DataSource = lReadable;
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

        private void bt_Readable_Click(object sender, EventArgs e)
        {
            readable = true;
            getParticipatesReadable();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParticipeAdd fParticipeAdd = new FormParticipeAdd();
            fParticipeAdd.MdiParent = this.MdiParent;
            fParticipeAdd.Show();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParticipeUpdate fParticipeUpdate = new FormParticipeUpdate();
            fParticipeUpdate.MdiParent = this.MdiParent;
            fParticipeUpdate.Show();
        }
    }
}
