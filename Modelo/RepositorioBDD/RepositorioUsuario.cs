using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Modelo
{
  public  class RepositorioUsuario:Singleton<RepositorioUsuario>
    {
        private List<Usuario> ListaUsuario = new List<Usuario>();
        static RepositorioUsuario instance = null;

        SqlConnection conexion = new SqlConnection();


        //BUSCAR USUARIO

        public Usuario BuscarUsuario(string usuario,string password)
        {
            Usuario oUsuario = null;
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Buscar_Usuario";

            SqlParameter usuarioParameter = c.CreateParameter();
            usuarioParameter.ParameterName = "@usuario";
            usuarioParameter.Value = usuario;
            c.Parameters.Add(usuarioParameter);

            SqlParameter passwordParameter = c.CreateParameter();
            passwordParameter.ParameterName = "@password";
            passwordParameter.Value = password;
            c.Parameters.Add(passwordParameter);

            SqlDataReader dn = c.ExecuteReader();
            while (dn.Read())
            {
                string user = dn.GetString(1);
                string pass = dn.GetString(2);
                oUsuario = new Usuario(user, pass);
            }
            dn.Close();
            conexion.Close();
            return oUsuario;

        }

    }
}
