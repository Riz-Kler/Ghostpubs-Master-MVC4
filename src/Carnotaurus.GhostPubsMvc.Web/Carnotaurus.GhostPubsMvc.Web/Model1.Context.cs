﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Carnotaurus.GhostPubsMvc.Web
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GhostPubsEntities : DbContext
    {
        public GhostPubsEntities()
            : base("name=GhostPubsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<FeatureType> FeatureTypes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Org> Orgs { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<AdminArea> AdminAreas { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookItem> BookItems { get; set; }
        public virtual DbSet<ContentPage> ContentPages { get; set; }
    }
}