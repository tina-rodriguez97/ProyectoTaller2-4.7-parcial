﻿namespace ProyectoTaller2.C_Presentacion.Vendedor
{
    partial class ListarVentasRealizadas
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
            this.gbxVentasRealizadas = new System.Windows.Forms.GroupBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.btnFiltroVen = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFiltrarFecha = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.gridListaProductos = new System.Windows.Forms.DataGridView();
            this.ColNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.gbxVentasRealizadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxVentasRealizadas
            // 
            this.gbxVentasRealizadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gbxVentasRealizadas.Controls.Add(this.cbxCliente);
            this.gbxVentasRealizadas.Controls.Add(this.label1);
            this.gbxVentasRealizadas.Controls.Add(this.lblHasta);
            this.gbxVentasRealizadas.Controls.Add(this.lblDesde);
            this.gbxVentasRealizadas.Controls.Add(this.btnFiltroVen);
            this.gbxVentasRealizadas.Controls.Add(this.dtpHasta);
            this.gbxVentasRealizadas.Controls.Add(this.dtpDesde);
            this.gbxVentasRealizadas.Controls.Add(this.lblFiltrarFecha);
            this.gbxVentasRealizadas.Controls.Add(this.lblVentas);
            this.gbxVentasRealizadas.Location = new System.Drawing.Point(12, 12);
            this.gbxVentasRealizadas.Name = "gbxVentasRealizadas";
            this.gbxVentasRealizadas.Size = new System.Drawing.Size(856, 127);
            this.gbxVentasRealizadas.TabIndex = 0;
            this.gbxVentasRealizadas.TabStop = false;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(676, 21);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 9;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(556, 21);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 8;
            this.lblDesde.Text = "Desde";
            // 
            // btnFiltroVen
            // 
            this.btnFiltroVen.Location = new System.Drawing.Point(761, 82);
            this.btnFiltroVen.Name = "btnFiltroVen";
            this.btnFiltroVen.Size = new System.Drawing.Size(71, 25);
            this.btnFiltroVen.TabIndex = 7;
            this.btnFiltroVen.Text = "Filtrar";
            this.btnFiltroVen.UseVisualStyleBackColor = true;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(647, 48);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(98, 20);
            this.dtpHasta.TabIndex = 6;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(532, 48);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(98, 20);
            this.dtpDesde.TabIndex = 5;
            // 
            // lblFiltrarFecha
            // 
            this.lblFiltrarFecha.AutoSize = true;
            this.lblFiltrarFecha.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.lblFiltrarFecha.Location = new System.Drawing.Point(395, 47);
            this.lblFiltrarFecha.Name = "lblFiltrarFecha";
            this.lblFiltrarFecha.Size = new System.Drawing.Size(122, 21);
            this.lblFiltrarFecha.TabIndex = 4;
            this.lblFiltrarFecha.Text = "Filtrar por fecha:";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblVentas.Location = new System.Drawing.Point(16, 16);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(137, 32);
            this.lblVentas.TabIndex = 2;
            this.lblVentas.Text = "Mis Ventas";
            // 
            // gridListaProductos
            // 
            this.gridListaProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.gridListaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridListaProductos.ColumnHeadersHeight = 40;
            this.gridListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNroVenta,
            this.ColFecha,
            this.colCliente,
            this.colCantProductos,
            this.colPrecioTotal,
            this.colVerDetalle});
            this.gridListaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridListaProductos.Location = new System.Drawing.Point(12, 145);
            this.gridListaProductos.Name = "gridListaProductos";
            this.gridListaProductos.RowHeadersVisible = false;
            this.gridListaProductos.Size = new System.Drawing.Size(856, 443);
            this.gridListaProductos.TabIndex = 11;
            // 
            // ColNroVenta
            // 
            this.ColNroVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNroVenta.HeaderText = "Nro Venta";
            this.ColNroVenta.Name = "ColNroVenta";
            this.ColNroVenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColNroVenta.Width = 74;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha de venta";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Width = 393;
            // 
            // colCantProductos
            // 
            this.colCantProductos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCantProductos.HeaderText = "Cantidad de productos";
            this.colCantProductos.Name = "colCantProductos";
            this.colCantProductos.Width = 127;
            // 
            // colPrecioTotal
            // 
            this.colPrecioTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrecioTotal.HeaderText = "Precio total";
            this.colPrecioTotal.Name = "colPrecioTotal";
            this.colPrecioTotal.Width = 79;
            // 
            // colVerDetalle
            // 
            this.colVerDetalle.HeaderText = "VerDetalle";
            this.colVerDetalle.Name = "colVerDetalle";
            this.colVerDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colVerDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colVerDetalle.Text = "Ver detalle";
            this.colVerDetalle.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label1.Location = new System.Drawing.Point(395, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtrar por Cliente:";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(531, 86);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(214, 21);
            this.cbxCliente.TabIndex = 12;
            // 
            // ListarVentasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.gridListaProductos);
            this.Controls.Add(this.gbxVentasRealizadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarVentasRealizadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarVentasRealizadas";
            this.gbxVentasRealizadas.ResumeLayout(false);
            this.gbxVentasRealizadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxVentasRealizadas;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.DataGridView gridListaProductos;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblFiltrarFecha;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button btnFiltroVen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioTotal;
        private System.Windows.Forms.DataGridViewButtonColumn colVerDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCliente;
    }
}