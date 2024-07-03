namespace Proyecto4.Formularios
{
    partial class Detale_Factura
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
            this.txtIDProducto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCantidadComprada = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIDFactura = new MaterialSkin.Controls.MaterialTextBox();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewDetallefactura = new System.Windows.Forms.DataGridView();
            this.btnBuscarDetalleFactura = new MaterialSkin.Controls.MaterialButton();
            this.txtBuscarDetalleFactura = new MaterialSkin.Controls.MaterialTextBox();
            this.btnActualizarDetalleFactura = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallefactura)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.AnimateReadOnly = false;
            this.txtIDProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDProducto.Depth = 0;
            this.txtIDProducto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIDProducto.Hint = "ID Producto";
            this.txtIDProducto.LeadingIcon = null;
            this.txtIDProducto.Location = new System.Drawing.Point(114, 323);
            this.txtIDProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDProducto.MaxLength = 50;
            this.txtIDProducto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIDProducto.Multiline = false;
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Size = new System.Drawing.Size(298, 50);
            this.txtIDProducto.TabIndex = 1;
            this.txtIDProducto.Text = "";
            this.txtIDProducto.TrailingIcon = null;
            // 
            // txtCantidadComprada
            // 
            this.txtCantidadComprada.AnimateReadOnly = false;
            this.txtCantidadComprada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadComprada.Depth = 0;
            this.txtCantidadComprada.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidadComprada.Hint = "Cantidad Comprada";
            this.txtCantidadComprada.LeadingIcon = null;
            this.txtCantidadComprada.Location = new System.Drawing.Point(114, 409);
            this.txtCantidadComprada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidadComprada.MaxLength = 50;
            this.txtCantidadComprada.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidadComprada.Multiline = false;
            this.txtCantidadComprada.Name = "txtCantidadComprada";
            this.txtCantidadComprada.Size = new System.Drawing.Size(298, 50);
            this.txtCantidadComprada.TabIndex = 2;
            this.txtCantidadComprada.Text = "";
            this.txtCantidadComprada.TrailingIcon = null;
            // 
            // txtIDFactura
            // 
            this.txtIDFactura.AnimateReadOnly = false;
            this.txtIDFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDFactura.Depth = 0;
            this.txtIDFactura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIDFactura.Hint = "ID Factura";
            this.txtIDFactura.LeadingIcon = null;
            this.txtIDFactura.Location = new System.Drawing.Point(114, 496);
            this.txtIDFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDFactura.MaxLength = 50;
            this.txtIDFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIDFactura.Multiline = false;
            this.txtIDFactura.Name = "txtIDFactura";
            this.txtIDFactura.Size = new System.Drawing.Size(298, 50);
            this.txtIDFactura.TabIndex = 3;
            this.txtIDFactura.Text = "";
            this.txtIDFactura.TrailingIcon = null;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = false;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(187, 616);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(141, 55);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridViewDetallefactura
            // 
            this.dataGridViewDetallefactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetallefactura.Location = new System.Drawing.Point(543, 249);
            this.dataGridViewDetallefactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDetallefactura.Name = "dataGridViewDetallefactura";
            this.dataGridViewDetallefactura.RowHeadersWidth = 62;
            this.dataGridViewDetallefactura.Size = new System.Drawing.Size(639, 407);
            this.dataGridViewDetallefactura.TabIndex = 6;
            this.dataGridViewDetallefactura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetallefactura_CellDoubleClick);
            // 
            // btnBuscarDetalleFactura
            // 
            this.btnBuscarDetalleFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarDetalleFactura.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarDetalleFactura.Depth = 0;
            this.btnBuscarDetalleFactura.HighEmphasis = true;
            this.btnBuscarDetalleFactura.Icon = null;
            this.btnBuscarDetalleFactura.Location = new System.Drawing.Point(993, 141);
            this.btnBuscarDetalleFactura.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnBuscarDetalleFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarDetalleFactura.Name = "btnBuscarDetalleFactura";
            this.btnBuscarDetalleFactura.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarDetalleFactura.Size = new System.Drawing.Size(211, 36);
            this.btnBuscarDetalleFactura.TabIndex = 37;
            this.btnBuscarDetalleFactura.Text = "Buscar Detalle Factura";
            this.btnBuscarDetalleFactura.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarDetalleFactura.UseAccentColor = false;
            this.btnBuscarDetalleFactura.UseVisualStyleBackColor = true;
            this.btnBuscarDetalleFactura.Click += new System.EventHandler(this.btnBuscarDetalleFactura_Click);
            // 
            // txtBuscarDetalleFactura
            // 
            this.txtBuscarDetalleFactura.AnimateReadOnly = false;
            this.txtBuscarDetalleFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarDetalleFactura.Depth = 0;
            this.txtBuscarDetalleFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarDetalleFactura.Hint = "Ingrese el ID del detalle factura";
            this.txtBuscarDetalleFactura.LeadingIcon = null;
            this.txtBuscarDetalleFactura.Location = new System.Drawing.Point(543, 127);
            this.txtBuscarDetalleFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarDetalleFactura.MaxLength = 50;
            this.txtBuscarDetalleFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarDetalleFactura.Multiline = false;
            this.txtBuscarDetalleFactura.Name = "txtBuscarDetalleFactura";
            this.txtBuscarDetalleFactura.Size = new System.Drawing.Size(424, 50);
            this.txtBuscarDetalleFactura.TabIndex = 38;
            this.txtBuscarDetalleFactura.Text = "";
            this.txtBuscarDetalleFactura.TrailingIcon = null;
            // 
            // btnActualizarDetalleFactura
            // 
            this.btnActualizarDetalleFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarDetalleFactura.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizarDetalleFactura.Depth = 0;
            this.btnActualizarDetalleFactura.HighEmphasis = true;
            this.btnActualizarDetalleFactura.Icon = null;
            this.btnActualizarDetalleFactura.Location = new System.Drawing.Point(783, 701);
            this.btnActualizarDetalleFactura.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnActualizarDetalleFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarDetalleFactura.Name = "btnActualizarDetalleFactura";
            this.btnActualizarDetalleFactura.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizarDetalleFactura.Size = new System.Drawing.Size(109, 36);
            this.btnActualizarDetalleFactura.TabIndex = 39;
            this.btnActualizarDetalleFactura.Text = "Actualizar";
            this.btnActualizarDetalleFactura.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizarDetalleFactura.UseAccentColor = false;
            this.btnActualizarDetalleFactura.UseVisualStyleBackColor = true;
            this.btnActualizarDetalleFactura.Click += new System.EventHandler(this.btnActualizarDetalleFactura_Click);
            // 
            // Detale_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 793);
            this.Controls.Add(this.btnActualizarDetalleFactura);
            this.Controls.Add(this.txtBuscarDetalleFactura);
            this.Controls.Add(this.btnBuscarDetalleFactura);
            this.Controls.Add(this.dataGridViewDetallefactura);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtIDFactura);
            this.Controls.Add(this.txtCantidadComprada);
            this.Controls.Add(this.txtIDProducto);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Detale_Factura";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.Text = "Detale_Factura";
            this.Load += new System.EventHandler(this.Detale_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallefactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtIDProducto;
        private MaterialSkin.Controls.MaterialTextBox txtCantidadComprada;
        private MaterialSkin.Controls.MaterialTextBox txtIDFactura;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private System.Windows.Forms.DataGridView dataGridViewDetallefactura;
        private MaterialSkin.Controls.MaterialButton btnBuscarDetalleFactura;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarDetalleFactura;
        private MaterialSkin.Controls.MaterialButton btnActualizarDetalleFactura;
    }
}