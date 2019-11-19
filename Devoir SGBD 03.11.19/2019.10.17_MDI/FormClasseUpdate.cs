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
    public partial class FormClasseUpdate : Form
    {
        public FormClasseUpdate()
        {
            InitializeComponent();
        }

        private void FormClasseUpdate_Load(object sender, EventArgs e)
        {
            getClassesNames();
            cb_ClasseExistante.SelectedIndex = 0;
        }

        private void getClassesNames ()
        {
            cb_ClasseExistante.Items.Clear();

            try
            {
                MDI_DB.Classe oClasse = new MDI_DB.Classe();
                foreach (MDI_Modeles.ModeleClasse obj in oClasse.Classe_SelectAll())
                {
                    cb_ClasseExistante.Items.Add(obj.Lib);
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
            tb_NewLibelle.Text = "";
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            if (tb_NewLibelle.Text != "" && tb_NewLibelle.Text.Length <= 50)
            {
                try
                {
                    MDI_DB.Classe oClasse = new MDI_DB.Classe();
                    oClasse.Classe_Update(cb_ClasseExistante.Items[cb_ClasseExistante.SelectedIndex].ToString(), tb_NewLibelle.Text);
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
            else if (tb_NewLibelle.Text == "")
            {
                MessageBox.Show("Aucun libellé n'a été encodé");
            }
            else
            {
                MessageBox.Show("Le libellé est trop long, la longueur maximum est de 50 caractères");
            }
            getClassesNames();
        }
    }
}
