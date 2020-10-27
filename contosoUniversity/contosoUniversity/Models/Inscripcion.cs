using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace contosoUniversity.Models
{
        public enum Grado
        {
            A, B, C, D, F
        }

        public class Inscripcion
        {
            public int InscripcionID { get; set; }
            public int CursoID { get; set; }
            public int EstudianteID { get; set; }
            public Grado? Grado { get; set; }

            public virtual Curso Curso { get; set; }
            public virtual Estudiante Estudiante { get; set; }
        }
}