using Reporte.Modelo;
using Reporte.Modelo.dsVentaTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reporte.Controlador
{
    public class Venta
    {
        dsVenta _ds = new dsVenta();
        VentaTableAdapter _taVenta = new VentaTableAdapter();

        #region Atributos y Propiedades
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private string producto;

        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }
        #endregion
        #region Metodos
        public void Insertar()
        {
            try
            {
                _taVenta.Insert(
                    precio,
                    descripcion,
                    producto
                    );
                MessageBox.Show("Venta Realizada Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        #endregion
    }
}
