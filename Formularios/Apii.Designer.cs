namespace Proyecto4.Formularios
{
    partial class Apii
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
            this.SolicitarCodigo = new MaterialSkin.Controls.MaterialButton();
            this.VerificarCodigo = new MaterialSkin.Controls.MaterialButton();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.txtContraseña = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // SolicitarCodigo
            // 
            this.SolicitarCodigo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SolicitarCodigo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SolicitarCodigo.Depth = 0;
            this.SolicitarCodigo.HighEmphasis = true;
            this.SolicitarCodigo.Icon = null;
            this.SolicitarCodigo.Location = new System.Drawing.Point(417, 131);
            this.SolicitarCodigo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SolicitarCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.SolicitarCodigo.Name = "SolicitarCodigo";
            this.SolicitarCodigo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SolicitarCodigo.Size = new System.Drawing.Size(152, 36);
            this.SolicitarCodigo.TabIndex = 0;
            this.SolicitarCodigo.Text = "Solicitar Codigo";
            this.SolicitarCodigo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SolicitarCodigo.UseAccentColor = false;
            this.SolicitarCodigo.UseVisualStyleBackColor = true;
            this.SolicitarCodigo.Click += new System.EventHandler(this.SolicitarCodigo_Click);
            // 
            // VerificarCodigo
            // 
            this.VerificarCodigo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VerificarCodigo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.VerificarCodigo.Depth = 0;
            this.VerificarCodigo.HighEmphasis = true;
            this.VerificarCodigo.Icon = null;
            this.VerificarCodigo.Location = new System.Drawing.Point(417, 192);
            this.VerificarCodigo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.VerificarCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.VerificarCodigo.Name = "VerificarCodigo";
            this.VerificarCodigo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.VerificarCodigo.Size = new System.Drawing.Size(151, 36);
            this.VerificarCodigo.TabIndex = 1;
            this.VerificarCodigo.Text = "Verificar Codigo";
            this.VerificarCodigo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.VerificarCodigo.UseAccentColor = false;
            this.VerificarCodigo.UseVisualStyleBackColor = true;
            this.VerificarCodigo.Click += new System.EventHandler(this.VerificarCodigo_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(31, 158);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(240, 50);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            // 
            // txtContraseña
            // 
            this.txtContraseña.AnimateReadOnly = false;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Depth = 0;
            this.txtContraseña.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContraseña.Hint = "Contraseña";
            this.txtContraseña.LeadingIcon = null;
            this.txtContraseña.Location = new System.Drawing.Point(31, 233);
            this.txtContraseña.MaxLength = 50;
            this.txtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(240, 50);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.Text = "";
            this.txtContraseña.TrailingIcon = null;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AnimateReadOnly = false;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.Hint = "Codigo";
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.Location = new System.Drawing.Point(31, 311);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(240, 50);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.Text = "";
            this.txtCodigo.TrailingIcon = null;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.Hint = "Telefono";
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(31, 95);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(240, 50);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.Text = "";
            this.txtTelefono.TrailingIcon = null;
            // 
            // Apii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 407);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.VerificarCodigo);
            this.Controls.Add(this.SolicitarCodigo);
            this.Name = "Apii";
            this.Text = "Apii";
            this.Load += new System.EventHandler(this.Apii_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton SolicitarCodigo;
        private MaterialSkin.Controls.MaterialButton VerificarCodigo;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtContraseña;
        private MaterialSkin.Controls.MaterialTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
    }
}