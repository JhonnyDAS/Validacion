namespace Reporte.Vista.Reporte
{
    partial class frmRepListaVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsFunciones = new Modelo.dsFunciones();
            this.sprListaVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprListaVentaTableAdapter = new Modelo.dsFuncionesTableAdapters.sprListaVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsFunciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprListaVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsReporte";
            reportDataSource1.Value = this.sprListaVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reporte.Vista.Reporte.repListaVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(578, 398);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsFunciones
            // 
            this.dsFunciones.DataSetName = "dsFunciones";
            this.dsFunciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprListaVentaBindingSource
            // 
            this.sprListaVentaBindingSource.DataMember = "sprListaVenta";
            this.sprListaVentaBindingSource.DataSource = this.dsFunciones;
            // 
            // sprListaVentaTableAdapter
            // 
            this.sprListaVentaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepListaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 398);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepListaVenta";
            this.Text = "frmRepListaVenta";
            this.Load += new System.EventHandler(this.frmRepListaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsFunciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprListaVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Modelo.dsFunciones dsFunciones;
        private System.Windows.Forms.BindingSource sprListaVentaBindingSource;
        private Modelo.dsFuncionesTableAdapters.sprListaVentaTableAdapter sprListaVentaTableAdapter;
    }
}