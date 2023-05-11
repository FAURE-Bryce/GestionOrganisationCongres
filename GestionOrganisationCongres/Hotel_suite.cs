using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionOrganisationCongres
{
    public partial class Hotel
    {
        public override string ToString()
        {
            return this.nom;
        }

        // Constructeur de copie
        public Hotel (Hotel unHotel)
        {
            this.idHotel = unHotel.idHotel;
            this.nom = unHotel.nom;
            this.adresse = unHotel.adresse;
            this.cp = unHotel.cp;
            this.ville = unHotel.ville;
            this.tel = unHotel.tel;
            this.prixChambre = unHotel.prixChambre;
            this.idCateg = unHotel.idCateg;
        }

        public Hotel(int idHotel, string nom, string adresse, string cp, string ville, string tel, decimal prixChambre, int idCateg, ICollection<Congressiste> congressistes, Categorie categorie)
        {
            this.idHotel = idHotel;
            this.nom = nom;
            this.adresse = adresse;
            this.cp = cp;
            this.ville = ville;
            this.tel = tel;
            this.prixChambre = prixChambre;
            this.idCateg = idCateg;
            Congressistes = congressistes;
            Categorie = categorie;
        }
    }
}
