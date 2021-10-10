using System;
using System.Collections.Generic;
using System.Text;

namespace TP_PAVI_Modulo2.Entidades
{
    public class UsuarioCursoAvance
    {
        public UsuarioCurso idUsuario { get; set; }
        public UsuarioCurso idCurso { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public float porcentajeAvance { get; set; }
    }
}
