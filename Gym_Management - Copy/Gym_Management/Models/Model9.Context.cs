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
    
    public partial class Gym_Management_SystemEntities9 : DbContext
    {
        public Gym_Management_SystemEntities9()
            : base("name=Gym_Management_SystemEntities9")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin1> Admin1 { get; set; }
        public virtual DbSet<chart> charts { get; set; }
        public virtual DbSet<equipment> equipments { get; set; }
        public virtual DbSet<Gym_Branch> Gym_Branch { get; set; }
        public virtual DbSet<Gym_Branch_1> Gym_Branch_1 { get; set; }
        public virtual DbSet<Gym_Equipment_type> Gym_Equipment_type { get; set; }
        public virtual DbSet<Gym_Equipment_type_1> Gym_Equipment_type_1 { get; set; }
        public virtual DbSet<Membership> Memberships { get; set; }
        public virtual DbSet<Membership_History> Membership_History { get; set; }
        public virtual DbSet<physcial_details> physcial_details { get; set; }
        public virtual DbSet<student_trainer> student_trainer { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Timetable> Timetables { get; set; }
        public virtual DbSet<trainee> trainees { get; set; }
        public virtual DbSet<trainee_details> trainee_details { get; set; }
        public virtual DbSet<trainer> trainers { get; set; }
    }
}
