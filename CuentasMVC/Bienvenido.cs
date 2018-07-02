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
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarCuenta formCuenta = new AgregarCuenta();
            formCuenta.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListadoDeCuentas formListado = new ListadoDeCuentas();
            formListado.Show();
        }
    }
}
