﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RasberryPiFinalProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebsiteDatabaseProjectEntities2 : DbContext
    {
        public WebsiteDatabaseProjectEntities2()
            : base("name=WebsiteDatabaseProjectEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Mostanadat> Mostanadats { get; set; }
        public virtual DbSet<Msale7> Msale7 { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
    }
}
