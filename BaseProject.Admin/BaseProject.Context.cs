﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaseProject.Admin
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BaseProjectEntities : DbContext
    {
        public BaseProjectEntities()
            : base("name=BaseProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Code> Code { get; set; }
        public virtual DbSet<CodeMain> CodeMain { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<RolesOperationPermission> RolesOperationPermission { get; set; }
        public virtual DbSet<UserLoginLog> UserLoginLog { get; set; }
    }
}
