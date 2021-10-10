using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using TP_PAVI_Modulo2.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace TP_PAVI_Modulo2.AccesoDatos
{
    class UsuarioDao
    {
        public IList<Usuario> GetAllUser()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            String strSql = string.Concat(" SELECT id_usuario, ",
                                          "        usuario, ",
                                          "        email, ",
                                          "        password, ",
                                          "        p.id_perfil, ",
                                          "        p.nombre perfil ",
                                          "   FROM Usuarios u",
                                          "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil " +
                                          "  WHERE u.borrado = 0 ");
            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listaUsuarios.Add(ObjectMappingUser(row));
            }

            return listaUsuarios;
        }

        public Usuario GetUser(string nombreUsuario)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT id_usuario, ",
                                          "        usuario, ",
                                          "        email, ",
                                          "        password, ",
                                          "        p.id_perfil, ",
                                          "        p.nombre perfil ",
                                          "   FROM Usuarios u",
                                          "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                          "  WHERE usuario = @usuario");

            var parametros = new Dictionary<string, object>();
            parametros.Add("usuario", nombreUsuario);
            var resultado = DataManager.GetInstance().ConsultaSQL(strSql, parametros);

            if (resultado.Rows.Count > 0)
            {
                return ObjectMappingUser(resultado.Rows[0]);
            }

            return null;
        }

        internal bool Create(Usuario oUsuario)
        {
            string str_sql = "     INSERT INTO UsuariosCurso (usuario, password, email, id_perfil, borrado)" +
                             "     VALUES (@usuario, @password, @email, @id_perfil, 0)";

            var parametros = new Dictionary<string, object>();
            parametros.Add("usuario", oUsuario.nombreUsuario);
            parametros.Add("password", oUsuario.password);
            parametros.Add("email", oUsuario.email);
            parametros.Add("id_perfil", oUsuario.perfil.idPerfil);
            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSQL(str_sql, parametros) == 1);
        }
        private Usuario ObjectMappingUser(DataRow row)
        {
            Usuario oUsuario = new Usuario
            {
                idUsuario = Convert.ToInt32(row["id_usuario"].ToString()),
                nombreUsuario = row["usuario"].ToString(),
                email = row["email"].ToString(),
                password = row.Table.Columns.Contains("password") ? row["password"].ToString() : null,
                perfil = new Perfil()
                {
                    idPerfil = Convert.ToInt32(row["id_perfil"].ToString()),
                    nombre = row["perfil"].ToString(),
                }
            };

            return oUsuario;
        }
    }
}
