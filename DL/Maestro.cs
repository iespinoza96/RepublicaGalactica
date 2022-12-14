//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Maestro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Maestro()
        {
            this.Padawans = new HashSet<Padawan>();
            this.MiembrosConsejoes = new HashSet<MiembrosConsejo>();
        }
    
        public int IdMaestro { get; set; }
        public Nullable<int> IdOrdenJedi { get; set; }
        public Nullable<int> IdSistemasAmenazados { get; set; }
        public Nullable<bool> Rango { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Padawan> Padawans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MiembrosConsejo> MiembrosConsejoes { get; set; }
        public virtual OrdenJedi OrdenJedi { get; set; }
        public virtual SistemasAmenazado SistemasAmenazado { get; set; }
    }
}
