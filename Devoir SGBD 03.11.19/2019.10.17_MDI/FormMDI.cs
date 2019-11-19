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
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {

        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClasse fClasse = new FormClasse();
            fClasse.MdiParent = this;
            fClasse.Show();

        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudents fStudents = new FormStudents();
            fStudents.MdiParent = this;
            fStudents.Show();
        }

        private void participeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParticipe fParticipe = new FormParticipe();
            fParticipe.MdiParent = this;
            fParticipe.Show();
        }
    }
}
