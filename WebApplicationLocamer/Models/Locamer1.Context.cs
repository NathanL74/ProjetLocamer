﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Locamer1Entities : DbContext
    {
        public Locamer1Entities()
            : base("name=Locamer1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Detail_option> Detail_option { get; set; }
        public virtual DbSet<Mobilhome> Mobilhome { get; set; }
        public virtual DbSet<Option> Option { get; set; }
        public virtual DbSet<Sejour> Sejour { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Type_sejour> Type_sejour { get; set; }
        public virtual DbSet<Type_tarif> Type_tarif { get; set; }
    }
}
