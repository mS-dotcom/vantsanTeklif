﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wantsan.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class vantsanEntities : DbContext
    {
        public vantsanEntities()
            : base("name=vantsanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<buyukluk_tipleri> buyukluk_tipleri { get; set; }
        public virtual DbSet<buyukluk_values> buyukluk_values { get; set; }
        public virtual DbSet<Pozisyonlar> Pozisyonlar { get; set; }
        public virtual DbSet<teklif> teklif { get; set; }
        public virtual DbSet<teslim_yerleri_tipleri> teslim_yerleri_tipleri { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<Mail> Mail { get; set; }
    }
}
