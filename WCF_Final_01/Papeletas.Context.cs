﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Final_01
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InfraccionesEntities : DbContext
    {
        public InfraccionesEntities()
            : base("name=InfraccionesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tb_Agente> Tb_Agente { get; set; }
        public virtual DbSet<Tb_Auto> Tb_Auto { get; set; }
        public virtual DbSet<Tb_Color> Tb_Color { get; set; }
        public virtual DbSet<Tb_Distrito> Tb_Distrito { get; set; }
        public virtual DbSet<Tb_Infraccion> Tb_Infraccion { get; set; }
        public virtual DbSet<Tb_Marca> Tb_Marca { get; set; }
        public virtual DbSet<Tb_Papeleta> Tb_Papeleta { get; set; }
        public virtual DbSet<Tb_Propietario> Tb_Propietario { get; set; }
    }
}