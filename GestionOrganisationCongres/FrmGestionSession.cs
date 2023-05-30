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
        private bool ajout = false;
        public FrmGestionSession()
        {
            InitializeComponent();
        }

        // l'autoValidation est a disable mais le visuel se met à jour quant même  ! ! !
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

        private void btAjouterInscritSession_Click(object sender, EventArgs e)
        {
            try
            {

                ((Session)bindSrcSessions.Current).Congressistes.Add((Congressiste)bindSrcNonInscrits.Current);
                context.SaveChanges();
                bindSrcInscrits.Add((Congressiste)bindSrcNonInscrits.Current);
                bindSrcNonInscrits.RemoveCurrent();


                MessageBox.Show("Congressiste ajouté à la session", "Information", MessageBoxButtons.OK);

            }
            catch
            {
                ((Session)bindSrcSessions.Current).Congressistes.Remove((Congressiste)bindSrcNonInscrits.Current);
                context.Entry((Session)bindSrcSessions.Current).State = EntityState.Unchanged;
                MessageBox.Show("Le congressiste n'a pu pas être ajouté à la session", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btSupprimerInscritSession_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce congressiste de la session ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    ((Session)bindSrcSessions.Current).Congressistes.Remove((Congressiste)bindSrcInscrits.Current);
                    context.SaveChanges();
                    bindSrcNonInscrits.Add((Congressiste)bindSrcInscrits.Current);
                    bindSrcInscrits.RemoveCurrent();

                    MessageBox.Show("Congressiste supprimé de l'activité", "Information", MessageBoxButtons.OK);

                }
                catch
                {
                    ((Session)bindSrcSessions.Current).Congressistes.Add((Congressiste)bindSrcInscrits.Current);
                    context.Entry((Activite)bindSrcInscrits.Current).State = EntityState.Unchanged;
                    MessageBox.Show("Le congressiste n'a pu pas être supprimé de l'activité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btValiderModifSession_Click(object sender, EventArgs e)
        {
            if (this.ajout)
            {
                try
                {
                    bindSrcSessions.EndEdit();
                    context.SaveChanges();
                    MessageBox.Show("Session ajoutée", "Information", MessageBoxButtons.OK);
                    tabControlSession.SelectedIndex = 0;
                    btSupprimerSession.Visible = btAjouterInscritSession.Enabled = btSupprimerInscritSession.Enabled = true;
                    this.ajout = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors de la modification de la session", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                try
                {
                    bindSrcSessions.EndEdit();
                    context.SaveChanges();
                    MessageBox.Show("Session modifiée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControlSession.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors de la modification d'une session", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btAjouterSession_Click(object sender, EventArgs e)
        {
            ajout = true;
            tabControlSession.SelectedIndex = 1;
            bindSrcSessions.AddNew();
            btSupprimerSession.Visible = btAjouterInscritSession.Enabled = comboBoxNonInscrits.Enabled = btSupprimerInscritSession.Enabled = false;
        }

        private void btAnnulerModifSession_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ajout de la session annulé", "Information", MessageBoxButtons.OK);
            bindSrcSessions.ResetBindings(false);
            bindSrcSessions.CancelEdit();
            tabControlSession.SelectedIndex = 0;
            btSupprimerSession.Visible = btAjouterInscritSession.Enabled = btSupprimerInscritSession.Enabled = true;
        }
    }
}