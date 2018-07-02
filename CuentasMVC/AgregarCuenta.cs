using Controlador;
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
    public partial class AgregarCuenta : Form
    {
        ControladorCuenta cCuenta = new ControladorCuenta();
        public AgregarCuenta()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var result = 0;
            string nombre = txtnombre.Text;
            string pass = txtpass.Text;
            string cuenta = txtcuenta.Text;
            result=cCuenta.AgregarCuenta(nombre, pass, cuenta);
            if (result != 0)
                MessageBox.Show("agregado correctamente");
            else
                MessageBox.Show("No se pudo agregar");
            txtcuenta.Clear();
            txtnombre.Clear();
            txtpass.Clear();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
