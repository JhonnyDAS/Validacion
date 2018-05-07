namespace Reporte.Vista
{
    partial class frmVentaLista
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
            this.dsFunciones = new Modelo.dsFunciones();
            this.sprListaVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprListaVentaTableAdapter = new Modelo.dsFuncionesTableAdapters.sprListaVentaTableAdapter();
            this.tableAdapterManager = new Modelo.dsFuncionesTableAdapters.TableAdapterManager();
            this.sprListaVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsFunciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprListaVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprListaVentaDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Modelo.dsFuncionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sprListaVentaDataGridView
            // 
            this.sprListaVentaDataGridView.AutoGenerateColumns = false;
            this.sprListaVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sprListaVentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.sprListaVentaDataGridView.DataSource = this.sprListaVentaBindingSource;
            this.sprListaVentaDataGridView.Location = new System.Drawing.Point(12, 38);
            this.sprListaVentaDataGridView.Name = "sprListaVentaDataGridView";
            this.sprListaVentaDataGridView.Size = new System.Drawing.Size(567, 285);
            this.sprListaVentaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PrecioUnitario";
            this.dataGridViewTextBoxColumn5.HeaderText = "PrecioUnitario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(504, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "(+) Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmVentaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 335);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.sprListaVentaDataGridView);
            this.Name = "frmVentaLista";
            this.Text = "frmVentaLista";
            this.Load += new System.EventHandler(this.frmVentaLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsFunciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprListaVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprListaVentaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Modelo.dsFunciones dsFunciones;
        private System.Windows.Forms.BindingSource sprListaVentaBindingSource;
        private Modelo.dsFuncionesTableAdapters.sprListaVentaTableAdapter sprListaVentaTableAdapter;
        private Modelo.dsFuncionesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sprListaVentaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnNuevo;
    }
}