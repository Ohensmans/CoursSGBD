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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void régionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTerritoires oForm = new FormTerritoires();
            oForm.MdiParent = this;

            oForm.Show();
        }
    }
}
