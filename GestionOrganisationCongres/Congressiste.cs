//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionOrganisationCongres
{
    using System;
    using System.Collections.Generic;
    
    public partial class Congressiste
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Congressiste()
        {
            this.Activites = new HashSet<Activite>();
            this.Sessions = new HashSet<Session>();
        }
    
        public int numInscription { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse { get; set; }
        public string cp { get; set; }
        public string ville { get; set; }
        public string tel { get; set; }
        public decimal acompte { get; set; }
        public int idHotel { get; set; }
        public int idLigue { get; set; }
    
        public virtual Hotel Hotel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activite> Activites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual Ligue Ligue { get; set; }
    }
}
