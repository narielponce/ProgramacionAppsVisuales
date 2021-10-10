using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI_Modulo2.Entidades;
using TP_PAVI_Modulo2.AccesoDatos;

namespace TP_PAVI_Modulo2.LogicaNegocio
{
    public class UsuarioService
    {
        private UsuarioCursoDao oUsuarioCursoDao;
        private UsuarioDao oUsuarioDao;

        public UsuarioService()
        {
            oUsuarioCursoDao = new UsuarioCursoDao();
            oUsuarioDao = new UsuarioDao();
        }

        public IList<UsuarioCurso> ObtenerUsuariosPorCurso()
        {
            return oUsuarioCursoDao.GetAll();
        }

        public IList<Usuario> ObtenerTodos()
        {
            return oUsuarioDao.GetAllUser();
        }

        public Usuario ValidarUsuario(string usuario, string password)
        {
            var usr = oUsuarioDao.GetUser(usuario);
            if(usr != null && usr.password.Equals(password))
            {
                return usr;
            }
            return null;
        }
        internal object ObtenerUsuario(string usuario)
        {
            return oUsuarioCursoDao.GetUser(usuario);
        }

        internal bool CrearUsuario(UsuarioCurso oUsuario)
        {
            return oUsuarioCursoDao.Create(oUsuario);
        }

        internal bool UpdateUsuario(UsuarioCurso oUsuario)
        {
            return oUsuarioCursoDao.Update(oUsuario);
        }

        internal bool DeleteUsuario(UsuarioCurso oUsuario)
        {
            return oUsuarioCursoDao.Delete(oUsuario);
        }
    }
}
