using Reporte.Controlador;
using Reporte.Controlador.Extencion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reporte.Vista
{
    public partial class frmVentaDetalle : Form
    {
        Venta _objVenta = new Venta();
        DetalleVenta _objDetalleVenta = new DetalleVenta();

        public frmVentaDetalle()
        {
            InitializeComponent();
        }

        private void frmVentaDetalle_Load(object sender, EventArgs e)
        {

        }

        private bool CargarDatos()
        {
            try
            {
                _objVenta.Precio = Convert.ToDouble(precioMaskedTextBox.Text);
                _objVenta.Descripcion = descripcionTextBox.Text;
                _objVenta.Producto = productoComboBox.Text;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool EsValidoLosCamposVenta()
        {
            bool esValido = true;
            esValido = Validacion.valor_requerido(
                precioMaskedTextBox, "Precio",
                descripcionTextBox, "Descripcion"                
                );
            if (!esValido)
                MessageBox.Show(Validacion._error);

            return esValido;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(EsValidoLosCamposVenta())
            {
                if(CargarDatos())
                    _objVenta.Insertar();
            }
        }

    }
}
