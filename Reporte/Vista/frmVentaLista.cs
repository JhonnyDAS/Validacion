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
    public partial class frmVentaLista : Form
    {
        public frmVentaLista()
        {
            InitializeComponent();
        }

        private void frmVentaLista_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsFunciones.sprListaVenta' Puede moverla o quitarla según sea necesario.
            this.sprListaVentaTableAdapter.Fill(this.dsFunciones.sprListaVenta);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmVentaDetalle vn = new frmVentaDetalle();
            vn.ShowDialog();
        }
    }
}
