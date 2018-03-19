//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetImmoBilly
{
    using System;
    using System.Collections.Generic;
    
    public partial class BIENS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BIENS()
        {
            this.PROPOSITIONS = new HashSet<PROPOSITIONS>();
        }
    
        public int NUMERO_BIEN { get; set; }
        public int NUMERO_VILLE { get; set; }
        public int NUMERO_VENDEUR { get; set; }
        public short NUMERO_STATUT_BIEN { get; set; }
        public int SURFACE_HABITABLE { get; set; }
        public int SURFACE_PARCELLE { get; set; }
        public int NOMBRE_PIECE { get; set; }
        public Nullable<int> NOMBRE_CHAMBRE { get; set; }
        public Nullable<int> NOMBRE_SDB { get; set; }
        public Nullable<bool> GARAGE { get; set; }
        public Nullable<bool> CAVE { get; set; }
        public int PRIX_VENTE { get; set; }
        public string ADRESSE_BIEN { get; set; }
        public Nullable<System.DateTime> DATE_MISE_EN_VENTE { get; set; }
        public string COMMENTAIRE { get; set; }
    
        public virtual STATUT_BIEN STATUT_BIEN { get; set; }
        public virtual VENDEURS VENDEURS { get; set; }
        public virtual VILLES VILLES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROPOSITIONS> PROPOSITIONS { get; set; }

        // Redéfinition de la méthode "toString()" afin d'afficher le numéro d'un bien dans la grille des biens trouvés (recherche de biens selon le souhait d'un acheteur)
        public override string ToString()
        {
            return "Bien n° " + this.NUMERO_BIEN.ToString();
        }
    }
}
