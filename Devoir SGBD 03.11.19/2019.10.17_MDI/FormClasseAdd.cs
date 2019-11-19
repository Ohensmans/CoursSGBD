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
    public partial class FormClasseAdd : Form
    {
        public FormClasseAdd()
        {
            InitializeComponent();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            if( tb_NewLibelle.Text != "" && tb_NewLibelle.Text.Length<=50)
            {
                try
                {
                    MDI_DB.Classe oClasse = new MDI_DB.Classe();
                    oClasse.Classe_Add(tb_NewLibelle.Text);
                    tb_NewLibelle.Text = "";
                    MessageBox.Show("La nouvelle classe a bien été créée");
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
            else if (tb_NewLibelle.Text =="")
            {
                MessageBox.Show("Aucun libellé n'a été encodé");
            }
            else
            {
                MessageBox.Show("Le libellé est trop long, la longueur maximum est de 50 caractères");
            }

        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
