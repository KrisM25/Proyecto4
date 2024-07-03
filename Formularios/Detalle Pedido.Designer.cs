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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(337, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(420, 296);
            this.dataGridView1.TabIndex = 5;
            // 
            // Detalle_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCodProducPedido);
            this.Controls.Add(this.txtIdPedidoDetalle);
            this.Controls.Add(this.txtIDDetalle);
            this.Name = "Detalle_Pedido";
            this.Text = "Detalle_Pedido";
            this.Load += new System.EventHandler(this.Detalle_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtIDDetalle;
        private MaterialSkin.Controls.MaterialTextBox txtIdPedidoDetalle;
        private MaterialSkin.Controls.MaterialTextBox txtCodProducPedido;
        private MaterialSkin.Controls.MaterialTextBox txtCantidad;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}