﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UDBPlus.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UDBInfoDBEntities : DbContext
    {
        public UDBInfoDBEntities()
            : base("name=UDBInfoDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<MessageType> MessageTypes { get; set; }
        public virtual DbSet<CourseType> CourseTypes { get; set; }
        public virtual DbSet<Licenciatura> Licenciaturas { get; set; }
        public virtual DbSet<Maestria> Maestrias { get; set; }
        public virtual DbSet<Tecnico> Tecnicos { get; set; }
        public virtual DbSet<Ingenieria> Ingenierias { get; set; }
    }
}
