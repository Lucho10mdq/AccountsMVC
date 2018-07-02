using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public  class Usuario
    {
        int idUsuario;
        string usuario;
        string password;

        public Usuario(string usuario, string password)
        {
            this.usuario = usuario;
            this.password = password;
        }

        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        public string Usuario1
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
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
    }
}
