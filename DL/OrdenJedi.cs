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
    
    public partial class OrdenJedi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenJedi()
        {
            this.Maestroes = new HashSet<Maestro>();
            this.Padawans = new HashSet<Padawan>();
        }
    
        public int IdOrdenJedi { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> Edad { get; set; }
        public Nullable<int> NivelMidiclorianosSangre { get; set; }
        public string DatosDeInteres { get; set; }
        public Nullable<int> IdEspecie { get; set; }
    
        public virtual Especie Especie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maestro> Maestroes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Padawan> Padawans { get; set; }
    }
}
