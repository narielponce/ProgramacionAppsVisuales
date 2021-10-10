using System;
using System.Collections.Generic;
using System.Text;

namespace TP_PAVI_Modulo2.Entidades
{
    public class UsuarioCurso
    {
        public int idUsuario { get; set; }
        public Curso curso { get; set; }
        public Usuario usuario { get; set; }
        public int puntuacion { get; set; }
        public string observaciones { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
    }
}
