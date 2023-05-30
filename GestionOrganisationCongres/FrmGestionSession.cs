using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionOrganisationCongres
{
    public partial class FrmGestionSession : Form
    {
        gestionCongresEntities context;
        public FrmGestionSession()
        {
            InitializeComponent();
        }

        private void FrmGestionSession_Load(object sender, EventArgs e)
        {
            try
            {
                context = new gestionCongresEntities();

                context.Sessions.Load();

                bindSrcSessions.DataSource = context.Sessions.Local.ToBindingList();

                bindSrcSalle.DataSource = context.Salles.ToList();

                List<string> listHeureDebut = new List<string>();
                listHeureDebut.Add("09:00");
                listHeureDebut.Add("14:30");

                comboBoxHeureDebut.Items.AddRange(listHeureDebut.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindSrcSessions_CurrentChanged(object sender, EventArgs e)
        {
            bindSrcInscrits.DataSource = ((Session)bindSrcSessions.Current).Congressistes.ToList();
            bindSrcNonInscrits.DataSource = context.GetCongressistesDisponiblesBySession(((Session)bindSrcSessions.Current).numSession).ToList();

            comboBoxNonInscrits.Enabled = true;

            if (bindSrcNonInscrits.Count == 0)
            {
                comboBoxNonInscrits.Enabled = false;
            }
        }

        private void tabControlSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            int heureDebutOfSession = 0;
            if (((Session)bindSrcSessions.Current).heureDebut == "14:30")
            {
                heureDebutOfSession = 1;
            }

            comboBoxHeureDebut.SelectedIndex = heureDebutOfSession;
        }
    }
}
