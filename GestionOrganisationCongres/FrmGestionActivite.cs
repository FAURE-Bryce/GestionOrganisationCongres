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
    
    public partial class FrmGestionActivite : Form
    {
        gestionCongresEntities context;
        public FrmGestionActivite()
        {
            InitializeComponent();
        }

        private void FrmGestionActivite_Load(object sender, EventArgs e)
        {
            try
            {
                context = new gestionCongresEntities();

                context.Activites.Load();

                bindSrcActivites.DataSource = context.Activites.Local.ToBindingList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        //private void bindSrcActivites_CurrentChanged(object sender, EventArgs e)
        //{
        //    bindSrcInscriptions.DataSource = ((Activite)bindSrcActivites.Current).Congressistes.ToList();
        //}
    }
}
