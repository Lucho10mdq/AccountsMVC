using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasMVC
{
    public partial class Form1 : Form
    {
        ControladorUsuario cUsuario = new ControladorUsuario();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var message = String.Empty;
            try
            {
                Usuario oUsuario;
                string user = txtUsuario.Text;
                string pass = txtPassword.Text;
                oUsuario = cUsuario.BuscarUsuario(user, pass);
                if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtPassword.Text))
                {
                    if (oUsuario.Usuario1 == user && oUsuario.Password == pass)
                    {
                        MessageBox.Show("Entrando al sistema");
                        Bienvenido formBienvenido = new Bienvenido();
                         formBienvenido.Show();
                        this.Hide();
                    }       
                }
                else
                    MessageBox.Show("No deben quedar campos vacios");              
            }
            catch(Exception ex)
            {
                MessageBox.Show("El socio no existe");
            }
        }
    }
}
