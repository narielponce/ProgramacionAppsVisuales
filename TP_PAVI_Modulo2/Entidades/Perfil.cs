using System;
using System.Collections.Generic;
using System.Text;

namespace TP_PAVI_Modulo2.Entidades
{
    public class Perfil
    {
        public int idPerfil { get; set; }
        public string nombre { get; set; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
