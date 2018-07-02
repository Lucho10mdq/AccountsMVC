using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorUsuario
    {
        private RepositorioUsuario Usuariolista = RepositorioUsuario.GetInstance();

        public Usuario BuscarUsuario(string usuario,string password)
        {
          return  Usuariolista.BuscarUsuario(usuario, password);
           
        }
    }
}
