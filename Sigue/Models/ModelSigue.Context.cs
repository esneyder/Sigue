﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sigue.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sigue_dbEntities1 : DbContext
    {
        public sigue_dbEntities1()
            : base("name=sigue_dbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<tblasesor> tblasesors { get; set; }
        public virtual DbSet<tblAsesor_estudiante> tblAsesor_estudiante { get; set; }
        public virtual DbSet<tblautoaprendizaje> tblautoaprendizajes { get; set; }
        public virtual DbSet<tblcentropractica> tblcentropracticas { get; set; }
        public virtual DbSet<tblconocimiendoRelacionado> tblconocimiendoRelacionadoes { get; set; }
        public virtual DbSet<tblconocimientotrabajo> tblconocimientotrabajoes { get; set; }
        public virtual DbSet<tblcooperador> tblcooperadors { get; set; }
        public virtual DbSet<tblEmpresa_estudiante> tblEmpresa_estudiante { get; set; }
        public virtual DbSet<tblestudiante> tblestudiantes { get; set; }
        public virtual DbSet<tblEstudianteEstudio> tblEstudianteEstudios { get; set; }
        public virtual DbSet<tblestudianteotrosconocimiento> tblestudianteotrosconocimientoes { get; set; }
        public virtual DbSet<tblfacultad> tblfacultads { get; set; }
        public virtual DbSet<tblprograma> tblprogramas { get; set; }
        public virtual DbSet<tblrepresentante> tblrepresentantes { get; set; }
        public virtual DbSet<tblresponsable> tblresponsables { get; set; }
        public virtual DbSet<tblvacante> tblvacantes { get; set; }
    }
}