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
   public  class RepositorioCuenta:Singleton<RepositorioCuenta>
    {
        private List<Cuenta> ListaCuenta = new List<Cuenta>();
        static RepositorioCuenta instance = null;
        SqlConnection conexion = new SqlConnection();

        //AGREGAR CUENTA

        public int AgregarCuente(Cuenta oCuenta)
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Agregar_Cuenta";
            c.Parameters.AddWithValue("nombre",oCuenta.Nombre);
            c.Parameters.AddWithValue("password", oCuenta.Password);
            c.Parameters.AddWithValue("cuenta", oCuenta.Cuenta1);
            int affectedRows = c.ExecuteNonQuery();
            conexion.Close();
            return affectedRows;
        }

        //LISTADO DE CUENTAS

        public List<Cuenta> DevolverCuentas()
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Lista_Cuentas";
            c.Prepare();
            SqlDataReader dn = c.ExecuteReader();
            while (dn.Read())
            {
                string nombre = dn.GetString(1);
                string pass = dn.GetString(2);
                string cuenta = dn.GetString(3);
                Cuenta oCuenta = new Cuenta(nombre, pass, cuenta);
                oCuenta.IdCuenta = dn.GetInt32(0);
                ListaCuenta.Add(oCuenta);
            }
            dn.Close();
            conexion.Close();
            return ListaCuenta;
        }
    }
}
