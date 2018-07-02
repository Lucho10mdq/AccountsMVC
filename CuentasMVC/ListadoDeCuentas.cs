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
    public partial class ListadoDeCuentas : Form
    {
        ControladorCuenta cCuenta = new ControladorCuenta();
        public ListadoDeCuentas()
        {
            InitializeComponent();
        }

        private void ListadoDeCuentas_Load(object sender, EventArgs e)
        {
            dtgListado.DataSource = null;
            dtgListado.DataSource = cCuenta.DevolverCuentas();
        }
    }
}
