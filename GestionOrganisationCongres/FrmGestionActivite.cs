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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionOrganisationCongres
{

    public partial class FrmGestionActivite : Form
    {
        gestionCongresEntities context;
        private bool ajout = false;

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

                //ajout des heures dans la comboBox
                string[] heures = { "09:00", "14:30" };
                comboBoxHeureActivite.Items.AddRange(heures);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void bindSrcActivites_CurrentChanged(object sender, EventArgs e)
        {
            bindSrcInscriptions.DataSource = ((Activite)bindSrcActivites.Current).Congressistes.ToList();
            bindSrcNonInscrits.DataSource = context.GetCongressistesDisponiblesByActivite(((Activite)bindSrcActivites.Current).idActivite).ToList();
            //NE FONCTIONNE PAS 
            //lblPlacesDispoValeur.Text = context.nbPlacesActivite(((Activite)bindSrcActivites.Current).idActivite).FirstOrDefault().ToString();
        }

        private void btAjouterInscritActivite_Click(object sender, EventArgs e)
        {
            try
            {

                ((Activite)bindSrcActivites.Current).Congressistes.Add((Congressiste)bindSrcNonInscrits.Current);
                context.SaveChanges();
                bindSrcInscriptions.Add((Congressiste)bindSrcNonInscrits.Current);
                bindSrcNonInscrits.RemoveCurrent();


                MessageBox.Show("Congressiste ajouté à l'activité", "Information", MessageBoxButtons.OK);

            }
            catch
            {
                ((Activite)bindSrcActivites.Current).Congressistes.Remove((Congressiste)bindSrcNonInscrits.Current);
                context.Entry((Activite)bindSrcActivites.Current).State = EntityState.Unchanged;
                MessageBox.Show("Le congressiste n'a pu pas être ajouté à l'activité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btAjouterActivite_Click(object sender, EventArgs e)
        {
            ajout = true;
            tabControlActivite.SelectedIndex = 1;
            bindSrcActivites.AddNew();
            btSupprimerActivite.Visible = btAjouterInscritActivite.Enabled = btSupprimerInscritActivite.Enabled = false;
        }

        private void btAnnulerModifActivite_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ajout de l'activité annulé", "Information", MessageBoxButtons.OK);
            bindSrcActivites.ResetBindings(false);
            bindSrcActivites.CancelEdit();
            tabControlActivite.SelectedIndex = 0;
            btSupprimerActivite.Visible = btAjouterInscritActivite.Enabled = btSupprimerInscritActivite.Enabled = true;
        }

        private void btValiderActivite_Click(object sender, EventArgs e)
        {
            if (this.ajout)
            {
                try
                {
                    bindSrcActivites.EndEdit();
                    context.SaveChanges();
                    MessageBox.Show("Activité ajoutée", "Information", MessageBoxButtons.OK);
                    tabControlActivite.SelectedIndex = 0;
                    btSupprimerActivite.Visible = btAjouterInscritActivite.Enabled = btSupprimerInscritActivite.Enabled = true;
                    this.ajout = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors de la modification de l'activité", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                try
                {
                    bindSrcActivites.EndEdit();
                    context.SaveChanges();
                    MessageBox.Show("Activité modifiée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControlActivite.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors de l'ajout d'une activité", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btSupprimerActivite_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer cette activité ? Cela supprimera également tous les congressistes qui y participent", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Activite activiteSelect = (Activite)bindSrcActivites.Current;
                try
                {

                    activiteSelect.Congressistes.Clear();
                    context.Activites.Remove(activiteSelect);
                    context.SaveChanges();
                    MessageBox.Show("Activité supprimé", "Information", MessageBoxButtons.OK);
                    tabControlActivite.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "L'activité n'a pu pas être supprimé", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    context.Activites.AddOrUpdate(activiteSelect);
                    context.Entry(activiteSelect).State = EntityState.Unchanged;
                    bindSrcActivites.ResetBindings(false);

                }
            }
        }

        private void btSupprimerInscritActivite_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce congressiste de l'activité? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    ((Activite)bindSrcActivites.Current).Congressistes.Remove((Congressiste)bindSrcInscriptions.Current);
                    context.SaveChanges();
                    bindSrcNonInscrits.Add((Congressiste)bindSrcInscriptions.Current);
                    bindSrcInscriptions.RemoveCurrent();

                    MessageBox.Show("Congressiste supprimé de l'activité", "Information", MessageBoxButtons.OK);

                }
                catch
                {
                    ((Activite)bindSrcActivites.Current).Congressistes.Add((Congressiste)bindSrcInscriptions.Current);
                    context.Entry((Activite)bindSrcActivites.Current).State = EntityState.Unchanged;
                    MessageBox.Show("Le congressiste n'a pu pas être supprimé de l'activité", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        
    }
}
