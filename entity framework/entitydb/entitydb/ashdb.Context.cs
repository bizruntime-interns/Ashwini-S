﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entitydb
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ashEntities : DbContext    //abstraction over database , loads data from or save it to database
    {
        internal object child;

        public ashEntities()
            : base("name=ashEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<student> students { get; set; }  //dbset represnts database and students are table generated from database
        public virtual DbSet<child> children { get; set; }
        public virtual DbSet<childness> childnesses { get; set; }
    }
}