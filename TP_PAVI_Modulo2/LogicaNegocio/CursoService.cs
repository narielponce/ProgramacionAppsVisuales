using System;
using System.Collections.Generic;
using System.Text;
using TP_PAVI_Modulo2.AccesoDatos;
using TP_PAVI_Modulo2.Entidades;

namespace TP_PAVI_Modulo2.LogicaNegocio
{
    public class CursoService
    {
        private CursoDao oCursoDao;
        public CursoService()
        {
            oCursoDao = new CursoDao();
        }
        public IList<Curso> ObtenerTodos()
        {
            return oCursoDao.GetAllCurso();
        }
        //internal object ObtenerUsuario(string usuario)
        //{
        //    return oCursoDao.GetUser(usuario);
        //}
    }
}
