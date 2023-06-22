using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturas
{
    public partial class frmFormularioAdicional : Form
    {
        public frmFormularioAdicional()
        {
            InitializeComponent();
        }

        // Lo ingresado en el textbox del segundo fomrulario lo asigno a un objeto de la clase Factura y se lo paso al formFacturas
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtIngreso2.Text.Length != 0)
            {
                Factura nuevaFact = new Factura();
                nuevaFact.Codigo = txtIngreso2.Text;

                frmFacturas pantalla1 = new frmFacturas(nuevaFact);
                this.Close();
            }
            else
                MessageBox.Show("Ingrese el código de la factura", "Advertencia");
        }

        // Cierro el formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
