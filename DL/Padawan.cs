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
    
    public partial class Padawan
    {
        public int IdPadawan { get; set; }
        public Nullable<int> IdOrdenJedi { get; set; }
        public Nullable<int> IdMaestro { get; set; }
    
        public virtual Maestro Maestro { get; set; }
        public virtual OrdenJedi OrdenJedi { get; set; }
    }
}
