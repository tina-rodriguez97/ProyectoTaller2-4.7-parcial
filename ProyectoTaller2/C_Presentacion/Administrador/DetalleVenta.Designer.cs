﻿namespace ProyectoTaller2.C_Presentacion.Administrador
{
    partial class DetalleVenta
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnGuardarPdf = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDetalleDeVenta = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgbDetalleProductos = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDetalleProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.btnGuardarPdf);
            this.panelHeader.Controls.Add(this.lblCliente);
            this.panelHeader.Controls.Add(this.lblVendedor);
            this.panelHeader.Controls.Add(this.lblFecha);
            this.panelHeader.Controls.Add(this.lblDetalleDeVenta);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(804, 119);
            this.panelHeader.TabIndex = 0;
            // 
            // btnGuardarPdf
            // 
            this.btnGuardarPdf.Location = new System.Drawing.Point(688, 54);
            this.btnGuardarPdf.Name = "btnGuardarPdf";
            this.btnGuardarPdf.Size = new System.Drawing.Size(82, 33);
            this.btnGuardarPdf.TabIndex = 4;
            this.btnGuardarPdf.Text = "Guardar PDF";
            this.btnGuardarPdf.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblCliente.Location = new System.Drawing.Point(290, 85);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 21);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblVendedor.Location = new System.Drawing.Point(23, 85);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(79, 21);
            this.lblVendedor.TabIndex = 2;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblFecha.Location = new System.Drawing.Point(23, 54);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 21);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblDetalleDeVenta
            // 
            this.lblDetalleDeVenta.AutoSize = true;
            this.lblDetalleDeVenta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblDetalleDeVenta.Location = new System.Drawing.Point(12, 9);
            this.lblDetalleDeVenta.Name = "lblDetalleDeVenta";
            this.lblDetalleDeVenta.Size = new System.Drawing.Size(339, 32);
            this.lblDetalleDeVenta.TabIndex = 0;
            this.lblDetalleDeVenta.Text = "Detalle de la venta Nro: (nn)";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panelFooter.Controls.Add(this.label1);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 461);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(804, 100);
            this.panelFooter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(618, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total: (precio)";
            // 
            // dgbDetalleProductos
            // 
            this.dgbDetalleProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.dgbDetalleProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgbDetalleProductos.ColumnHeadersHeight = 40;
            this.dgbDetalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbDetalleProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNombre,
            this.colDescripcion,
            this.colCantidad,
            this.colPrecioUnitario});
            this.dgbDetalleProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgbDetalleProductos.Location = new System.Drawing.Point(6, 125);
            this.dgbDetalleProductos.Name = "dgbDetalleProductos";
            this.dgbDetalleProductos.RowHeadersVisible = false;
            this.dgbDetalleProductos.Size = new System.Drawing.Size(786, 330);
            this.dgbDetalleProductos.TabIndex = 2;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colID.Width = 43;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Producto";
            this.colNombre.Name = "colNombre";
            this.colNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colCantidad
            // 
            this.colCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 74;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrecioUnitario.HeaderText = "Precio Unit";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.Width = 78;
            // 
            // DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.dgbDetalleProductos);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleVenta";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDetalleProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDetalleDeVenta;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarPdf;
        private System.Windows.Forms.DataGridView dgbDetalleProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
    }
}