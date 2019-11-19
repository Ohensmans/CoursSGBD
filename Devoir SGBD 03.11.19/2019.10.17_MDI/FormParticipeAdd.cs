using MDI_CustomError;
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
    public partial class FormParticipeAdd : Form
    {
        public FormParticipeAdd()
        {
            InitializeComponent();
        }

        private void FormParticipeAdd_Load(object sender, EventArgs e)
        {
            getClasses();
            getEtudiants();
        }

        private void getEtudiants()
        {
            cb_Etudiant.Items.Clear();

            try
            {
                MDI_DB.Students oStudents = new MDI_DB.Students();
                foreach (MDI_Modeles.ModeleEtudiant stu in oStudents.Students_SelectAll())
                {
                    string nomFull = stu.Prenom + " - " + stu.Nom;
                    cb_Etudiant.Items.Add(nomFull);
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

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (cb_Classe.SelectedIndex >= 0)
            {

                if (cb_Etudiant.SelectedIndex >= 0)
                {
                    int decoupe = cb_Etudiant.Items[cb_Etudiant.SelectedIndex].ToString().IndexOf("-");
                    string prenom = cb_Etudiant.Items[cb_Etudiant.SelectedIndex].ToString().Substring(0, (decoupe - 1));
                    string nom = cb_Etudiant.Items[cb_Etudiant.SelectedIndex].ToString().Substring(decoupe + 2);
                    string libelle = cb_Classe.Items[cb_Etudiant.SelectedIndex].ToString();

                    try
                    {
                        MDI_DB.Participe oParticipe = new MDI_DB.Participe();
                        oParticipe.Participe_Add(nom, prenom, libelle);
                        MessageBox.Show(nom + " " + prenom+" a bien été inscrit dans la classe " + libelle);
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
                    MessageBox.Show("Veuillez sélectionner un étudiant");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une classe");
            }

        }
        }
    }

