﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_Otomation.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Hotel_2019_DbEntities : DbContext
    {
        public Hotel_2019_DbEntities()
            : base("name=Hotel_2019_DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Abouts> Abouts { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Galleries> Galleries { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
