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
    public partial class FormParticipeUpdate : Form
    {
        private List<string> lClasse = new List<string>();

        public FormParticipeUpdate()
        {
            InitializeComponent();
        }

        private void FormParticipeUpdate_Load(object sender, EventArgs e)
        {
            getListed();            
        }

        private void getListed()
        {
            try
            {
                MDI_DB.Participe oParticipe = new MDI_DB.Participe();
                MDI_DB.Classe oClasse = new MDI_DB.Classe();
                MDI_DB.Students oStudents = new MDI_DB.Students();

                List<string> lEtudiant = new List<string>();
                lClasse.Clear();
                cb_Etudiant.Items.Clear();

                foreach (ModeleParticipe oMPart in oParticipe.Participe_SelectAll())
                {

                    string stuPre = oStudents.Students_SelectOne(oMPart.Stu_Id).Prenom;
                    string stuNom = oStudents.Students_SelectOne(oMPart.Stu_Id).Nom;
                    string claLib = oClasse.Classe_SelectOne(oMPart.Clas_Id).Lib;

                    cb_Etudiant.Items.Add(stuPre + " - " + stuNom);
                    lClasse.Add(claLib);
                }

                getClasses();

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

        private void cb_Etudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            l_NomClasseEnCours.Text = lClasse[cb_Etudiant.SelectedIndex];
        }

        private void getClasses()
        {
            cb_Classe.Items.Clear();

            try
            {
                MDI_DB.Classe oClasse = new MDI_DB.Classe();
                foreach (MDI_Modeles.ModeleClasse obj in oClasse.Classe_SelectAll())
                {
                    cb_Classe.Items.Add(obj.Lib);
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

        private void bt_Update_Click(object sender, EventArgs e)
        {

            if (cb_Etudiant.SelectedIndex>=0)
            {
                if(cb_Classe.SelectedIndex>=0)
                {
                    if (!(cb_Classe.Items[cb_Classe.SelectedIndex].ToString().Equals(l_NomClasseEnCours.Text)))
                    {
                        try
                        {
                            int decoupe = cb_Etudiant.Items[cb_Etudiant.SelectedIndex].ToString().IndexOf("-");
                            string prenom = cb_Etudiant.Items[cb_Etudiant.SelectedIndex].ToString().Substring(0, (decoupe - 1));
                            string nom = cb_Etudiant.Items[cb_Etudiant.SelectedIndex].ToString().Substring(decoupe + 2);
                            string libelle = cb_Classe.Items[cb_Etudiant.SelectedIndex].ToString();

                            MDI_DB.Participe oParticipe = new MDI_DB.Participe();
                            oParticipe.Participe_Update(nom,prenom,l_NomClasseEnCours.Text,nom,prenom,libelle);
                            MessageBox.Show(nom + " " + prenom + " a bien été déplacé dans la classe " + libelle);
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
                    else
                    {
                        MessageBox.Show("la classe n'a pas changé, veuillez vérifier");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une Classe");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant");
            }

            getListed();
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
