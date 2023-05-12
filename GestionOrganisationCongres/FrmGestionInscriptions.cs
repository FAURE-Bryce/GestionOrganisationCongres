using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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
        private bool ajout = false;

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

        private void bindSrcInscriptions_CurrentChanged(object sender, EventArgs e)
        {
            //problème avec la procédure stockée donne en paramètre le total 
            //lbMontantTotalValue.Text += context.montantTotal(((Congressiste)bindSrcInscriptions.Current).numInscription).ToString();
            bindSrcActivite.DataSource = ((Congressiste)bindSrcInscriptions.Current).Activites.ToList();
            bindSrcSession.DataSource = ((Congressiste)bindSrcInscriptions.Current).Sessions.ToList();
            // A FAIRE PROCEDURES STOCKEES QUI RECUPERENT LES ACTIVITES ET SESSIONS DISPONIBLES

        }

        private void btSupprimerCongressiste_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce congressiste ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Congressiste congressisteSelect = (Congressiste)bindSrcInscriptions.Current;
                try
                {
                    context.Congressistes.Remove(congressisteSelect);
                    context.SaveChanges();
                    MessageBox.Show("Congressiste supprimé", "Information", MessageBoxButtons.OK);
                    tabControlInscription.SelectedIndex = 0;
                }
                catch
                {
                    MessageBox.Show("Le congressiste n'a pu pas être supprimé puisqu'il est inscrit à des activités et/ou des sessions.","Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //context.Congressistes.AddOrUpdate(congressisteSelect);
                    //context.Entry(congressisteSelect).State = EntityState.Unchanged;
                    //bindSrcInscriptions.ResetBindings(false);

                }
            }
        }

        private void btAjouterCongressiste_Click(object sender, EventArgs e)
        {
            tabControlInscription.SelectedIndex = 1;
            bindSrcInscriptions.AddNew();
            btSupprimerCongressiste.Visible= false;
        }

        private void btAnnulerModifCongressiste_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ajout annulé", "Information", MessageBoxButtons.OK);
            tabControlInscription.SelectedIndex = 0;
        }

        private void btValiderModifCongressiste_Click(object sender, EventArgs e)
        {
            if (this.ajout)
            {
                try
                {
                    bindSrcInscriptions.EndEdit();
                    context.SaveChanges();
                    MessageBox.Show("Congressiste modifié", "Information", MessageBoxButtons.OK);
                    tabControlInscription.SelectedIndex = 0;
                    btSupprimerCongressiste.Visible = true;
                    this.ajout = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors de la modification du congressiste", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                try
                {
                    bindSrcInscriptions.EndEdit();
                    context.SaveChanges();
                    MessageBox.Show("Congressiste ajouté", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControlInscription.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors de l'ajout du congressiste", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btAjouterActiviteCongressiste_Click(object sender, EventArgs e)
        {
            FrmGestionActivite frmAct = new FrmGestionActivite();
            frmAct.ShowDialog();
        }

        private void btAjouterSessionCongressiste_Click(object sender, EventArgs e)
        {
            FrmGestionSession frmSession = new FrmGestionSession();
            frmSession.ShowDialog();
        }
    }
}
