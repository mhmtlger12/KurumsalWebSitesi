﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Onixa.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SitedbContext : DbContext
    {
        public SitedbContext()
            : base("name=SitedbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Exceptions> Exceptions { get; set; }
        public virtual DbSet<HomeRooms> HomeRooms { get; set; }
        public virtual DbSet<Localizations> Localizations { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<Messages_> Messages_ { get; set; }
        public virtual DbSet<MessagesReplies> MessagesReplies { get; set; }
        public virtual DbSet<Options> Options { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<ProductDetails> ProductDetails { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductsImageName> ProductsImageName { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Styles> Styles { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Users_Roles> Users_Roles { get; set; }
    }
}
