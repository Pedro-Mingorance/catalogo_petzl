
namespace winform_app
{
    partial class frmPrincipal
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
            this.btnLecturaArneses = new System.Windows.Forms.Button();
            this.btnEscrituraArneses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLecturaArneses
            // 
            this.btnLecturaArneses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLecturaArneses.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLecturaArneses.Location = new System.Drawing.Point(52, 88);
            this.btnLecturaArneses.Name = "btnLecturaArneses";
            this.btnLecturaArneses.Size = new System.Drawing.Size(109, 23);
            this.btnLecturaArneses.TabIndex = 0;
            this.btnLecturaArneses.Text = "Lectura arneses";
            this.btnLecturaArneses.UseVisualStyleBackColor = true;
            this.btnLecturaArneses.Click += new System.EventHandler(this.btnLecturaArneses_Click);
            // 
            // btnEscrituraArneses
            // 
            this.btnEscrituraArneses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEscrituraArneses.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEscrituraArneses.Location = new System.Drawing.Point(52, 132);
            this.btnEscrituraArneses.Name = "btnEscrituraArneses";
            this.btnEscrituraArneses.Size = new System.Drawing.Size(109, 23);
            this.btnEscrituraArneses.TabIndex = 1;
            this.btnEscrituraArneses.Text = "Escritura arneses";
            this.btnEscrituraArneses.UseVisualStyleBackColor = true;
            this.btnEscrituraArneses.Click += new System.EventHandler(this.btnEscrituraArneses_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(830, 407);
            this.Controls.Add(this.btnEscrituraArneses);
            this.Controls.Add(this.btnLecturaArneses);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLecturaArneses;
        private System.Windows.Forms.Button btnEscrituraArneses;
    }
}