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
    public partial class FrmGestionInscriptions : Form
    {
        gestionCongresEntities context;
        public FrmGestionInscriptions()
        {
            InitializeComponent();
        }

        private void FrmGestionInscriptions_Load(object sender, EventArgs e)
        {
            try
            {
                context = new gestionCongresEntities();

                context.Congressistes.Load();

                bindSrcInscriptions.DataSource = context.Congressistes.Local.ToBindingList();
                bindSrcHotel.DataSource = context.Hotels.ToList();
                bindSrcLigue.DataSource = context.Ligues.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
