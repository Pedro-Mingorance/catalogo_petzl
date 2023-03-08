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
    public partial class frmLecturaArneses : Form
    {
        private List<Arnes> listaArnes;
        public frmLecturaArneses()
        {
            InitializeComponent();
        }

        private void frmLecturaArneses_Load(object sender, EventArgs e)
        {
            ArnesNegocio negocio = new ArnesNegocio();
            listaArnes = negocio.listar();
            dgvArneses.DataSource = listaArnes;
            dgvArneses.Columns["UrlImagen"].Visible = false;
            dgvArneses.Columns["TipoUsuario"].Visible = false;
            cargarImagen(listaArnes[0].UrlImagen);
        }

        private void dgvArneses_SelectionChanged(object sender, EventArgs e)
        {
            Arnes seleccionado = (Arnes)dgvArneses.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArneses.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxArneses.Load("https://thumbs.dreamstime.com/b/ninguna-imagen-de-la-u%C3%B1a-del-pulgar-placeholder-para-los-foros-blogs-y-las-p%C3%A1ginas-web-148010362.jpg");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEscrituraArneses alta = new frmEscrituraArneses();
            alta.ShowDialog();
        }
    }
}
