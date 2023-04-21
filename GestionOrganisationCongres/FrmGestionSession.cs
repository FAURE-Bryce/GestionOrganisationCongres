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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
