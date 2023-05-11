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
        private bool ajout = false;
        public FrmGestionHotel()
        {
            InitializeComponent();
        }

        private void FrmGestionHotel_Load(object sender, EventArgs e)
        {
            try
            {
                btAnnulerAjoutHotel.Visible = false;
                btSupprimerHotel.Visible = true;
                btValiderHotel.Visible = true;
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

        private void btAjouterHotel_Click(object sender, EventArgs e)
        {
            ajout = true;
            // Change l'onglet ouvert du formulaire hôtel
            tabControlHotel.SelectedIndex = 1;
            
            // Rend invisible le bouton Supprimer un hôtel
            btSupprimerHotel.Visible = false;
            btAnnulerAjoutHotel.Visible = true;
            btValiderHotel.Visible = true;

            bindSrcHotels.AddNew(); // Vide les lignes existantes

        }

    

        // PB: lors de l'annulation de l'ajout, une nouvelle ligne vide se crée dans le la liste des hotels
        private void btAnnulerAjoutHotel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ajout Annulé", "Annulation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tabControlHotel.SelectedIndex = 0;

            btAnnulerAjoutHotel.Visible = false;
            btSupprimerHotel.Visible = true;
            btValiderHotel.Visible = false;
        }

        // Rien ne se passe lors du click (erreur ?) + La categorie ne peut pas être changée + SEULEMENT LORS DE LA CREATION -> la modif marche
        private void btValiderHotel_Click(object sender, EventArgs e)
        {
            if (this.ajout)
            {
                 try
                 {
                    bindSrcHotels.EndEdit();
                    ((Hotel)bindSrcHotels.Current).idCateg = ((Categorie)bindSrcCategorie.Current).idCateg;

                    context.SaveChanges();

                    MessageBox.Show("Nouvel hôtel ajouté", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bindSrcHotels.ResetCurrentItem();
                    ajout = false;

                 }
                 catch (Exception ex)
                 {
                        MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
            }
            else
            {
                Hotel sauv = new Hotel((Hotel)bindSrcHotels.Current);
                try
                {
                    bindSrcHotels.EndEdit();
                    context.SaveChanges();
                    MessageBox.Show("Hôtel Modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControlHotel.SelectedIndex = 0;
                }
                catch
                {
                    MessageBox.Show("Les valeurs ne sont pas correctes, les informations vont être rénitialisées", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Hotel unH = (Hotel)bindSrcHotels.Current;
                    unH.idHotel = sauv.idHotel;
                    unH.nom = sauv.nom;
                    unH.adresse = sauv.adresse;
                    unH.ville = sauv.ville;
                    unH.cp = sauv.cp;
                    unH.tel = sauv.tel;
                    unH.prixChambre = sauv.prixChambre;
                    unH.idCateg = sauv.idCateg;

                    context.Entry(unH).State = System.Data.Entity.EntityState.Unchanged;
                    bindSrcHotels.ResetCurrentItem();
                }
            }
           
        }


        // Relève une erreur puis supprime seulement visuellement (pas de la BDD) = conflit avec l'hotel où loge les congressistes
        private void btSupprimerHotel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet hôtel ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Hotel hotelSelect = (Hotel)bindSrcHotels.Current;
                try
                {
                    // Vérifier s'il ne faut pas supprimer els liens avec les gens qui dorment là
                    hotelSelect.Congressistes.Clear();
                    context.Hotels.Remove(hotelSelect);
                    context.SaveChanges();
                    MessageBox.Show("L'hôtel a bien été supprimé", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControlHotel.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "L'hôtel n'a pas pu être supprimé", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    context.Entry(hotelSelect).State = EntityState.Unchanged;
                }
            }

        }
    }
}
