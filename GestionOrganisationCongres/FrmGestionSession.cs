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
    public partial class FrmGestionSession : Form
    {
        gestionCongresEntities context;
        private bool ajout = false;
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

        private void btAjouterInscritSession_Click(object sender, EventArgs e)
        {
            try
            {
                int nbPlacesBySession = (int)context.NbPlacesBySession(((Session)bindSrcSessions.Current).numSession).FirstOrDefault();
                if (nbPlacesBySession != 0)
                {
                    ((Session)bindSrcSessions.Current).Congressistes.Add((Congressiste)bindSrcNonInscrits.Current);
                    context.SaveChanges();
                    bindSrcInscrits.Add((Congressiste)bindSrcNonInscrits.Current);
                    bindSrcNonInscrits.RemoveCurrent();

                    MessageBox.Show("Congressiste ajouté à la session", "Information", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Le congressiste n'a pu pas être ajouté à la session car le nombre de place max est atteint", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    btSupprimerSession.Visible = btAjouterInscritSession.Enabled = comboBoxNonInscrits.Enabled = btSupprimerInscritSession.Enabled = true;
                    this.ajout = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors de l'ajout de la session", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            ((Session)bindSrcSessions.Current).heureDebut = "9:00";
            ((Session)bindSrcSessions.Current).date = DateTime.Today;
        }

        private void btAnnulerModifSession_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ajout de la session annulé", "Information", MessageBoxButtons.OK);
            bindSrcSessions.ResetBindings(false);
            bindSrcSessions.CancelEdit();
            tabControlSession.SelectedIndex = 0;
            btSupprimerSession.Visible = btAjouterInscritSession.Enabled = comboBoxNonInscrits.Enabled = btSupprimerInscritSession.Enabled = true;
        }

        private void btSupprimerSession_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer cette session ? Cela supprimera également tous les congressistes qui y participent", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Session sessionSelect = (Session)bindSrcSessions.Current;
                try
                {
                    sessionSelect.Congressistes.Clear();
                    context.Sessions.Remove(sessionSelect);
                    context.SaveChanges();
                    MessageBox.Show("Session supprimé", "Information", MessageBoxButtons.OK);
                    tabControlSession.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "La session n'a pu pas être supprimé", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    context.Sessions.AddOrUpdate(sessionSelect);
                    context.Entry(sessionSelect).State = EntityState.Unchanged;
                    bindSrcSessions.ResetBindings(false);

                }
            }
        }
    }
}