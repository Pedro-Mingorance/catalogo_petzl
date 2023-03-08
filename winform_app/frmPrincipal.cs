using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnLecturaArneses_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmLecturaArneses))
                {
                    MessageBox.Show("Error: esta ventana ya se encuentra abierta");
                        return;
                }
            }
            frmLecturaArneses ventana = new frmLecturaArneses();
            ventana.ShowDialog();
        }

        private void btnEscrituraArneses_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmEscrituraArneses))
                {
                    MessageBox.Show("Error: esta ventana ya se encuentra abierta");
                    return;
                }
            }
            frmEscrituraArneses ventana = new frmEscrituraArneses();
            ventana.ShowDialog();
        }

    }
}
