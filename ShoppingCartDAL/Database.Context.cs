﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoppingCartDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SCADatabase : DbContext
    {
        public SCADatabase()
            : base("name=SCADatabase")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Cart_Product_Mapping> Cart_Product_Mapping { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Category_Product_Mapping> Category_Product_Mapping { get; set; }
        public virtual DbSet<CategoryFeature> CategoryFeatures { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product_Feature_Details> Product_Feature_Details { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Shipping> Shippings { get; set; }
        public virtual DbSet<ShippingDetail> ShippingDetails { get; set; }
        public virtual DbSet<ShippingStatu> ShippingStatus { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }
    }
}
