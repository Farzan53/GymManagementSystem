﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gym_Management.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GymEntities1 : DbContext
    {
        public GymEntities1()
            : base("name=GymEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin1> Admin1 { get; set; }
        public virtual DbSet<chart> charts { get; set; }
        public virtual DbSet<equipment> equipments { get; set; }
        public virtual DbSet<student_trainer> student_trainer { get; set; }
        public virtual DbSet<trainee> trainees { get; set; }
        public virtual DbSet<trainee_details> trainee_details { get; set; }
        public virtual DbSet<traineelog> traineelogs { get; set; }
        public virtual DbSet<trainer> trainers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
