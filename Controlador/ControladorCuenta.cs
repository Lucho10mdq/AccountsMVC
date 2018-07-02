using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorCuenta
    {
        private RepositorioCuenta CuentaLista = RepositorioCuenta.GetInstance();

        public int AgregarCuenta(string nombre,string password,string cuenta)
        {
            var resultado = 0;
            Cuenta oCuenta = new Cuenta(nombre, password, cuenta);
            return resultado=CuentaLista.AgregarCuente(oCuenta);
        }
        public List<Cuenta> DevolverCuentas()
        {
            return CuentaLista.DevolverCuentas();
        }
    }
}
