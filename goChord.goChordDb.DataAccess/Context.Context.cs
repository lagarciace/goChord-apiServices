﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace goChord.goChordDb.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gochordEntities : DbContext
    {
        public gochordEntities()
            : base("name=gochordEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<song> song { get; set; }
        public virtual DbSet<songbook> songbook { get; set; }
        public virtual DbSet<songbookbyuser> songbookbyuser { get; set; }
        public virtual DbSet<songbysongbook> songbysongbook { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<categoriesBySong> categoriesBySong { get; set; }
        public virtual DbSet<category> category { get; set; }
    }
}
