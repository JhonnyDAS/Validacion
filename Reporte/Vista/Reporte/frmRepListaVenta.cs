using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reporte.Vista.Reporte
{
    public partial class frmRepListaVenta : Form
    {
        public frmRepListaVenta()
        {
            InitializeComponent();
        }

        private void frmRepListaVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsFunciones.sprListaVenta' Puede moverla o quitarla según sea necesario.
            this.sprListaVentaTableAdapter.Fill(this.dsFunciones.sprListaVenta);
            this.reportViewer1.RefreshReport();
        }
    }
}
