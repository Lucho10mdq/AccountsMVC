using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class Cuenta
    {
        int idCuenta;
        string nombre;
        string password;
        string cuenta;

        public int IdCuenta
        {
            get
            {
                return idCuenta;
            }

            set
            {
                idCuenta = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Cuenta1
        {
            get
            {
                return cuenta;
            }

            set
            {
                cuenta = value;
            }
        }

        public Cuenta(string nombre, string password, string cuenta)
        {
            this.Nombre = nombre;
            this.Password = password;
            this.Cuenta1 = cuenta;
        }
    }
}
