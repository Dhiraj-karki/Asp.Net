﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dhiraj.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudentEntities : DbContext
    {
        public StudentEntities()
            : base("name=StudentEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<doctor> doctors { get; set; }
        public virtual DbSet<employee_salary_details> employee_salary_details { get; set; }
        public virtual DbSet<Std> Stds { get; set; }
        public virtual DbSet<Table_1> Table_1 { get; set; }
    }
}
