namespace Proyecto4.Formularios
{
    partial class Detalle_Pedido
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
            this.txtIDDetalle = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIdPedidoDetalle = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCodProducPedido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCantidad = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewDetallePedido = new System.Windows.Forms.DataGridView();
            this.btnBuscarDetallePedido = new MaterialSkin.Controls.MaterialButton();
            this.txtBuscarDetallePedido = new MaterialSkin.Controls.MaterialTextBox();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallePedido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDDetalle
            // 
            this.txtIDDetalle.AnimateReadOnly = false;
            this.txtIDDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDDetalle.Depth = 0;
            this.txtIDDetalle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIDDetalle.Hint = "ID Detalle";
            this.txtIDDetalle.LeadingIcon = null;
            this.txtIDDetalle.Location = new System.Drawing.Point(62, 128);
            this.txtIDDetalle.MaxLength = 50;
            this.txtIDDetalle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIDDetalle.Multiline = false;
            this.txtIDDetalle.Name = "txtIDDetalle";
            this.txtIDDetalle.Size = new System.Drawing.Size(219, 50);
            this.txtIDDetalle.TabIndex = 0;
            this.txtIDDetalle.Text = "";
            this.txtIDDetalle.TrailingIcon = null;
            this.txtIDDetalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDDetalle_KeyPress);
            // 
            // txtIdPedidoDetalle
            // 
            this.txtIdPedidoDetalle.AnimateReadOnly = false;
            this.txtIdPedidoDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdPedidoDetalle.Depth = 0;
            this.txtIdPedidoDetalle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdPedidoDetalle.Hint = "ID Detalle Pedido";
            this.txtIdPedidoDetalle.LeadingIcon = null;
            this.txtIdPedidoDetalle.Location = new System.Drawing.Point(62, 184);
            this.txtIdPedidoDetalle.MaxLength = 50;
            this.txtIdPedidoDetalle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdPedidoDetalle.Multiline = false;
            this.txtIdPedidoDetalle.Name = "txtIdPedidoDetalle";
            this.txtIdPedidoDetalle.Size = new System.Drawing.Size(219, 50);
            this.txtIdPedidoDetalle.TabIndex = 1;
            this.txtIdPedidoDetalle.Text = "";
            this.txtIdPedidoDetalle.TrailingIcon = null;
            this.txtIdPedidoDetalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPedidoDetalle_KeyPress);
            // 
            // txtCodProducPedido
            // 
            this.txtCodProducPedido.AnimateReadOnly = false;
            this.txtCodProducPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodProducPedido.Depth = 0;
            this.txtCodProducPedido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodProducPedido.Hint = "Cod Producto";
            this.txtCodProducPedido.LeadingIcon = null;
            this.txtCodProducPedido.Location = new System.Drawing.Point(62, 240);
            this.txtCodProducPedido.MaxLength = 50;
            this.txtCodProducPedido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodProducPedido.Multiline = false;
            this.txtCodProducPedido.Name = "txtCodProducPedido";
            this.txtCodProducPedido.Size = new System.Drawing.Size(219, 50);
            this.txtCodProducPedido.TabIndex = 2;
            this.txtCodProducPedido.Text = "";
            this.txtCodProducPedido.TrailingIcon = null;
            this.txtCodProducPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProducPedido_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.AnimateReadOnly = false;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Depth = 0;
            this.txtCantidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidad.Hint = "Cantidad";
            this.txtCantidad.LeadingIcon = null;
            this.txtCantidad.Location = new System.Drawing.Point(62, 296);
            this.txtCantidad.MaxLength = 50;
            this.txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(219, 50);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Text = "";
            this.txtCantidad.TrailingIcon = null;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(122, 364);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(94, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Guardar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDetallePedido
            // 
            this.dataGridViewDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetallePedido.Location = new System.Drawing.Point(361, 151);
            this.dataGridViewDetallePedido.Name = "dataGridViewDetallePedido";
            this.dataGridViewDetallePedido.Size = new System.Drawing.Size(420, 296);
            this.dataGridViewDetallePedido.TabIndex = 5;
            // 
            // btnBuscarDetallePedido
            // 
            this.btnBuscarDetallePedido.AutoSize = false;
            this.btnBuscarDetallePedido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarDetallePedido.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarDetallePedido.Depth = 0;
            this.btnBuscarDetallePedido.HighEmphasis = true;
            this.btnBuscarDetallePedido.Icon = null;
            this.btnBuscarDetallePedido.Location = new System.Drawing.Point(689, 111);
            this.btnBuscarDetallePedido.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarDetallePedido.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarDetallePedido.Name = "btnBuscarDetallePedido";
            this.btnBuscarDetallePedido.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarDetallePedido.Size = new System.Drawing.Size(92, 36);
            this.btnBuscarDetallePedido.TabIndex = 6;
            this.btnBuscarDetallePedido.Text = "Buscar";
            this.btnBuscarDetallePedido.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarDetallePedido.UseAccentColor = false;
            this.btnBuscarDetallePedido.UseVisualStyleBackColor = true;
            // 
            // txtBuscarDetallePedido
            // 
            this.txtBuscarDetallePedido.AnimateReadOnly = false;
            this.txtBuscarDetallePedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarDetallePedido.Depth = 0;
            this.txtBuscarDetallePedido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarDetallePedido.LeadingIcon = null;
            this.txtBuscarDetallePedido.Location = new System.Drawing.Point(361, 97);
            this.txtBuscarDetallePedido.MaxLength = 50;
            this.txtBuscarDetallePedido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarDetallePedido.Multiline = false;
            this.txtBuscarDetallePedido.Name = "txtBuscarDetallePedido";
            this.txtBuscarDetallePedido.Size = new System.Drawing.Size(321, 50);
            this.txtBuscarDetallePedido.TabIndex = 7;
            this.txtBuscarDetallePedido.Text = "";
            this.txtBuscarDetallePedido.TrailingIcon = null;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = false;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(679, 458);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(102, 36);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = false;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(569, 458);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(102, 36);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // Detalle_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 534);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtBuscarDetallePedido);
            this.Controls.Add(this.btnBuscarDetallePedido);
            this.Controls.Add(this.dataGridViewDetallePedido);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCodProducPedido);
            this.Controls.Add(this.txtIdPedidoDetalle);
            this.Controls.Add(this.txtIDDetalle);
            this.Name = "Detalle_Pedido";
            this.Text = "Detalle_Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallePedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtIDDetalle;
        private MaterialSkin.Controls.MaterialTextBox txtIdPedidoDetalle;
        private MaterialSkin.Controls.MaterialTextBox txtCodProducPedido;
        private MaterialSkin.Controls.MaterialTextBox txtCantidad;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridView dataGridViewDetallePedido;
        private MaterialSkin.Controls.MaterialButton btnBuscarDetallePedido;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarDetallePedido;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
    }
}