﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CarCenterEntities : DbContext
    {
        public CarCenterEntities()
            : base("name=CarCenterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Mecanico> Mecanicoes { get; set; }
        public virtual DbSet<Repuesto> Repuestoes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tienda> Tiendas { get; set; }
        public virtual DbSet<FacturaRepuesto> FacturaRepuestos { get; set; }
    }
}
