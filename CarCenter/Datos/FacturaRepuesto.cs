//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class FacturaRepuesto
    {
        public long FacturaRepuestoId { get; set; }
        public Nullable<int> NumeroUnidades { get; set; }
        public Nullable<decimal> ValorDescuentoRepuestos { get; set; }
        public Nullable<decimal> ValorManoObra { get; set; }
        public Nullable<decimal> ValorDescuentoManoObra { get; set; }
        public Nullable<long> FacturaId { get; set; }
        public Nullable<long> RepuestoId { get; set; }
    
        public virtual Factura Factura { get; set; }
        public virtual Repuesto Repuesto { get; set; }
    }
}