//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationLocamer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sejour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sejour()
        {
            this.Detail_option = new HashSet<Detail_option>();
            this.Mobilhome = new HashSet<Mobilhome>();
        }
    
        public int id_Sejour { get; set; }
        public int id_client { get; set; }
        public int id_Tsejour { get; set; }
        public int id_option { get; set; }
        public System.DateTime date_debut { get; set; }
        public System.DateTime date_fin { get; set; }
    
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detail_option> Detail_option { get; set; }
        public virtual Type_sejour Type_sejour { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mobilhome> Mobilhome { get; set; }
    }
}
