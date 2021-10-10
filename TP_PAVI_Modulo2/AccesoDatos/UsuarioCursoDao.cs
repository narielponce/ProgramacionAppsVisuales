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
    public class UsuarioCursoDao
    {

        public IList<UsuarioCurso> GetAll()
        {
            List<UsuarioCurso> listadoUsuarios = new List<UsuarioCurso>();

            String strSql = string.Concat(" SELECT id_usuario, ",
                                          "        id_curso, ",
                                          "        p.usuario",
                                          "        puntuacion, ",
                                          "        observaciones, ",
                                          "        fecha_inicio, ",
                                          "        fecha_fin ",
                                          "   FROM UsuariosCurso u",
                                          "  INNER JOIN Usuarios p ON u.id_usuario = p.id_usuario " +
                                          "  WHERE u.borrado = 0 ");

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoUsuarios.Add(ObjectMapping(row));
            }

            return listadoUsuarios;
        }
        public UsuarioCurso GetUser(string nombreUsuario)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT id_usuario, ",
                                          "        id_curso, ",
                                          "        p.usuario",
                                          "        puntuacion, ",
                                          "        observaciones, ",
                                          "        fecha_inicio, ",
                                          "        fecha_fin ",
                                          "   FROM UsuariosCurso u",
                                          "  INNER JOIN Usuarios p ON u.id_usuario= p.id_usuario ",
                                          "  WHERE usuario = @usuario");

            var parametros = new Dictionary<string, object>();
            parametros.Add("usuario", nombreUsuario);
            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DataManager.GetInstance().ConsultaSQL(strSql, parametros);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }

        public IList<UsuarioCurso> GetByFilters(Dictionary<string, object> parametros)
        {
            List<UsuarioCurso> lst = new List<UsuarioCurso>();
            String strSql = string.Concat(" SELECT id_usuario, ",
                                          "        c.nombre, ",
                                          "        puntuacion, ",
                                          "        observaciones, ",
                                          "        fecha_inicio, ",
                                          "        fecha_fin ",
                                          "   FROM UsuariosCurso u",
                                          "  INNER JOIN Cursos c ON u.id_curso = p.id_curso ",
                                          "  WHERE u.borrado = 0");

            if (parametros.ContainsKey("usuario"))
                strSql += " AND (u.usuario LIKE '%' + @usuario + '%') ";

            var resultado = DataManager.GetInstance().ConsultaSQL(strSql, parametros);

            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        internal bool Create(UsuarioCurso oUsuario)
        {
            string str_sql = "     INSERT INTO UsuariosCurso (id_curso, puntuacion, observaciones, fecha_inicio, fecha_fin)" +
                             "     VALUES (@id_curso, @puntuacion, @observaciones, @fecha_inicio, @fecha_fin)";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_curso", oUsuario.curso.idCurso);
            parametros.Add("puntuacion", oUsuario.puntuacion);
            parametros.Add("observaciones", oUsuario.observaciones);
            parametros.Add("fecha_inicio", oUsuario.fechaInicio);
            parametros.Add("fecha_fin", oUsuario.fechaFin);
            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return (DataManager.GetInstance().EjecutarSQL(str_sql, parametros) == 1);
        }

        internal bool Update(UsuarioCurso oUsuario)
        {
            string str_sql = "UPDATE UsuariosCurso SET IdCurso=@id_curso, Puntuacion=@puntuacion, Observaciones=@observaciones, FechaInicio=@fecha_inicio, FechaFin=@fecha_fin";
            var parametros = new Dictionary<string, object>();
            parametros.Add("id_curso", oUsuario.curso.idCurso);
            parametros.Add("puntuacion", oUsuario.puntuacion);
            parametros.Add("observaciones", oUsuario.observaciones);
            parametros.Add("fecha_inicio", oUsuario.fechaInicio);
            parametros.Add("fecha_fin",oUsuario.fechaFin);

            return (DataManager.GetInstance().EjecutarSQL(str_sql, parametros) == 1);
        }

        internal bool Delete(UsuarioCurso oUsuario)
        {
            throw new NotImplementedException();
        }


        private UsuarioCurso ObjectMapping(DataRow row)
        {
            UsuarioCurso oUsuario = new UsuarioCurso
            {
                idUsuario = Convert.ToInt32(row["id_usuario"].ToString()),
                curso = new Curso() {
                    idCurso = Convert.ToInt32(row["id_curso"].ToString())
                },
                puntuacion = Convert.ToInt32(row["puntuacion"].ToString()),
                observaciones = row["observaciones"].ToString(),
                fechaInicio = Convert.ToDateTime(row["fecha_inicio"].ToString()),
                fechaFin = Convert.ToDateTime(row["fecha_fin"].ToString())
            };

            return oUsuario;
        }
    }

}