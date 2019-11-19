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
    public partial class FormStudentsUpdate : Form
    {
        public FormStudentsUpdate()
        {
            InitializeComponent();
        }

        private void FormStudentsUpdate_Load(object sender, EventArgs e)
        {
            getStudentsNames();
        }

        private void getStudentsNames()
        {
            cb_Students.Items.Clear();

            try
            {
                MDI_DB.Students oStudents = new MDI_DB.Students();
                foreach (MDI_Modeles.ModeleEtudiant stu in oStudents.Students_SelectAll())
                {
                    string nomFull = stu.Prenom + " - " + stu.Nom;
                    cb_Students.Items.Add(nomFull);
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

            tb_NewName.Text ="";
            tb_NewPrenom.Text = "";
        }

        private void cb_Students_SelectedIndexChanged(object sender, EventArgs e)
        {
            int decoupe = cb_Students.Items[cb_Students.SelectedIndex].ToString().IndexOf("-");
            tb_NewPrenom.Text = cb_Students.Items[cb_Students.SelectedIndex].ToString().Substring(0, (decoupe - 1));
            tb_NewName.Text = cb_Students.Items[cb_Students.SelectedIndex].ToString().Substring(decoupe + 2);
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            if (tb_NewName.Text != "" && tb_NewName.Text.Length <= 50)
            {
                if (tb_NewPrenom.Text != "" && tb_NewPrenom.Text.Length <= 50)
                {
                    int decoupe = cb_Students.Items[cb_Students.SelectedIndex].ToString().IndexOf("-");
                    string oldPrenom = cb_Students.Items[cb_Students.SelectedIndex].ToString().Substring(0, (decoupe - 1));
                    string oldName = cb_Students.Items[cb_Students.SelectedIndex].ToString().Substring(decoupe + 2);

                    if (tb_NewPrenom.Text != oldPrenom || tb_NewName.Text != oldName)
                    {
                        try
                        {
                            MDI_DB.Students oStudents = new MDI_DB.Students();
                            oStudents.Students_UpdateNom(oldName, oldPrenom, tb_NewName.Text);
                            oStudents.Students_UpdatePrenom(tb_NewName.Text, oldPrenom, tb_NewPrenom.Text);
                            MessageBox.Show(oldPrenom+" "+oldName+" a bien été changé en "+tb_NewPrenom.Text+" "+tb_NewName.Text);
                            getStudentsNames();
                            
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
                        MessageBox.Show("Aucun changement n'a été apporté");
                    }
                }
                else if (tb_NewPrenom.Text == "")
                {
                    MessageBox.Show("Aucun prénom n'a été encodé");
                }
                else
                {
                    MessageBox.Show("Le prénom est trop long, la longueur maximum est de 50 caractères");
                }
            }
            else if (tb_NewName.Text == "")
            {
                MessageBox.Show("Aucun nom n'a été encodé");
            }
            else
            {
                MessageBox.Show("Le nom est trop long, la longueur maximum est de 50 caractères");
            }
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
