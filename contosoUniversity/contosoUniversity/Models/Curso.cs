using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace contosoUniversity.Models
{
    public class Curso
    {
        public int CursoID { get; set; }
        public string Titulo { get; set; }
        public int Creditos { get; set; }

        public virtual ICollection<Inscripcion> Inscripciones { get; set; }
    }
}