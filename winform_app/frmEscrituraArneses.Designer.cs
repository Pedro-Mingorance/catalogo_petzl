
namespace winform_app
{
    partial class frmEscrituraArneses
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombreArnes = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaFabricacion = new System.Windows.Forms.Label();
            this.lblUsoRecomendado = new System.Windows.Forms.Label();
            this.txtNombreArnes = new System.Windows.Forms.TextBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.cboUsoRecomendado = new System.Windows.Forms.ComboBox();
            this.dtpFechaFabricacion = new System.Windows.Forms.DateTimePicker();
            this.lblUsoNoRecomendado = new System.Windows.Forms.Label();
            this.rbtMujer = new System.Windows.Forms.RadioButton();
            this.rbtUnisex = new System.Windows.Forms.RadioButton();
            this.rbtJunior = new System.Windows.Forms.RadioButton();
            this.gbtTipoUsuario = new System.Windows.Forms.GroupBox();
            this.cboUsoNoRecomendado = new System.Windows.Forms.ComboBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.txtTipoUsuario = new System.Windows.Forms.TextBox();
            this.gbtTipoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Location = new System.Drawing.Point(12, 415);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseCompatibleTextRendering = true;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(763, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombreArnes
            // 
            this.lblNombreArnes.AutoSize = true;
            this.lblNombreArnes.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNombreArnes.Location = new System.Drawing.Point(163, 78);
            this.lblNombreArnes.Name = "lblNombreArnes";
            this.lblNombreArnes.Size = new System.Drawing.Size(73, 13);
            this.lblNombreArnes.TabIndex = 2;
            this.lblNombreArnes.Text = "Nombre arnes";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitulo.Location = new System.Drawing.Point(161, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(357, 26);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Datos para cargar en base de datos";
            // 
            // lblFechaFabricacion
            // 
            this.lblFechaFabricacion.AutoSize = true;
            this.lblFechaFabricacion.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFechaFabricacion.Location = new System.Drawing.Point(163, 104);
            this.lblFechaFabricacion.Name = "lblFechaFabricacion";
            this.lblFechaFabricacion.Size = new System.Drawing.Size(107, 13);
            this.lblFechaFabricacion.TabIndex = 4;
            this.lblFechaFabricacion.Text = "Fecha de fabricacion";
            // 
            // lblUsoRecomendado
            // 
            this.lblUsoRecomendado.AutoSize = true;
            this.lblUsoRecomendado.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUsoRecomendado.Location = new System.Drawing.Point(163, 182);
            this.lblUsoRecomendado.Name = "lblUsoRecomendado";
            this.lblUsoRecomendado.Size = new System.Drawing.Size(94, 13);
            this.lblUsoRecomendado.TabIndex = 5;
            this.lblUsoRecomendado.Text = "Uso recomendado";
            // 
            // txtNombreArnes
            // 
            this.txtNombreArnes.Location = new System.Drawing.Point(328, 78);
            this.txtNombreArnes.Name = "txtNombreArnes";
            this.txtNombreArnes.Size = new System.Drawing.Size(328, 20);
            this.txtNombreArnes.TabIndex = 7;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(328, 156);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(328, 20);
            this.txtUrlImagen.TabIndex = 8;
            // 
            // cboUsoRecomendado
            // 
            this.cboUsoRecomendado.FormattingEnabled = true;
            this.cboUsoRecomendado.Location = new System.Drawing.Point(328, 182);
            this.cboUsoRecomendado.Name = "cboUsoRecomendado";
            this.cboUsoRecomendado.Size = new System.Drawing.Size(328, 21);
            this.cboUsoRecomendado.TabIndex = 9;
            // 
            // dtpFechaFabricacion
            // 
            this.dtpFechaFabricacion.Location = new System.Drawing.Point(328, 104);
            this.dtpFechaFabricacion.Name = "dtpFechaFabricacion";
            this.dtpFechaFabricacion.Size = new System.Drawing.Size(328, 20);
            this.dtpFechaFabricacion.TabIndex = 10;
            // 
            // lblUsoNoRecomendado
            // 
            this.lblUsoNoRecomendado.AutoSize = true;
            this.lblUsoNoRecomendado.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUsoNoRecomendado.Location = new System.Drawing.Point(163, 209);
            this.lblUsoNoRecomendado.Name = "lblUsoNoRecomendado";
            this.lblUsoNoRecomendado.Size = new System.Drawing.Size(116, 13);
            this.lblUsoNoRecomendado.TabIndex = 11;
            this.lblUsoNoRecomendado.Text = "Uso No Recomendado";
            // 
            // rbtMujer
            // 
            this.rbtMujer.AutoSize = true;
            this.rbtMujer.Location = new System.Drawing.Point(26, 30);
            this.rbtMujer.Name = "rbtMujer";
            this.rbtMujer.Size = new System.Drawing.Size(51, 17);
            this.rbtMujer.TabIndex = 12;
            this.rbtMujer.TabStop = true;
            this.rbtMujer.Text = "Mujer";
            this.rbtMujer.UseVisualStyleBackColor = true;
            // 
            // rbtUnisex
            // 
            this.rbtUnisex.AutoSize = true;
            this.rbtUnisex.Location = new System.Drawing.Point(141, 30);
            this.rbtUnisex.Name = "rbtUnisex";
            this.rbtUnisex.Size = new System.Drawing.Size(57, 17);
            this.rbtUnisex.TabIndex = 13;
            this.rbtUnisex.TabStop = true;
            this.rbtUnisex.Text = "Unisex";
            this.rbtUnisex.UseVisualStyleBackColor = true;
            // 
            // rbtJunior
            // 
            this.rbtJunior.AutoSize = true;
            this.rbtJunior.Location = new System.Drawing.Point(256, 30);
            this.rbtJunior.Name = "rbtJunior";
            this.rbtJunior.Size = new System.Drawing.Size(53, 17);
            this.rbtJunior.TabIndex = 14;
            this.rbtJunior.TabStop = true;
            this.rbtJunior.Text = "Junior";
            this.rbtJunior.UseVisualStyleBackColor = true;
            // 
            // gbtTipoUsuario
            // 
            this.gbtTipoUsuario.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.gbtTipoUsuario.Controls.Add(this.rbtMujer);
            this.gbtTipoUsuario.Controls.Add(this.rbtJunior);
            this.gbtTipoUsuario.Controls.Add(this.rbtUnisex);
            this.gbtTipoUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.gbtTipoUsuario.Location = new System.Drawing.Point(328, 236);
            this.gbtTipoUsuario.Name = "gbtTipoUsuario";
            this.gbtTipoUsuario.Size = new System.Drawing.Size(328, 78);
            this.gbtTipoUsuario.TabIndex = 15;
            this.gbtTipoUsuario.TabStop = false;
            this.gbtTipoUsuario.Text = "Tipo de usuario";
            // 
            // cboUsoNoRecomendado
            // 
            this.cboUsoNoRecomendado.FormattingEnabled = true;
            this.cboUsoNoRecomendado.Location = new System.Drawing.Point(328, 209);
            this.cboUsoNoRecomendado.Name = "cboUsoNoRecomendado";
            this.cboUsoNoRecomendado.Size = new System.Drawing.Size(328, 21);
            this.cboUsoNoRecomendado.TabIndex = 16;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUrlImagen.Location = new System.Drawing.Point(163, 156);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(57, 13);
            this.lblUrlImagen.TabIndex = 17;
            this.lblUrlImagen.Text = "Url imagen";
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTipoUsuario.Location = new System.Drawing.Point(163, 130);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(65, 13);
            this.lblTipoUsuario.TabIndex = 18;
            this.lblTipoUsuario.Text = "Tipo usuario";
            // 
            // txtTipoUsuario
            // 
            this.txtTipoUsuario.Location = new System.Drawing.Point(328, 130);
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.Size = new System.Drawing.Size(328, 20);
            this.txtTipoUsuario.TabIndex = 19;
            // 
            // frmEscrituraArneses
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.txtTipoUsuario);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.cboUsoNoRecomendado);
            this.Controls.Add(this.gbtTipoUsuario);
            this.Controls.Add(this.lblUsoNoRecomendado);
            this.Controls.Add(this.dtpFechaFabricacion);
            this.Controls.Add(this.cboUsoRecomendado);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.txtNombreArnes);
            this.Controls.Add(this.lblUsoRecomendado);
            this.Controls.Add(this.lblFechaFabricacion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombreArnes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEscrituraArneses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEscrituraArneses";
            this.gbtTipoUsuario.ResumeLayout(false);
            this.gbtTipoUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombreArnes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaFabricacion;
        private System.Windows.Forms.Label lblUsoRecomendado;
        private System.Windows.Forms.TextBox txtNombreArnes;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.ComboBox cboUsoRecomendado;
        private System.Windows.Forms.DateTimePicker dtpFechaFabricacion;
        private System.Windows.Forms.Label lblUsoNoRecomendado;
        private System.Windows.Forms.RadioButton rbtMujer;
        private System.Windows.Forms.RadioButton rbtUnisex;
        private System.Windows.Forms.RadioButton rbtJunior;
        private System.Windows.Forms.GroupBox gbtTipoUsuario;
        private System.Windows.Forms.ComboBox cboUsoNoRecomendado;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.TextBox txtTipoUsuario;
    }
}