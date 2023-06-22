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
    public partial class frmFacturas : Form
    {
        // Instancio un objeto de la clase cola para poder trabajarla
        public Cola miCola = new Cola();

        // Booleano para saber si es la primera vez que se carga este formulario
        private bool cargaFormulario = false;

        // Si es la primera vez que se carga este fomr, que lo inicialice y ponga en true a cargaFormulario. 
        // Si no es la primera vez que inicia entra al else y hace uso de los métodos con el objeto de tipo Factura que recibe del segundo form
        public frmFacturas(Factura fact)
        {

            if (!cargaFormulario)
            {
                // Ejecutar código adicional aquí que solo se debe ejecutar la primera vez
                InitializeComponent();
                cargaFormulario = true;
            }
            else
            {
                miCola.Encolar(fact);
                MostrarCola();
            }         
        }

        // Cierra la ventana del formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Agrega item a la cola
        public void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtIngreso.Text.Length != 0)
            {
                Factura fact = new Factura();
                fact.Codigo = txtIngreso.Text;
                miCola.Encolar(fact);
                MostrarCola();
                txtIngreso.Text = "";
            }
            else
                MessageBox.Show("Ingrese el código de la factura", "Advertencia");
        }

        // Agrega los items al list box 
        public void MostrarCola()
        {
            lbxFacturas.Items.Clear();
            MostrarItemEnListBox(miCola.Inicio);
        }

        // Función recursiva. Recibe un item que si no es null, lo agrega al listbox. Y le pasa a la misma función el siguiente item
        public void MostrarItemEnListBox(Factura fact)
        {
            if (fact != null)
                lbxFacturas.Items.Add(fact.Codigo);

            if (fact != null)
            {
                MostrarItemEnListBox(fact.Siguiente);
            }
        }

        // Elimino item de la cola
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (miCola.Vacia())
                MessageBox.Show("No hay ninguna factura en la cola.", "Advertencia");
            else
            {
                miCola.Desencolar();
                MostrarCola();
            }
        }

        // Muestra el primer item de la cola
        private void btnTope_Click(object sender, EventArgs e)
        {
            lbxFacturas.Items.Clear();
            MostrarPeekEnListBox(miCola.Inicio);
        }

        // Recibe el primer item de la cola y lo agrega al listbox
        private void MostrarPeekEnListBox(Factura fact)
        {
            if (fact != null)
                lbxFacturas.Items.Add(fact.Codigo);
        }

        // Invoco al frmFormularioAdicional
        private void btnCargarAlternativo_Click(object sender, EventArgs e)
        {
            frmFormularioAdicional form = new frmFormularioAdicional();
            form.ShowDialog();

        }
    }
}
