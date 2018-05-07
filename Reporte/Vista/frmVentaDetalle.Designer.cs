namespace Reporte.Vista
{
    partial class frmVentaDetalle
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
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label productoLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label precioUnitarioLabel;
            this.dsVenta = new Modelo.dsVenta();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaTableAdapter = new Modelo.dsVentaTableAdapters.VentaTableAdapter();
            this.tableAdapterManager = new Modelo.dsVentaTableAdapters.TableAdapterManager();
            this.detalleVentaTableAdapter = new Modelo.dsVentaTableAdapters.DetalleVentaTableAdapter();
            this.precioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.productoComboBox = new System.Windows.Forms.ComboBox();
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.precioUnitarioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            precioLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            productoLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            precioUnitarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(36, 51);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 1;
            precioLabel.Text = "Precio:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(36, 77);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // productoLabel
            // 
            productoLabel.AutoSize = true;
            productoLabel.Location = new System.Drawing.Point(36, 103);
            productoLabel.Name = "productoLabel";
            productoLabel.Size = new System.Drawing.Size(53, 13);
            productoLabel.TabIndex = 5;
            productoLabel.Text = "Producto:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(250, 61);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 6;
            cantidadLabel.Text = "Cantidad:";
            // 
            // precioUnitarioLabel
            // 
            precioUnitarioLabel.AutoSize = true;
            precioUnitarioLabel.Location = new System.Drawing.Point(250, 90);
            precioUnitarioLabel.Name = "precioUnitarioLabel";
            precioUnitarioLabel.Size = new System.Drawing.Size(79, 13);
            precioUnitarioLabel.TabIndex = 8;
            precioUnitarioLabel.Text = "Precio Unitario:";
            // 
            // dsVenta
            // 
            this.dsVenta.DataSetName = "dsVenta";
            this.dsVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "Venta";
            this.ventaBindingSource.DataSource = this.dsVenta;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DetalleVentaTableAdapter = this.detalleVentaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Modelo.dsVentaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = this.ventaTableAdapter;
            // 
            // detalleVentaTableAdapter
            // 
            this.detalleVentaTableAdapter.ClearBeforeFill = true;
            // 
            // precioMaskedTextBox
            // 
            this.precioMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Precio", true));
            this.precioMaskedTextBox.Location = new System.Drawing.Point(108, 48);
            this.precioMaskedTextBox.Mask = "999";
            this.precioMaskedTextBox.Name = "precioMaskedTextBox";
            this.precioMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.precioMaskedTextBox.TabIndex = 2;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(108, 74);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(121, 20);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // productoComboBox
            // 
            this.productoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Producto", true));
            this.productoComboBox.FormattingEnabled = true;
            this.productoComboBox.Location = new System.Drawing.Point(108, 100);
            this.productoComboBox.Name = "productoComboBox";
            this.productoComboBox.Size = new System.Drawing.Size(121, 21);
            this.productoComboBox.TabIndex = 6;
            // 
            // detalleVentaBindingSource
            // 
            this.detalleVentaBindingSource.DataMember = "DetalleVenta";
            this.detalleVentaBindingSource.DataSource = this.dsVenta;
            // 
            // cantidadNumericUpDown
            // 
            this.cantidadNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.detalleVentaBindingSource, "Cantidad", true));
            this.cantidadNumericUpDown.Location = new System.Drawing.Point(335, 61);
            this.cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            this.cantidadNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cantidadNumericUpDown.TabIndex = 7;
            // 
            // precioUnitarioMaskedTextBox
            // 
            this.precioUnitarioMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "PrecioUnitario", true));
            this.precioUnitarioMaskedTextBox.Location = new System.Drawing.Point(335, 87);
            this.precioUnitarioMaskedTextBox.Name = "precioUnitarioMaskedTextBox";
            this.precioUnitarioMaskedTextBox.Size = new System.Drawing.Size(120, 20);
            this.precioUnitarioMaskedTextBox.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(380, 138);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmVentaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 173);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadNumericUpDown);
            this.Controls.Add(precioUnitarioLabel);
            this.Controls.Add(this.precioUnitarioMaskedTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioMaskedTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(productoLabel);
            this.Controls.Add(this.productoComboBox);
            this.Name = "frmVentaDetalle";
            this.Text = "frmVentaDetalle";
            this.Load += new System.EventHandler(this.frmVentaDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Modelo.dsVenta dsVenta;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private Modelo.dsVentaTableAdapters.VentaTableAdapter ventaTableAdapter;
        private Modelo.dsVentaTableAdapters.TableAdapterManager tableAdapterManager;
        private Modelo.dsVentaTableAdapters.DetalleVentaTableAdapter detalleVentaTableAdapter;
        private System.Windows.Forms.MaskedTextBox precioMaskedTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox productoComboBox;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private System.Windows.Forms.NumericUpDown cantidadNumericUpDown;
        private System.Windows.Forms.MaskedTextBox precioUnitarioMaskedTextBox;
        private System.Windows.Forms.Button btnAceptar;
    }
}