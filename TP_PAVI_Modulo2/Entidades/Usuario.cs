using System;
using System.Collections.Generic;
using System.Text;

namespace TP_PAVI_Modulo2.Entidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Perfil perfil { get; set; }
        public override string ToString()
        {
            return nombreUsuario;
        }
    }
}
