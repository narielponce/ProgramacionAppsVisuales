using System;
using System.Collections.Generic;
using System.Text;

namespace TP_PAVI_Modulo2.Entidades
{
    public class ObjetivoCurso
    {
        public int idObjetivo { get; set; }
        public int idCurso { get; set; }
        public int puntos { get; set; }
        public bool borrado { get; set; }
    }
}
