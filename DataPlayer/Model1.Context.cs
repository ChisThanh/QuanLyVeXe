﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataPlayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QL_BANVEXEKHACHEntities : DbContext
    {
        public QL_BANVEXEKHACHEntities()
            : base("name=QL_BANVEXEKHACHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TAIXE> TAIXEs { get; set; }
        public virtual DbSet<TINHTHANH> TINHTHANHs { get; set; }
        public virtual DbSet<TUYENXE> TUYENXEs { get; set; }
        public virtual DbSet<VEXE> VEXEs { get; set; }
        public virtual DbSet<XE> XEs { get; set; }
    }
}
