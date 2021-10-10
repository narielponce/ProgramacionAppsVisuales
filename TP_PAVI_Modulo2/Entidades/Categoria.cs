using System;
using System.Collections.Generic;
using System.Text;

namespace TP_PAVI_Modulo2.Entidades
{
    public class Categoria
    {
        public int idCategoria { get; set; }
        public string nombreCateg { get; set; }
        public string descripcion { get; set; }
        public bool borrado { get; set; }
        public override string ToString()
        {
            return nombreCateg;
        }
    }
}
