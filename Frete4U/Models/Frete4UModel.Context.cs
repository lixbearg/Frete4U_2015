﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Frete4U.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Frete4UEntities : DbContext
    {
        public Frete4UEntities()
            : base("name=Frete4UEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_cd_cidades> tb_cd_cidades { get; set; }
        public virtual DbSet<tb_cd_estados> tb_cd_estados { get; set; }
        public virtual DbSet<tb_cd_prestador> tb_cd_prestador { get; set; }
        public virtual DbSet<tb_cd_tipo_entrega> tb_cd_tipo_entrega { get; set; }
        public virtual DbSet<tb_cd_transporte> tb_cd_transporte { get; set; }
    }
}