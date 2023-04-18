using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionOrganisationCongres;

namespace ApplicationMDI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Voulez-vous réellement quitter l'application ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void qUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestionActivitéToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["FrmGestionActivite"] == null)
            {
                FrmGestionActivite unFrmGestActivite = new FrmGestionActivite();
                unFrmGestActivite.Show();
            }
            else
            {
                Application.OpenForms["FrmGestionActivite"].BringToFront();
            }
        }

        private void gestionHôtelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmGestionHotel"] == null)
            {
                FrmGestionHotel unFrmGestHotel = new FrmGestionHotel();
                unFrmGestHotel.Show();
            }
            else
            {
                Application.OpenForms["FrmGestionHotel"].BringToFront();
            }
        }

        private void gestionInscritToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmGestionInscriptions"] == null)
            {
                FrmGestionInscriptions unFrmGestInscriptions = new FrmGestionInscriptions();
                unFrmGestInscriptions.Show();
            }
            else
            {
                Application.OpenForms["FrmGestionInscriptions"].BringToFront();
            }
        }

        private void gestionSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmGestionSession"] == null)
            {
                FrmGestionSession unFrmGestSession = new FrmGestionSession();
                unFrmGestSession.Show();
            }
            else
            {
                Application.OpenForms["FrmGestionSession"].BringToFront();
            }
        }
    }
}
