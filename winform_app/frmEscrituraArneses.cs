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
    public partial class frmEscrituraArneses : Form
    {
        public frmEscrituraArneses()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombreArnes.Text;
            //lwElementos.Items.Add(elem);
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    cboUsoRecomendado.Items.Add("Alpinismo");
        //    cboUsoRecomendado.Items.Add("Esqui");
        //    cboUsoRecomendado.Items.Add("Espeleología");
        //    cboUsoRecomendado.Items.Add("Descenso de barrancos");
        //}

        private void btnDatos_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreArnes.Text;
            DateTime fecha = dtpFechaFabricacion.Value;
            //string productoNuevo = ckbProductoNuevo.Checked == true ? "Es un producto nuevo" : "No es un producto nuevo";
            string tipoUsuario;

            try
            {
                if (rbtMujer.Checked)
                    tipoUsuario = "Mujer";
                else if (rbtUnisex.Checked)
                    tipoUsuario = "Unisex";
                else
                    tipoUsuario = "Junior";

                string tipoArnes = cboUsoRecomendado.SelectedItem.ToString();
                string talle = txtUrlImagen.Text;

                string mensaje = "Nombre: " + nombre + ", Fecha de fabricacion: " + fecha + ", " + ", Diseñado para: " + tipoUsuario + ", Actividad recomendada: " + tipoArnes + ", Los talles disponibles son: " + talle;
                MessageBox.Show(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos ingresados. Verifique que los datos sean correctos y vuelva a intentarlo.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Arnes arnes = new Arnes();
            ArnesNegocio negocio = new ArnesNegocio();

            try
            {
                arnes.NombreArnes = txtNombreArnes.Text;
                //arnes.FechaFabricacion = DateTime.Parse(dtpFechaFabricacion.CustomFormat);
                arnes.TipoUsuario = int.Parse(txtTipoUsuario.Text);
                //arnes.UrlImagen = txtUrlImagen.Text;
                //arnes.UsoRecomendado = (Uso)cboUsoRecomendado.SelectedItem;
                //arnes.UsoNoRecomendado = (Uso)cboUsoNoRecomendado.SelectedItem;

                negocio.agregar(arnes);
                MessageBox.Show("Agregado correctamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmEscrituraArneses_Load(object sender, EventArgs e)
        {
            UsoNegocio usoNegocio = new UsoNegocio();
            {
                try
                {
                    cboUsoRecomendado.DataSource = usoNegocio.listar();
                    cboUsoNoRecomendado.DataSource = usoNegocio.listar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

    }
}
