﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ItemSearchTiger
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TIGERSTREntities : DbContext
    {
        public TIGERSTREntities()
            : base("name=TIGERSTREntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LG_504_ITEMS> LG_504_ITEMS { get; set; }
        public virtual DbSet<LG_XT1001_504> LG_XT1001_504 { get; set; }
    }
}