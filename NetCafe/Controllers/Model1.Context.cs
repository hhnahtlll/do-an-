﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetCafe.Controllers
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sqlnetcfEntities : DbContext
    {
        public sqlnetcfEntities()
            : base("name=sqlnetcfEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<lich_su_giao_dich> lich_su_giao_dich { get; set; }
        public virtual DbSet<order_details> order_details { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<product_images> product_images { get; set; }
        public virtual DbSet<product> products { get; set; }
    }
}
