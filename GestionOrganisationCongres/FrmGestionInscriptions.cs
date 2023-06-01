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
            decimal? montantT = context.montantTotal(((Congressiste)bindSrcInscriptions.Current).numInscription).FirstOrDefault();
            decimal? reste = montantT - ((Congressiste)bindSrcInscriptions.Current).acompte;

            lbRestePayerValeur.Text = reste.ToString();
            lbMontantTotalValue.Text = montantT.ToString();

            bindSrcActivite.DataSource = ((Congressiste)bindSrcInscriptions.Current).Activites.ToList();
            bindSrcSession.DataSource = ((Congressiste)bindSrcInscriptions.Current).Sessions.ToList();
            bindSrcActivitesDispo.DataSource = context.GetActivitesPasInscrit(((Congressiste)bindSrcInscriptions.Current).numInscription).ToList();
            bindSrcSessionsDispo.DataSource = context.GetSessionsPasInscrit(((Congressiste)bindSrcInscriptions.Current).numInscription).ToList();

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
            bindSrcInscriptions.ResetBindings(false);
            bindSrcInscriptions.CancelEdit();
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
            try
            {
                int nbPlacesActivite = (int)context.nbPlacesActivite(((Activite)bindSrcActivitesDispo.Current).idActivite).FirstOrDefault();
                if (nbPlacesActivite != 0)
                {
                    ((Congressiste)bindSrcInscriptions.Current).Activites.Add((Activite)bindSrcActivitesDispo.Current);
                    context.SaveChanges();
                    bindSrcActivite.Add((Activite)bindSrcActivitesDispo.Current);
                    bindSrcActivitesDispo.RemoveCurrent();

                }
                else
                {
                    MessageBox.Show("Le congressiste n'a pu pas être ajouté à la session car le nombre de place max est atteint", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                ((Congressiste)bindSrcInscriptions.Current).Activites.Remove((Activite)bindSrcActivitesDispo.Current);
                context.Entry((Congressiste)bindSrcInscriptions.Current).State = EntityState.Unchanged;
                MessageBox.Show("Le congressiste n'a pu pas être ajouté à l'activité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btAjouterSessionCongressiste_Click(object sender, EventArgs e)
        {
            try
            {
                int nbPlacesBySession = (int)context.NbPlacesBySession(((Session)bindSrcSessionsDispo.Current).numSession).FirstOrDefault();
                if (nbPlacesBySession != 0)
                {
                    ((Congressiste)bindSrcInscriptions.Current).Sessions.Add((Session)bindSrcSessionsDispo.Current);
                    context.SaveChanges();
                    bindSrcSession.Add((Session)bindSrcSessionsDispo.Current);
                    bindSrcSessionsDispo.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Le congressiste n'a pu pas être ajouté à la session car le nombre de place max est atteint", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                ((Congressiste)bindSrcInscriptions.Current).Sessions.Remove((Session)bindSrcSessionsDispo.Current);
                context.Entry((Congressiste)bindSrcInscriptions.Current).State = EntityState.Unchanged;
                MessageBox.Show("Le congressiste n'a pu pas être ajouté à la session", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btSupprimerActiviteCongressiste_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce congressiste de l'activité? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    ((Congressiste)bindSrcInscriptions.Current).Activites.Remove((Activite)bindSrcActivite.Current);
                    context.SaveChanges();
                    bindSrcActivitesDispo.Add((Activite)bindSrcActivite.Current);
                    bindSrcActivite.RemoveCurrent();

                    MessageBox.Show("Congressiste supprimé de l'activité", "Information", MessageBoxButtons.OK);

                }
                catch
                {
                    ((Congressiste)bindSrcInscriptions.Current).Activites.Add((Activite)bindSrcActivite.Current);
                    context.Entry((Congressiste)bindSrcInscriptions.Current).State = EntityState.Unchanged;
                    MessageBox.Show("Le congressiste n'a pu pas être supprimé de l'activité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btSupprimerSessionCongressiste_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce congressiste de la session? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    ((Congressiste)bindSrcInscriptions.Current).Sessions.Remove((Session)bindSrcSession.Current);
                    context.SaveChanges();
                    bindSrcSessionsDispo.Add((Session)bindSrcSession.Current);
                    bindSrcSession.RemoveCurrent();

                    MessageBox.Show("Congressiste supprimé de la session", "Information", MessageBoxButtons.OK);

                }
                catch
                {
                    ((Congressiste)bindSrcInscriptions.Current).Sessions.Add((Session)bindSrcSession.Current);
                    context.Entry((Congressiste)bindSrcInscriptions.Current).State = EntityState.Unchanged;
                    MessageBox.Show("Le congressiste n'a pu pas être supprimé de la session", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
