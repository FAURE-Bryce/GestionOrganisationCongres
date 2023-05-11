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
    public partial class FrmGestionHotel : Form
    {
        gestionCongresEntities context;

        public FrmGestionHotel()
        {
            InitializeComponent();
        }

        private void FrmGestionHotel_Load(object sender, EventArgs e)
        {
            try
            {
                context = new gestionCongresEntities();

                context.Hotels.Load();

                bindSrcHotels.DataSource = context.Hotels.Local.ToBindingList();
                bindSrcCategorie.DataSource = context.Categories.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
