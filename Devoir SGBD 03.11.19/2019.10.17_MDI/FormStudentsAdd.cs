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
    public partial class FormStudentsAdd : Form
    {
        public FormStudentsAdd()
        {
            InitializeComponent();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (tb_NewNom.Text != "" && tb_NewNom.Text.Length <= 50)
            {
                if (tb_NewPrenom.Text != "" && tb_NewPrenom.Text.Length <= 50)
                {
                    try
                    {
                        MDI_DB.Students oStudents = new MDI_DB.Students();
                        oStudents.Students_Add(tb_NewNom.Text, tb_NewPrenom.Text);
                        tb_NewNom.Text = "";
                        tb_NewPrenom.Text = "";
                        MessageBox.Show("La nouvel étudiant a bien été créé");
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
                else if (tb_NewPrenom.Text == "")
                {
                    MessageBox.Show("Aucun prénom n'a été encodé");
                }
                else
                {
                    MessageBox.Show("Le prénom est trop long, la longueur maximum est de 50 caractères");
                }
            }
            else if (tb_NewNom.Text == "")
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
