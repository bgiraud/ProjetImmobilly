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
    
    public partial class VENDEURS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENDEURS()
        {
            this.BIENS = new HashSet<BIENS>();
        }
    
        public int NUMERO_VENDEUR { get; set; }
        public int NUMERO_VILLE { get; set; }
        public string NOM_VENDEUR { get; set; }
        public string PRENOM_VENDEUR { get; set; }
        public string ADRESSE_VENDEUR { get; set; }
        public string TELEPHONE_MOBILE_VENDEUR { get; set; }
        public string TELEPHONE_FIXE_VENDEUR { get; set; }
        public string EMAIL_VENDEUR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BIENS> BIENS { get; set; }
        public virtual VILLES VILLES { get; set; }
    }
}
