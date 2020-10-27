using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace contosoUniversity.Models
{
    public class Estudiante
    {
        public int ID { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public DateTime FechaInscripcion { get; set; }

        public virtual ICollection<Inscripcion> Inscripciones { get; set; }
    }
}