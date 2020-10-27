using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using contosoUniversity.Models;

namespace contosoUniversity.DAL
{
    public class ColegioInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ColegioContext>
    {
        protected override void Seed(ColegioContext context)
        {
            var estudiantes = new List<Estudiante>
            {
            new Estudiante{PrimerApellido="Carson",PrimerNombre="Alexander",FechaInscripcion=DateTime.Parse("2005-09-01")},
            new Estudiante{PrimerApellido="Meredith",PrimerNombre="Alonso",FechaInscripcion=DateTime.Parse("2002-09-01")},
            new Estudiante{PrimerApellido="Arturo",PrimerNombre="Anand",FechaInscripcion=DateTime.Parse("2003-09-01")},
            new Estudiante{PrimerApellido="Gytis",PrimerNombre="Barzdukas",FechaInscripcion=DateTime.Parse("2002-09-01")},
            new Estudiante{PrimerApellido="Yan",PrimerNombre="Li",FechaInscripcion=DateTime.Parse("2002-09-01")},
            new Estudiante{PrimerApellido="Peggy",PrimerNombre="Justice",FechaInscripcion=DateTime.Parse("2001-09-01")},
            new Estudiante{PrimerApellido="Laura",PrimerNombre="Norman",FechaInscripcion=DateTime.Parse("2003-09-01")},
            new Estudiante{PrimerApellido="Nino",PrimerNombre="Olivetto",FechaInscripcion=DateTime.Parse("2005-09-01")}
            };

            estudiantes.ForEach(s => context.Estudiantes.Add(s));
            context.SaveChanges();
            var cursos = new List<Curso>
            {
            new Curso{CursoID=1050,Titulo="Chemistry",Creditos=3,},
            new Curso{CursoID=4022,Titulo="Microeconomics",Creditos=3,},
            new Curso{CursoID=4041,Titulo="Macroeconomics",Creditos=3,},
            new Curso{CursoID=1045,Titulo="Calculus",Creditos=4,},
            new Curso{CursoID=3141,Titulo="Trigonometry",Creditos=4,},
            new Curso{CursoID=2021,Titulo="Composition",Creditos=3,},
            new Curso{CursoID=2042,Titulo="Literature",Creditos=4,}
            };
            cursos.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();
            var inscripciones = new List<Inscripcion>
            {
            new Inscripcion{EstudianteID=1,CursoID=1050,Grado=Grado.A},
            new Inscripcion{EstudianteID=1,CursoID=4022,Grado=Grado.C},
            new Inscripcion{EstudianteID=1,CursoID=4041,Grado=Grado.B},
            new Inscripcion{EstudianteID=2,CursoID=1045,Grado=Grado.B},
            new Inscripcion{EstudianteID=2,CursoID=3141,Grado=Grado.F},
            new Inscripcion{EstudianteID=2,CursoID=2021,Grado=Grado.F},
            new Inscripcion{EstudianteID=3,CursoID=1050},
            new Inscripcion{EstudianteID=4,CursoID=1050,},
            new Inscripcion{EstudianteID=4,CursoID=4022,Grado=Grado.F},
            new Inscripcion{EstudianteID=5,CursoID=4041,Grado=Grado.C},
            new Inscripcion{EstudianteID=6,CursoID=1045},
            new Inscripcion{EstudianteID=7,CursoID=3141,Grado=Grado.A},
            };
            inscripciones.ForEach(s => context.Incripciones.Add(s));
            context.SaveChanges();
        }
    }
}