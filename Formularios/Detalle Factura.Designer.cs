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
            this.txtCantidadComprada = new MaterialSkin.Controls.MaterialTextBox();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewDetallefactura = new System.Windows.Forms.DataGridView();
            this.btnBuscarDetalleFactura = new MaterialSkin.Controls.MaterialButton();
            this.txtBuscarDetalleFactura = new MaterialSkin.Controls.MaterialTextBox();
            this.btnActualizarDetalleFactura = new MaterialSkin.Controls.MaterialButton();
            this.CBBXIDDetalleFactura = new MaterialSkin.Controls.MaterialComboBox();
            this.CBBXIDProducto = new MaterialSkin.Controls.MaterialComboBox();
            this.CBBXIDFactura = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallefactura)).BeginInit();
            this.SuspendLayout();
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
            this.txtCantidadComprada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadComprada_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = false;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(188, 615);
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
            this.dataGridViewDetallefactura.Size = new System.Drawing.Size(639, 408);
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
            this.btnBuscarDetalleFactura.Location = new System.Drawing.Point(993, 142);
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
            this.txtBuscarDetalleFactura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarDetalleFactura.Hint = "Ingrese el ID del detalle factura";
            this.txtBuscarDetalleFactura.LeadingIcon = null;
            this.txtBuscarDetalleFactura.Location = new System.Drawing.Point(543, 128);
            this.txtBuscarDetalleFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarDetalleFactura.MaxLength = 50;
            this.txtBuscarDetalleFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarDetalleFactura.Multiline = false;
            this.txtBuscarDetalleFactura.Name = "txtBuscarDetalleFactura";
            this.txtBuscarDetalleFactura.Size = new System.Drawing.Size(424, 50);
            this.txtBuscarDetalleFactura.TabIndex = 38;
            this.txtBuscarDetalleFactura.Text = "";
            this.txtBuscarDetalleFactura.TrailingIcon = null;
            this.txtBuscarDetalleFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarDetalleFactura_KeyPress);
            // 
            // btnActualizarDetalleFactura
            // 
            this.btnActualizarDetalleFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarDetalleFactura.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizarDetalleFactura.Depth = 0;
            this.btnActualizarDetalleFactura.HighEmphasis = true;
            this.btnActualizarDetalleFactura.Icon = null;
            this.btnActualizarDetalleFactura.Location = new System.Drawing.Point(783, 702);
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
            // CBBXIDDetalleFactura
            // 
            this.CBBXIDDetalleFactura.AutoResize = false;
            this.CBBXIDDetalleFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CBBXIDDetalleFactura.Depth = 0;
            this.CBBXIDDetalleFactura.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CBBXIDDetalleFactura.DropDownHeight = 174;
            this.CBBXIDDetalleFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBXIDDetalleFactura.DropDownWidth = 121;
            this.CBBXIDDetalleFactura.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CBBXIDDetalleFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CBBXIDDetalleFactura.FormattingEnabled = true;
            this.CBBXIDDetalleFactura.Hint = "ID Datalle Factura";
            this.CBBXIDDetalleFactura.IntegralHeight = false;
            this.CBBXIDDetalleFactura.ItemHeight = 43;
            this.CBBXIDDetalleFactura.Location = new System.Drawing.Point(114, 235);
            this.CBBXIDDetalleFactura.MaxDropDownItems = 4;
            this.CBBXIDDetalleFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.CBBXIDDetalleFactura.Name = "CBBXIDDetalleFactura";
            this.CBBXIDDetalleFactura.Size = new System.Drawing.Size(298, 49);
            this.CBBXIDDetalleFactura.StartIndex = 0;
            this.CBBXIDDetalleFactura.TabIndex = 41;
            // 
            // CBBXIDProducto
            // 
            this.CBBXIDProducto.AutoResize = false;
            this.CBBXIDProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CBBXIDProducto.Depth = 0;
            this.CBBXIDProducto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CBBXIDProducto.DropDownHeight = 174;
            this.CBBXIDProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBXIDProducto.DropDownWidth = 121;
            this.CBBXIDProducto.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CBBXIDProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CBBXIDProducto.FormattingEnabled = true;
            this.CBBXIDProducto.Hint = "Nombre Producto";
            this.CBBXIDProducto.IntegralHeight = false;
            this.CBBXIDProducto.ItemHeight = 43;
            this.CBBXIDProducto.Location = new System.Drawing.Point(114, 322);
            this.CBBXIDProducto.MaxDropDownItems = 4;
            this.CBBXIDProducto.MouseState = MaterialSkin.MouseState.OUT;
            this.CBBXIDProducto.Name = "CBBXIDProducto";
            this.CBBXIDProducto.Size = new System.Drawing.Size(298, 49);
            this.CBBXIDProducto.StartIndex = 0;
            this.CBBXIDProducto.TabIndex = 42;
            // 
            // CBBXIDFactura
            // 
            this.CBBXIDFactura.AutoResize = false;
            this.CBBXIDFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CBBXIDFactura.Depth = 0;
            this.CBBXIDFactura.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CBBXIDFactura.DropDownHeight = 174;
            this.CBBXIDFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBXIDFactura.DropDownWidth = 121;
            this.CBBXIDFactura.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CBBXIDFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CBBXIDFactura.FormattingEnabled = true;
            this.CBBXIDFactura.Hint = "ID de Factura";
            this.CBBXIDFactura.IntegralHeight = false;
            this.CBBXIDFactura.ItemHeight = 43;
            this.CBBXIDFactura.Location = new System.Drawing.Point(114, 499);
            this.CBBXIDFactura.MaxDropDownItems = 4;
            this.CBBXIDFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.CBBXIDFactura.Name = "CBBXIDFactura";
            this.CBBXIDFactura.Size = new System.Drawing.Size(298, 49);
            this.CBBXIDFactura.StartIndex = 0;
            this.CBBXIDFactura.TabIndex = 43;
            // 
            // Detale_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 792);
            this.Controls.Add(this.CBBXIDFactura);
            this.Controls.Add(this.CBBXIDProducto);
            this.Controls.Add(this.CBBXIDDetalleFactura);
            this.Controls.Add(this.btnActualizarDetalleFactura);
            this.Controls.Add(this.txtBuscarDetalleFactura);
            this.Controls.Add(this.btnBuscarDetalleFactura);
            this.Controls.Add(this.dataGridViewDetallefactura);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCantidadComprada);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Detale_Factura";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.Text = "Detalle Factura";
            this.Load += new System.EventHandler(this.Detale_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallefactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtCantidadComprada;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private System.Windows.Forms.DataGridView dataGridViewDetallefactura;
        private MaterialSkin.Controls.MaterialButton btnBuscarDetalleFactura;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarDetalleFactura;
        private MaterialSkin.Controls.MaterialButton btnActualizarDetalleFactura;
        private MaterialSkin.Controls.MaterialComboBox CBBXIDDetalleFactura;
        private MaterialSkin.Controls.MaterialComboBox CBBXIDProducto;
        private MaterialSkin.Controls.MaterialComboBox CBBXIDFactura;
    }
}