using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using contosoUniversity.Models;

namespace contosoUniversity.DAL
{
    public class ColegioContext : DbContext
    {
        public ColegioContext() : base("ColegioContext")
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Inscripcion> Incripciones { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}