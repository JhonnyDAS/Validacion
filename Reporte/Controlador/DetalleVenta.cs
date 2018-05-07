using Reporte.Modelo;
using Reporte.Modelo.dsVentaTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reporte.Controlador
{
    public class DetalleVenta
    {
        dsVenta _ds = new dsVenta();
        DetalleVentaTableAdapter _taDetalleVenta = new DetalleVentaTableAdapter();

        #region Atributos y Propiedades
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private double precioUnitario;

        public double PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }
        private int idVenta;

        public int IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }
        #endregion
        #region Metodos
        public void Insertar()
        {
            try
            {
                _taDetalleVenta.Insert(
                    cantidad,
                    precioUnitario,
                    idVenta
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        #endregion
    }
}
