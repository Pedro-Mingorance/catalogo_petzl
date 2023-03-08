
namespace winform_app
{
    partial class frmLecturaArneses
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
            this.pbxArneses = new System.Windows.Forms.PictureBox();
            this.dgvArneses = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArneses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArneses)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxArneses
            // 
            this.pbxArneses.Location = new System.Drawing.Point(583, 77);
            this.pbxArneses.Name = "pbxArneses";
            this.pbxArneses.Size = new System.Drawing.Size(260, 260);
            this.pbxArneses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArneses.TabIndex = 0;
            this.pbxArneses.TabStop = false;
            // 
            // dgvArneses
            // 
            this.dgvArneses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArneses.Location = new System.Drawing.Point(12, 77);
            this.dgvArneses.Name = "dgvArneses";
            this.dgvArneses.Size = new System.Drawing.Size(565, 259);
            this.dgvArneses.TabIndex = 1;
            this.dgvArneses.SelectionChanged += new System.EventHandler(this.dgvArneses_SelectionChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(769, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(12, 415);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datos de la base de datos";
            // 
            // frmLecturaArneses
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvArneses);
            this.Controls.Add(this.pbxArneses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLecturaArneses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLecturaArneses";
            this.Load += new System.EventHandler(this.frmLecturaArneses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArneses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArneses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxArneses;
        private System.Windows.Forms.DataGridView dgvArneses;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
    }
}